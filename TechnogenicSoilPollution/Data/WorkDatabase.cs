using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace TechnogenicSoilPollution.Data
{
    public static class WorkDatabase
    {
        private static SqlConnection sqlConnection = null;
        private static SqlDataAdapter adapter = null;
        private static System.Data.DataTable table = null;

        static WorkDatabase()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        #region Загрузка химического элементов в ComboBox
        public static void LoadElementsCB(ComboBox comboBox)
        {
            string selectData = "SELECT Name_element FROM ChemicalElements";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "Name_element";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Загрузка годов пробоотбора в ComboBox
        public static void LoadYearsCB(ComboBox comboBox)
        {
            string selectData = "SELECT DISTINCT Year_sampling FROM SamplingPoints";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandFilling = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "Year_sampling";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Экспорт данных в Excel
        public static void ExportDataExcel(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application ExcelFile = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = ExcelFile.Workbooks.Add(Type.Missing);
            Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;

            try
            {
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    worksheet.Cells[1, i].Font.Bold = true;
                }

                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                worksheet.Columns.EntireColumn.AutoFit();
                Range ShtRange;
                ShtRange = worksheet.UsedRange;
                ShtRange.Borders.ColorIndex = 1;
                ShtRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                ShtRange.Borders.Weight = XlBorderWeight.xlThin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Сохранение в Excel",
                Filter = "Документ Excel (*.xlsx)|*xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    MessageBox.Show("Документ Excel сохранён в директории: " + Environment.NewLine + saveFileDialog.FileName + ".xlsx",
                                    "Сохранение документа Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ExcelFile.Quit();
        }
        #endregion

        #region Загрузка данных на основе выборки из 2 ComboBox
        public static void SelectFilterData(ComboBox comboBoxOne, ComboBox comboBoxTwo, DataGridView dataGridView)
        {
            sqlConnection.Open();

            string selectData = $"SELECT SamplingPoints.Direction, SamplingPoints.Number_point, SamplingPoints.Distance, SamplingPoints.Latitude, SamplingPoints.Longitude," +
                $" Phases.Name_phase, ContentElements.Content_elements, ContentElements.Stocks_elements FROM ChemicalElements,SamplingPoints, Phases, ContentElements " +
                $"WHERE ContentElements.Id_elements = ChemicalElements.Id_element AND ContentElements.Id_phases = Phases.Id_phase" +
                $" AND ContentElements.Id_points = SamplingPoints.Id_point AND" +
                $" ChemicalElements.Name_element = '{comboBoxOne.SelectedValue}' AND SamplingPoints.Year_sampling = '{comboBoxTwo.SelectedValue}'";
            adapter = new SqlDataAdapter(selectData, sqlConnection);
            table = new System.Data.DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;

            sqlConnection.Close();
        }
        #endregion

    }
}

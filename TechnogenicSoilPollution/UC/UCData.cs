using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCData : UserControl
    {

        #region Глобальные переменные
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private System.Data.DataTable table = null;
        #endregion

        public UCData()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        #region Загрузка пользовательского контрола
        private void UCData_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            LoadElementsCB();
            LoadYearsCB();

            sqlConnection.Close();
        }
        #endregion

        #region Обработчики кнопок

        private void SelectDataFiltersBtn_Click(object sender, EventArgs e)
        {
            SelectFilterData();
        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteDataBtn_Click(object sender, EventArgs e)
        {
            DeleteDataMethod();
        }

        private void ExportDataBtn_Click(object sender, EventArgs e)
        {
            ExportDataExcel();
        }

        #endregion

        #region Методы

        #region Загрузка химического элементов в ComboBox
        private void LoadElementsCB()
        {
            string selectData = "SELECT Name_element FROM ChemicalElements";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            SelectElementsCB.DataSource = dataTable;
            SelectElementsCB.ValueMember = "Name_element";
            SelectElementsCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Загрузка годов пробоотбора в ComboBox
        private void LoadYearsCB()
        {
            string selectData = "SELECT DISTINCT Year_sampling FROM SamplingPoints";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandFilling = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            SelectYearCB.DataSource = dataTable;
            SelectYearCB.ValueMember = "Year_sampling";
            SelectYearCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Загрузка данных на основе выборки из 2 ComboBox
        private void SelectFilterData()
        {
            sqlConnection.Open();

            string selectData = $"SELECT SamplingPoints.Direction, SamplingPoints.Number_point, SamplingPoints.Distance, SamplingPoints.Latitude, SamplingPoints.Longitude," +
                $" Phases.Name_phase, ContentElements.Content_elements, ContentElements.Stocks_elements FROM ChemicalElements,SamplingPoints, Phases, ContentElements " +
                $"WHERE ContentElements.Id_elements = ChemicalElements.Id_element AND ContentElements.Id_phases = Phases.Id_phase" +
                $" AND ContentElements.Id_points = SamplingPoints.Id_point AND" +
                $" ChemicalElements.Name_element = '{SelectElementsCB.SelectedValue}' AND SamplingPoints.Year_sampling = '{SelectYearCB.SelectedValue}'";
            adapter = new SqlDataAdapter(selectData, sqlConnection);
            table = new System.Data.DataTable();
            adapter.Fill(table);
            MainDataGridView.DataSource = table;

            sqlConnection.Close();
        }
        #endregion

        #region Обновление базы данных
        private void UpdateDataMethod()
        {

        }
        #endregion

        #region Удаление выделенной строки
        private void DeleteDataMethod()
        {
            try
            {
                foreach (DataGridViewRow dataRow in MainDataGridView.SelectedRows)
                {
                    MainDataGridView.Rows.Remove(dataRow);
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Экспорт данных в Excel
        private void ExportDataExcel()
        {
            Microsoft.Office.Interop.Excel.Application ExcelFile = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = ExcelFile.Workbooks.Add(Type.Missing);
            Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;

            try
            {
                for (int i = 1; i < MainDataGridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = MainDataGridView.Columns[i - 1].HeaderText;
                    worksheet.Cells[1, i].Font.Bold = true;
                }

                for (int i = 0; i < MainDataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < MainDataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = MainDataGridView.Rows[i].Cells[j].Value;
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

        #endregion
    }
}

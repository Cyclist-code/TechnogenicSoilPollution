using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data;
using TechnogenicSoilPollution.Forms.Messages;

namespace TechnogenicSoilPollution.Controllers
{
    public static class DatabaseController
    {
        #region Глобальные переменные
        private static SqlConnection sqlConnection = null;
        private static SqlDataAdapter adapter = null;
        private static DataSet dataSet = null;

        private static MessageForm messageForm = new MessageForm();
        #endregion

        static DatabaseController()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        #region Загрузка фаз пробоотбора в ComboBox
        public static void LoadPhasesCB(ComboBox comboBox)
        {
            string selectData = "SELECT * FROM Phases";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "Id_phase";
            comboBox.DisplayMember = "Name_phase";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Загрузка химического элементов в ComboBox
        public static void LoadElementsCB(ComboBox comboBox)
        {
            string selectData = "SELECT Id_element, Name_element FROM ChemicalElements";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "Id_element";
            comboBox.DisplayMember = "Name_element";
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

        #region Загрузка данных на основе выборки из 2 ComboBox
        public static void SelectFilterData(ComboBox SelectElementsCB, ComboBox SelectYearCB, DataGridView dataGridView)
        {
            sqlConnection.Open();

            string selectData = $"SELECT SamplingPoints.Direction, SamplingPoints.Number_point, SamplingPoints.Distance, SamplingPoints.Latitude, SamplingPoints.Longitude, " +
                $"Phases.Name_phase, ContentElements.Content_elements, ContentElements.Stocks_elements, SamplingPoints.Id_point, ContentElements.Id_content " +
                $"FROM ContentElements INNER JOIN SamplingPoints ON ContentElements.Id_points = SamplingPoints.Id_point INNER JOIN Phases ON ContentElements.Id_phases = Phases.Id_phase " +
                $"INNER JOIN ChemicalElements ON ContentElements.Id_elements = ChemicalElements.Id_element WHERE " +
                $"ChemicalElements.Id_element = '{SelectElementsCB.SelectedValue}' AND SamplingPoints.Year_sampling = '{SelectYearCB.SelectedValue}'";
            adapter = new SqlDataAdapter(selectData, sqlConnection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];

            dataGridView.Columns["Id_point"].Visible = false;
            dataGridView.Columns["Id_content"].Visible = false;

            sqlConnection.Close();
        }
        #endregion

        #region Добавление новой строки в DataGridView
        public static void AddNewRowMethod()
        {
            if (dataSet != null)
            {
                DataRow newRow = dataSet.Tables[0].NewRow();
                dataSet.Tables[0].Rows.Add(newRow);
            }
            else
            {               
                messageForm.ShowDialogMessage("Новая строка возможно только при выбранных данных.", "Новая строка", IconMessageForm.Warning);
            }
        }
        #endregion

        #region Обновление существующих данных
        public static void UpdateDataMethod(DataGridView dataGridView, ComboBox comboBox)
        {
            sqlConnection.Open();

            if (dataSet != null)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    if (dataSet.Tables[0].Rows[i].RowState == DataRowState.Modified)
                    {
                        string updateData = "UPDATE SamplingPoints SET Direction = @Direction, Number_point = @Number_point, Distance = @Distance, " +
                        "Latitude = @Latitude, Longitude = @Longitude, Year_sampling = @Year_sampling WHERE Id_point = @Id_point";
                        updateData += " UPDATE ContentElements SET Content_elements = @Content_elements, " +
                            "Stocks_elements = @Stocks_elements WHERE Id_content = @Id_content";
                        SqlCommand command = new SqlCommand(updateData, sqlConnection);
                        command.Parameters.AddWithValue("@Direction", dataGridView.Rows[i].Cells[0].Value);
                        command.Parameters.AddWithValue("@Number_point", dataGridView.Rows[i].Cells[1].Value);
                        command.Parameters.AddWithValue("@Distance", dataGridView.Rows[i].Cells[2].Value);
                        command.Parameters.AddWithValue("@Latitude", dataGridView.Rows[i].Cells[3].Value);
                        command.Parameters.AddWithValue("@Longitude", dataGridView.Rows[i].Cells[4].Value);
                        command.Parameters.AddWithValue("@Year_sampling", comboBox.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@Content_elements", dataGridView.Rows[i].Cells[6].Value);
                        command.Parameters.AddWithValue("@Stocks_elements", dataGridView.Rows[i].Cells[7].Value);
                        command.Parameters.AddWithValue("@Id_point", Convert.ToInt32(dataGridView.CurrentRow.Cells[8].Value));
                        command.Parameters.AddWithValue("@Id_content", Convert.ToInt32(dataGridView.CurrentRow.Cells[9].Value));
                        adapter.UpdateCommand = command;
                        command.ExecuteNonQuery();
                 
                        messageForm.ShowDialogMessage("Существующие данные успешно обновлены.", "Обновление данных", IconMessageForm.Info);
                    }
                }
            }
            else
            {
                messageForm.ShowDialogMessage("Обновление данных возможно только при выбранных данных.", "Обновление данных", IconMessageForm.Warning);
            }

            sqlConnection.Close();
        }
        #endregion

        #region Добавление новых данных
        public static void AddNewDataMethod(ComboBox SelectYearCB, ComboBox SelectElementsCB, ComboBox SelectPhasesCB, DataGridView dataGridView)
        {
            sqlConnection.Open();

            if (dataSet != null)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    if (dataSet.Tables[0].Rows[i].RowState == DataRowState.Added)
                    {
                        string insertData = "INSERT INTO SamplingPoints (Direction, Number_point, Distance, Latitude, Longitude, Year_sampling)" +
                        "VALUES (@Direction, @Number_point, @Distance, @Latitude, @Longitude, @Year_sampling)";
                        insertData += "INSERT INTO ContentElements (Id_elements, Id_phases, Id_points, Content_elements, Stocks_elements) " +
                            "VALUES (@Id_elements, @Id_phases, SCOPE_IDENTITY(), @Content_elements, @Stocks_elements)";

                        SqlCommand command = new SqlCommand(insertData, sqlConnection);
                        command.Parameters.AddWithValue("@Direction", dataGridView.Rows[i].Cells[0].Value);
                        command.Parameters.AddWithValue("@Number_point", dataGridView.Rows[i].Cells[1].Value);
                        command.Parameters.AddWithValue("@Distance", dataGridView.Rows[i].Cells[2].Value);
                        command.Parameters.AddWithValue("@Latitude", dataGridView.Rows[i].Cells[3].Value);
                        command.Parameters.AddWithValue("@Longitude", dataGridView.Rows[i].Cells[4].Value);
                        command.Parameters.AddWithValue("@Year_sampling", SelectYearCB.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@Id_elements", int.Parse(SelectElementsCB.SelectedValue.ToString()));
                        command.Parameters.AddWithValue("@Id_phases", int.Parse(SelectPhasesCB.SelectedValue.ToString()));
                        command.Parameters.AddWithValue("@Content_elements", dataGridView.Rows[i].Cells[6].Value);
                        command.Parameters.AddWithValue("@Stocks_elements", dataGridView.Rows[i].Cells[7].Value);
                        adapter.InsertCommand = command;
                        command.ExecuteNonQuery();
                        
                        messageForm.ShowDialogMessage("Внесённые данные успешно добавлены.", "Добавление данных", IconMessageForm.Info);
                    }
                }
            }
            else
            {
                messageForm.ShowDialogMessage("Добавление данных возможно только при выбранных данных.", "Добавление данных", IconMessageForm.Warning);
            }

            sqlConnection.Close();
        }
        #endregion

        #region Удаление выбранной строки
        public static void DeleteDataMethod(DataGridView dataGridView)
        {
            sqlConnection.Open();

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (dataGridView.CurrentRow.Cells[9].Value != DBNull.Value)
                {
                    string deleteData = "DELETE FROM ContentElements WHERE Id_content = @Id_content";
                    SqlCommand command = new SqlCommand(deleteData, sqlConnection);
                    command.Parameters.AddWithValue("@Id_content", Convert.ToInt32(dataGridView.CurrentRow.Cells[9].Value));
                    command.ExecuteNonQuery();

                    messageForm.ShowDialogMessage("Сохранённые данные успешно удалены.", "Удаление данных", IconMessageForm.Info);
                }
                else
                {
                    messageForm.ShowDialogMessage("Удаление добавленной пустой строки невозможно.", "Удаление данных", IconMessageForm.Warning);
                }

            }

            sqlConnection.Close();
        }
        #endregion

        #region Экспорт данных в Excel
        public static void ExportDataExcelMethod(DataGridView dataGridView)
        {
            if (dataSet != null)
            {
                Microsoft.Office.Interop.Excel.Application ExcelFile = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = ExcelFile.Workbooks.Add(Type.Missing);
                Worksheet worksheet = null;
                worksheet = workbook.ActiveSheet;

                try
                {
                    int k = 1;

                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            if (dataGridView.Columns[j].Visible)
                            {
                                worksheet.Cells[1, k] = dataGridView.Columns[j].HeaderText;
                                worksheet.Cells[1, k].Font.Bold = true;
                                worksheet.Cells[i + 2, k] = dataGridView.Rows[i].Cells[j].Value;
                                k++;
                            }
                        }

                        k = 1;
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
                    messageForm.ShowDialogMessage(ex.Message, "Ошибка экспорта", IconMessageForm.Error);
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
                        messageForm.ShowDialogMessage("Файл сохранён в директории: " + Environment.NewLine + saveFileDialog.FileName + ".xlsx",
                            "Сохранение документа Excel", IconMessageForm.Info);
                    }
                    catch (Exception ex)
                    {
                        messageForm.ShowDialogMessage(ex.Message, "Ошибка экспорта", IconMessageForm.Error);
                    }
                }

                ExcelFile.Quit();
            }
            else
            {
                messageForm.ShowDialogMessage("Экспорт данных в Excel возможен только при выбранных данных.", "Экспорт данных", IconMessageForm.Warning);
            }
        }
        #endregion

        #region Подсказка при наведении на LoadPhasesCB
        public static void ToolTipPhasesCB(System.Windows.Forms.Label materialLabelPhase, ComboBox SelectPhasesCB)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(materialLabelPhase, "Данный выпадающий список нужен\nтолько для добавления новых данных");
            toolTip.SetToolTip(SelectPhasesCB, "Данный выпадающий список нужен\nтолько для добавления новых данных");
        }
        #endregion
    }
}

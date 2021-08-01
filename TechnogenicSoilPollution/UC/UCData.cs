using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using TechnogenicSoilPollution.Controllers;
using TechnogenicSoilPollution.Forms;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCData : UserControl
    {
        #region Глобальные переменные
        private SqlConnection sqlConnection = null;

        int openForm = 0;
        ReferenceWorkDBForm dBForm;
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

            DatabaseController.LoadElementsCB(SelectElementsCB);
            DatabaseController.LoadYearsCB(SelectYearCB);
            DatabaseController.LoadPhasesCB(SelectPhasesCB);
            DatabaseController.ToolTipPhasesCB(materialLabelPhase, SelectPhasesCB);

            sqlConnection.Close();
        }
        #endregion

        #region Обработчики кнопок

        private void SelectDataFiltersBtn_Click(object sender, EventArgs e)
        {
            DatabaseController.SelectFilterData(SelectElementsCB, SelectYearCB, MainDataGridView);
        }

        private void ReferenceDataBaseBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "ReferenceWorkDBForm")
                    openForm = 1;
                else openForm = 0;
            }

            if (openForm == 0)
            {
                dBForm = new ReferenceWorkDBForm();
                dBForm.Show();
            }
        }

        private void AddNewRowBtn_Click(object sender, EventArgs e)
        {
            DatabaseController.AddNewRowMethod();
        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {
            DatabaseController.UpdateDataMethod(MainDataGridView, SelectYearCB);
        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {
            DatabaseController.AddNewDataMethod(SelectYearCB, SelectElementsCB, SelectPhasesCB, MainDataGridView);
        }

        private void DeleteDataBtn_Click(object sender, EventArgs e)
        {
            DatabaseController.DeleteDataMethod(MainDataGridView);
        }

        private void ExportDataBtn_Click(object sender, EventArgs e)
        {
            DatabaseController.ExportDataExcelMethod(MainDataGridView);
        }

        #endregion

        #region Обработка ошибок при вводе неверного формата в DataGridView
        private void MainDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данная ячейка имела неверный формат данных.", "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

    }
}

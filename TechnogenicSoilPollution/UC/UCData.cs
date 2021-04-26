using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using TechnogenicSoilPollution.Data;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCData : UserControl
    {

        #region Глобальные переменные
        private SqlConnection sqlConnection = null;
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

            WorkDatabase.LoadElementsCB(SelectElementsCB);
            WorkDatabase.LoadYearsCB(SelectYearCB);

            sqlConnection.Close();
        }
        #endregion

        #region Обработчики кнопок

        private void SelectDataFiltersBtn_Click(object sender, EventArgs e)
        {
            WorkDatabase.SelectFilterData(SelectElementsCB, SelectYearCB, MainDataGridView);
        }

        private void AddNewRowBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteDataBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ExportDataBtn_Click(object sender, EventArgs e)
        {
            WorkDatabase.ExportDataExcel(MainDataGridView);
        }

        #endregion       
    }
}

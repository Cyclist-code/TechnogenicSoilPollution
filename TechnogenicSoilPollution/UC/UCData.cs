using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCData : UserControl
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private System.Data.DataTable table = null;

        public UCData()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        private void UCData_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            LoadElementsCB();
            LoadYearsCB();

            sqlConnection.Close();
        }

        #region Логика кнопок

        private void SelectDataFiltersBtn_Click(object sender, EventArgs e)
        {
            SelectFilterData();
        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteDataBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Методы

        private void LoadElementsCB()
        {
            string dataFillingComboBox = "SELECT Name_element FROM ChemicalElements";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            SelectElementsBox.DataSource = dataTable;
            SelectElementsBox.ValueMember = "Name_element";
            SelectElementsBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadYearsCB()
        {
            string dataFillingComboBox = "SELECT DISTINCT Year_sampling FROM SamplingPoints";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            SelectYearBox.DataSource = dataTable;
            SelectYearBox.ValueMember = "Year_sampling";
            SelectYearBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SelectFilterData()
        {

        }

        private void UpdateDataMethod()
        {

        }

        private void DeleteDataMethod()
        {

        }

        private void ExportDataExcel()
        {

        }

        #endregion
    }
}

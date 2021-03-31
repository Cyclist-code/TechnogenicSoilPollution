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
            DeleteDataMethod();
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
            SelectElementsCB.DataSource = dataTable;
            SelectElementsCB.ValueMember = "Name_element";
            SelectElementsCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadYearsCB()
        {
            string dataFillingComboBox = "SELECT DISTINCT Year_sampling FROM SamplingPoints";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            SelectYearCB.DataSource = dataTable;
            SelectYearCB.ValueMember = "Year_sampling";
            SelectYearCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

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

        private void UpdateDataMethod()
        {
            
        }

        private void DeleteDataMethod()
        {
            foreach (DataGridViewRow dataRow in MainDataGridView.SelectedRows)
            {
                MainDataGridView.Rows.Remove(dataRow);
            }
        }

        private void ExportDataExcel()
        {

        }

        #endregion
    }
}

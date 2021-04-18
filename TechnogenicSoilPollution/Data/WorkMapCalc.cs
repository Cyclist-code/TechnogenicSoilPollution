using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Windows.Input;
using TechnogenicSoilPollution.Data;
using TechnogenicSoilPollution.Forms;

namespace TechnogenicSoilPollution.Data
{
    public static class WorkMapCalc
    {
        private static SqlConnection sqlConnection = null;

        static WorkMapCalc()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        #region Загрузка хим. элементов из базы данных
        public static void LoadElementsCB(ComboBox ChemicalElementsCB)
        {
            string selectData = "SELECT Name_element FROM ChemicalElements";
            DataTable dataTable = new DataTable();
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            ChemicalElementsCB.DataSource = dataTable;
            ChemicalElementsCB.ValueMember = "Name_element";
            ChemicalElementsCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Загрузка фаз из базы данных
        public static void LoadPhasesCB(ComboBox PhasesCB)
        {
            string selectData = "SELECT Name_phase FROM Phases";
            DataTable dataTable = new DataTable();
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            PhasesCB.DataSource = dataTable;
            PhasesCB.ValueMember = "Name_phase";
            PhasesCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Загрузка годов из базы данных
        public static void LoadYearsCB(ComboBox YearsCB)
        {
            string selectData = "SELECT DISTINCT Year_sampling FROM SamplingPoints";
            DataTable dataTable = new DataTable();
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            YearsCB.DataSource = dataTable;
            YearsCB.ValueMember = "Year_sampling";
            YearsCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Загрузка номера опорных точек из базы данных
        public static void LoadPivotPoints(CheckedListBox PivotPointsCLB)
        {
            string selectDataCLB = "SELECT Number_point FROM SamplingPoints";
            DataTable dataTable = new DataTable();
            SqlCommand commandSelect = new SqlCommand(selectDataCLB, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);
            PivotPointsCLB.DataSource = dataTable;
            PivotPointsCLB.ValueMember = "Number_point";
        }
        #endregion

        #region Сохранение карты в PNG
        public static void SaveMapPNG(GMapControl Gmap)
        {
            try
            {
                using (SaveFileDialog saveMapDialog = new SaveFileDialog())
                {
                    saveMapDialog.Filter = "PNG (*.png)|*.png";
                    Image imageMap = Gmap.ToImage();

                    if (imageMap != null)
                    {
                        using (imageMap)
                        {
                            if (saveMapDialog.ShowDialog() == DialogResult.OK)
                            {
                                string fileName = saveMapDialog.FileName;
                                imageMap.Save(fileName);
                                MessageBox.Show("Карта сохранена в директории: " + Environment.NewLine + saveMapDialog.FileName,
                                    "Сохранение карты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Выборка изображения розы ветров на основе выбранного года
        public static void ImageRoseWind(ComboBox YearsCB, PictureBox RoseWindPictureBox, Label RoseWindLabel)
        {
            if (YearsCB.SelectedIndex == 0)
            {
                RoseWindPictureBox.Image = Properties.Resources.Rose_Wind_1996;
                RoseWindLabel.Text = "Роза ветров за 1996 год";
            }
            if (YearsCB.SelectedIndex == 1)
            {
                RoseWindPictureBox.Image = Properties.Resources.Rose_Wind_1997;
                RoseWindLabel.Text = "Роза ветров за 1997 год";
            }
        }
        #endregion

    }
}

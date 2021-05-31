﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace TechnogenicSoilPollution.Data
{
    public static class WorkMapCalc
    {
        #region Глобальные переменные
        private static SqlConnection sqlConnection = null;
        #endregion

        static WorkMapCalc()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        #region Настройки карты
        public static void MapSettings(GMapControl Gmap)
        {
            //Угол наклона карты
            Gmap.Bearing = 0;
            //Перетаскивание левой кнопкой мыши
            Gmap.CanDragMap = true;
            //Перетаскивание карты левой кнопкой мыши
            Gmap.DragButton = MouseButtons.Left;

            //Максимальное приближение
            Gmap.MaxZoom = 13;
            //Минимальное приближение
            Gmap.MinZoom = 11;
            //Приближение при загрузке
            Gmap.Zoom = 11;

            //Курсор мыши в центр карты
            Gmap.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            //Скрытие внешней сетки карты
            Gmap.ShowTileGridLines = false;
            //Красный крест по центру
            Gmap.ShowCenter = false;
            //Отключение негативного режима
            Gmap.NegativeMode = false;
            //Разрешение полигонов
            Gmap.PolygonsEnabled = true;
            //Разрешение маршрутов
            Gmap.RoutesEnabled = true;

            //Провайдер для отображения карты
            Gmap.MapProvider = GMapProviders.YandexMap;
            //Загрузка карты через интернет
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //Начальные координаты для загрузки карты
            Gmap.Position = new PointLatLng(52.192972, 104.087009);
        }
        #endregion

        #region Загрузка хим. элементов из базы данных
        public static void LoadElementsCB(ComboBox ChemicalElementsCB)
        {
            sqlConnection.Open();

            string selectData = "SELECT Name_element FROM ChemicalElements";
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataReader reader = commandSelect.ExecuteReader();
            while (reader.Read())
            {
                string subname = reader.GetString(0);
                ChemicalElementsCB.Items.Add(subname);
            }
            ChemicalElementsCB.SelectedIndex = 0;
            ChemicalElementsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            reader.Close();

            sqlConnection.Close();
        }
        #endregion

        #region Загрузка фаз из базы данных
        public static void LoadPhasesCB(ComboBox PhasesCB)
        {
            sqlConnection.Open();

            string selectData = "SELECT Name_phase FROM Phases";
            SqlCommand commandSelect = new SqlCommand(selectData, sqlConnection);
            SqlDataReader reader = commandSelect.ExecuteReader();
            while (reader.Read())
            {
                string subname = reader.GetString(0);
                PhasesCB.Items.Add(subname);
            }
            PhasesCB.SelectedIndex = 0;
            PhasesCB.DropDownStyle = ComboBoxStyle.DropDownList;
            reader.Close();

            sqlConnection.Close();
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

        #region Загрузка опорных точек из базы данных
        public static void LoadPivotPoints(CheckedListBox PivotPointsCLB)
        {
            string selectDataCLB = "SELECT Id_point FROM SamplingPoints";
            DataTable dataTable = new DataTable();
            SqlCommand commandSelect = new SqlCommand();
            commandSelect.Connection = sqlConnection;
            commandSelect.CommandText = selectDataCLB;
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelect);
            adapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                PivotPointsCLB.Items.Add(dataTable.Rows[i]["Id_point"]);
            }
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

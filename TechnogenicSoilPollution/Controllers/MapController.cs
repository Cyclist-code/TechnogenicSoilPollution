using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Collections.Generic;
using TechnogenicSoilPollution.Helpers;
using System.Text;

namespace TechnogenicSoilPollution.Controllers
{
    public static class MapController
    {
        #region Глобальные переменные
        //Координаты ИркАЗ
        static readonly double xPlantLat = 52.191713;
        static readonly double yPlantLng = 104.084576;

        private static SqlConnection sqlConnection = null;
        #endregion

        #region Слои
        static GMapOverlay PointsSamplingOverlay = new GMapOverlay("samplingpoints");
        static GMapOverlay ResultCalcPollutionOverlay = new GMapOverlay("result");
        #endregion

        static MapController()
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
            //Шкала масштабирования
            Gmap.MapScaleInfoEnabled = true;

            //Русская локализация карты
            GMapProvider.Language = LanguageType.Russian;
            //Провайдер для отображения карты
            Gmap.MapProvider = GMapProviders.GoogleMap;
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
            PivotPointsCLB.Items.Clear();
            string selectDataCLB = "SELECT Id_point FROM SamplingPoints";
            SqlCommand sqlCommand = new SqlCommand(selectDataCLB, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                PivotPointsCLB.Items.Add(reader[0]);
            }
            sqlConnection.Close();
        }
        #endregion

        #region Загрзка точек пробоотбора на карту из базы данных

        static List<CoordinatesPoint> ListPoints = new List<CoordinatesPoint>();
        static SqlCommand sqlPointsCommand;

        public static void LoadPointsMap(GMapControl Gmap)
        {
            PointsSamplingOverlay.Clear();
            sqlConnection.Open();

            sqlPointsCommand = new SqlCommand("SELECT * FROM SamplingPoints", sqlConnection);
            SqlDataReader sqlDataReader = sqlPointsCommand.ExecuteReader();

            GMarkerGoogle plantMarker = new GMarkerGoogle(new PointLatLng(52.191713, 104.084576), GMarkerGoogleType.red_small);
            plantMarker.ToolTip = new GMapRoundedToolTip(plantMarker)
            {
                Foreground = new SolidBrush(Color.Black),
                Stroke = new Pen(new SolidBrush(Color.Black)),
                Font = new Font("Arial", 9, FontStyle.Bold)
            };
            plantMarker.ToolTipText = "Алюминиевый Завод";
            PointsSamplingOverlay.Markers.Add(plantMarker);

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    ListPoints.Add(new CoordinatesPoint(Convert.ToInt32(sqlDataReader[2]), Convert.ToDouble(sqlDataReader[4]), Convert.ToDouble(sqlDataReader[5])));
                }
            }
            sqlDataReader.Close();

            for (int i = 0; i < ListPoints.Count; i++)
            {
                GMarkerGoogle samplingMarker = new GMarkerGoogle(new PointLatLng(ListPoints[i].x, ListPoints[i].y), GMarkerGoogleType.black_small);
                samplingMarker.ToolTip = new GMapRoundedToolTip(samplingMarker)
                {
                    Foreground = new SolidBrush(Color.Black),
                    Stroke = new Pen(new SolidBrush(Color.Black)),
                    Font = new Font("Arial", 9, FontStyle.Bold)
                };
                samplingMarker.ToolTipText = "Точка пробоотбора №" + ListPoints[i].numberPoint;
                PointsSamplingOverlay.Markers.Add(samplingMarker);
            }
            sqlConnection.Close();
            Gmap.Overlays.Add(PointsSamplingOverlay);
        }
        #endregion

        #region Переход от декартовых к полярным координатам 
        private static double GetR(double x, double y, double xPlantLat, double yPlantLng) 
            => Math.Sqrt(Math.Pow(x - xPlantLat, 2) + Math.Pow(y - yPlantLng, 2));
        #endregion

        #region Вычисление розы ветров и угла направления ветра
        private static double WindRose(double x, double y, double xPlantLat, double yPlantLng, ComboBox YearsCB)
        {
            //Угол напрваления ветра (1996 и 1997)
            double windAngleOne = Math.Atan((x - xPlantLat) / (y - yPlantLng)) * 180 / Math.PI - 170;
            double windAngleTwo = Math.Atan((x - xPlantLat) / (y - yPlantLng)) * 180 / Math.PI - 90;
            //Роза ветров за 1996 год
            double[] roseOne = { 1, 5, 5, 7, 8, 4, 13, 14 };
            //Роза ветров за 1997 год
            double[] roseTwo = { 1, 5, 3, 17, 7, 9, 18, 5 };

            double windRose = 0;

            if (YearsCB.SelectedIndex == 0)
            {
                if (y - yPlantLng < 0)
                {
                    windAngleOne += 180;
                }
                if (windAngleOne < 0)
                {
                    windAngleOne += 360;
                }
                if (windAngleOne >= 0 && windAngleOne <= 45)
                    windRose = roseOne[3] + (roseOne[4] - roseOne[3]) * windAngleOne / 45;
                else if (windAngleOne >= 45 && windAngleOne <= 90)
                    windRose = roseOne[4] + (roseOne[5] - roseOne[4]) * (windAngleOne - 45) / 45;
                else if (windAngleOne >= 90 && windAngleOne <= 135)
                    windRose = roseOne[5] + (roseOne[6] - roseOne[5]) * (windAngleOne - 90) / 45;
                else if (windAngleOne >= 135 && windAngleOne <= 180)
                    windRose = roseOne[6] + (roseOne[7] - roseOne[6]) * (windAngleOne - 135) / 45;
                else if (windAngleOne >= 180 && windAngleOne <= 225)
                    windRose = roseOne[7] + (roseOne[0] - roseOne[7]) * (windAngleOne - 180) / 45;
                else if (windAngleOne >= 225 && windAngleOne <= 270)
                    windRose = roseOne[0] + (roseOne[1] - roseOne[0]) * (windAngleOne - 225) / 45;
                else if (windAngleOne >= 270 && windAngleOne <= 315)
                    windRose = roseOne[1] + (roseOne[2] - roseOne[1]) * (windAngleOne - 270) / 45;
                else if (windAngleOne >= 315 && windAngleOne <= 360)
                    windRose = roseOne[2] + (roseOne[3] - roseOne[2]) * (windAngleOne - 315) / 45;
            }

            else if (YearsCB.SelectedIndex == 1)
            {
                if (y - yPlantLng <= 0)
                {
                    windAngleTwo += 180;
                }
                if (windAngleTwo < 0)
                {
                    windAngleTwo += 360;
                }
                if (windAngleTwo >= 0 && windAngleTwo <= 45)
                    windRose = roseTwo[5] + (roseTwo[6] - roseTwo[5]) * windAngleTwo / 45;
                else if (windAngleTwo >= 45 && windAngleTwo <= 90)
                    windRose = roseTwo[6] + (roseTwo[7] - roseTwo[6]) * (windAngleTwo - 45) / 45;
                else if (windAngleTwo >= 90 && windAngleTwo <= 135)
                    windRose = roseTwo[7] + (roseTwo[0] - roseTwo[7]) * (windAngleTwo - 90) / 45;
                else if (windAngleTwo >= 135 && windAngleTwo <= 180)
                    windRose = roseTwo[0] + (roseTwo[1] - roseTwo[0]) * (windAngleTwo - 135) / 45;
                else if (windAngleTwo >= 180 && windAngleTwo <= 225)
                    windRose = roseTwo[1] + (roseTwo[2] - roseTwo[1]) * (windAngleTwo - 180) / 45;
                else if (windAngleTwo >= 225 && windAngleTwo <= 270)
                    windRose = roseTwo[2] + (roseTwo[3] - roseTwo[2]) * (windAngleTwo - 225) / 45;
                else if (windAngleTwo >= 270 && windAngleTwo <= 315)
                    windRose = roseTwo[3] + (roseTwo[4] - roseTwo[3]) * (windAngleTwo - 270) / 45;
                else if (windAngleTwo >= 315 && windAngleTwo <= 360)
                    windRose = roseTwo[4] + (roseTwo[5] - roseTwo[4]) * (windAngleTwo - 315) / 45;
            }

            return windRose;
        }
        #endregion

        #region Расчёт загрязнения
        public static void CalculatePollution(ComboBox ChemicalElementsCB, ComboBox PhasesCB, 
            CheckedListBox PivotPointsCLB, ComboBox YearsCB, GMapControl Gmap)
        {
            string chemicalElements = ChemicalElementsCB.SelectedItem.ToString();
            string phase = PhasesCB.SelectedItem.ToString();

            if (PivotPointsCLB.CheckedItems.Count != 0)
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("(");
                for (int i = 0; i < PivotPointsCLB.CheckedItems.Count; i++)
                {
                    builder.Append(PivotPointsCLB.CheckedItems[i].ToString() + ",");
                }
                builder.Remove(builder.Length - 1, 1);
                builder.Append(")");

                double x, y;
                double rezult;
                int counter = 0;

                double[] qt = new double[PivotPointsCLB.CheckedItems.Count];
                double[] windt = new double[PivotPointsCLB.CheckedItems.Count];
                double[] rt = new double[PivotPointsCLB.CheckedItems.Count];

                string selectData = $"SELECT Latitude, Longitude, Content_elements, Stocks_elements " +
                    $"FROM SamplingPoints, ChemicalElements, Phases, ContentElements WHERE SamplingPoints.Id_point IN" + builder
                    + $" AND ContentElements.Id_elements = ChemicalElements.Id_element AND ContentElements.Id_phases = Phases.Id_phase " +
                    $"AND ContentElements.Id_points = SamplingPoints.Id_point " +
                    $"AND ChemicalElements.Name_element='{chemicalElements}' AND Phases.Name_phase = '{phase}'";
                SqlCommand command = new SqlCommand(selectData, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    x = (double)reader["Latitude"];
                    y = (double)reader["Longitude"];
                    try
                    {
                        if (reader["Content_elements"] != DBNull.Value)
                        {
                            rezult = (double)reader["Content_elements"];
                        }
                        else
                        {
                            rezult = (double)reader["Stocks_elements"];
                        }

                        qt[counter] = rezult;
                        windt[counter] = WindRose(x, y, xPlantLat, yPlantLng, YearsCB);
                        rt[counter] = GetR(x, y, xPlantLat, yPlantLng) * 6371;
                        counter++;
                    }
                    catch
                    {
                        MessageBox.Show($"Для элемента {chemicalElements} не проводились измерения в\nданной фазе и выбранных точках пробоотбора." +
                            $"\nОтображение рассчитанного поля является неверным.", "Нет измерений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                sqlConnection.Close();

                double tet1 = 0, tet2 = 0;
                double temp1, temp2;
                double rMax = 5;
                double[] tempQt = new double[PivotPointsCLB.CheckedItems.Count];
                double MNK = double.MaxValue, mnk = 0;

                for (temp1 = 1; temp1 <= 10000; temp1 += 1)
                {
                    for (temp2 = -2; temp2 < 2; temp2 += 0.01)
                    {
                        for (int i = 0; i < PivotPointsCLB.CheckedItems.Count; i++)
                        {
                            tempQt[i] = windt[i] * temp1 * Math.Pow(rt[i], temp2) * Math.Exp(-2 * rMax / rt[i]);
                            mnk += Math.Pow(tempQt[i] - qt[i], 2);
                        }

                        if (mnk < MNK)
                        {
                            MNK = mnk;
                            tet1 = temp1;
                            tet2 = temp2;
                        }

                        mnk = 0;
                    }
                }

                Gmap.Overlays.Clear();
                ResultCalcPollutionOverlay.Clear();
                ResultCalcPollutionOverlay.Markers.Clear();

                for (double i = 52.246740; i > 52.126720; i -= 0.0005)
                {
                    for (double j = 103.992177; j < 104.194542; j += 0.0005)
                    {
                        CalcFieldConcentration(i, j, tet1, tet2, YearsCB);
                    }
                }

                if (Gmap.Overlays.Contains(ResultCalcPollutionOverlay))
                {
                    Gmap.Overlays.Clear();
                }
                Gmap.Overlays.Add(ResultCalcPollutionOverlay);

                LoadPointsMap(Gmap);

                Gmap.Width++;
                Gmap.Width--;
            }
            else
            {
                MessageBox.Show("Выберите опорные точки для расчёта.", "Выбор опорных точек", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion 

        #region Вычисление концентрации примеси в точке с координатами (x,y)
        private static void CalcFieldConcentration(double x, double y, double tet1, double tet2, ComboBox YearsCB)
        {
            double windRose = WindRose(x, y, xPlantLat, yPlantLng, YearsCB);

            //6371 - средний радиус Земли в километрах

            double rMax = 5;
            //Нахождение расстояния r
            double r = MapController.GetR(x, y, xPlantLat, yPlantLng) * 6371;

            //Вычисление концентрации
            double Q = windRose * tet1 * Math.Pow(r, tet2) * Math.Exp(-2 * rMax / r);
            GMapPoint point = new GMapPoint(new PointLatLng(x, y), Q);
            ResultCalcPollutionOverlay.Markers.Add(point);
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

using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using TechnogenicSoilPollution.Data;
using TechnogenicSoilPollution.Forms;
using System.Text;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCMap : UserControl
    {
        #region Слои
        GMapOverlay CustomMarkersOverlay = new GMapOverlay("user");
        GMapOverlay ResultCalcPollutionOverlay = new GMapOverlay("result");
        #endregion

        #region Глобальные переменные
        //Координаты ИркАЗ
        readonly double xPlantLat = 52.191713;
        readonly double yPlantLng = 104.084576;

        //Координаты пользовательского маркера
        double xUserLat = 0;
        double yUserLng = 0;

        private SqlConnection sqlConnection = null;
        #endregion

        public UCMap()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);

            PaintingLegend();
        }

        #region Загрузка пользовательского контрола
        private void UCMap_Load(object sender, EventArgs e)
        {
            WorkMapCalc.LoadElementsCB(ChemicalElementsCB);
            WorkMapCalc.LoadPhasesCB(PhasesCB);
            WorkMapCalc.LoadYearsCB(YearsCB);
            WorkMapCalc.LoadPivotPoints(PivotPointsCLB);

            sqlConnection.Close();
        }
        #endregion

        #region Загрузка карты
        private void Gmap_Load(object sender, EventArgs e)
        {
            WorkMapCalc.MapSettings(Gmap);
            WorkMapCalc.LoadPointsMap(Gmap);
        }
        #endregion

        #region Обработчики событий

        private void ExportMapBtn_Click(object sender, EventArgs e)
        {
            WorkMapCalc.SaveMapPNG(Gmap);
        }

        private void CalcPollutionBtn_Click(object sender, EventArgs e)
        {
            CalculatePollution();
        }

        private void YearsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkMapCalc.ImageRoseWind(YearsCB, RoseWindPictureBox, RoseWindLabel);
        }

        private void PromptFormBtn_Click(object sender, EventArgs e)
        {
            PromptMapForm promptMap = new PromptMapForm();
            promptMap.ShowDialog();
        }

        #endregion

        #region Работа с пользовательским маркером
        //Добавление пользовательского маркера
        private void Gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Gmap.Overlays.Add(CustomMarkersOverlay);

                xUserLat = Gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                yUserLng = Gmap.FromLocalToLatLng(e.X, e.Y).Lng;

                GMarkerGoogle customMarker = new GMarkerGoogle(new PointLatLng(xUserLat, yUserLng), GMarkerGoogleType.blue_small);
                customMarker.ToolTip = new GMapToolTip(customMarker)
                {
                    Foreground = new SolidBrush(Color.Black),
                    Stroke = new Pen(new SolidBrush(Color.Black))
                };
                customMarker.ToolTipText = "Метка пользователя";
                CustomMarkersOverlay.Markers.Add(customMarker);
            }
        }

        //Удаление пользовательского маркера
        private void Gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GMapOverlay mapOverlay = CustomMarkersOverlay;
                mapOverlay.Markers.Remove(item);
            }
        }
        #endregion

        #region Ограничение на выборку опорных точек
        private void PivotPointsCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //PivotPointsCLB.SelectedItem = null; - для убирания синего выделения при нажатии
            if (e.NewValue == CheckState.Checked && PivotPointsCLB.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("2 опорные точки для расчёта уже выбраны.", "Выбор опорных точек", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Методы

        #region Раскраска легенды
        private void PaintingLegend()
        {
            pictureBoxLightGreen.BackColor = Color.FromArgb(140, 0, 255, 0);
            pictureBoxGreen.BackColor = Color.FromArgb(140, 21, 144, 100);
            pictureBoxYellow.BackColor = Color.FromArgb(140, 255, 255, 0);
            pictureBoxOrange.BackColor = Color.FromArgb(140, 255, 128, 0);
            pictureBoxRed.BackColor = Color.FromArgb(140, 255, 0, 0);
        }
        #endregion

        #region Расчёт загрязнения
        private void CalculatePollution()
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

                double x = 0, y = 0;
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
                    if (reader["Content_elements"] != DBNull.Value)
                    {
                        rezult = (double)reader["Content_elements"];
                    }
                    else
                    {
                        rezult = (double)reader["Stocks_elements"];
                    }
                    qt[counter] = rezult;
                    windt[counter] = WindRose(x, y);
                    rt[counter] = GetR(x, y) * 6371;
                    counter++;
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

                for (double i = 52.237935; i > 52.126720; i -= 0.0005)
                {
                    for (double j = 103.995105; j < 104.194542; j += 0.0005)
                    {
                        CalcFieldConcentration(i, j, tet1, tet2);
                    }
                }

                if (Gmap.Overlays.Contains(ResultCalcPollutionOverlay))
                {
                    Gmap.Overlays.Clear();
                }
                Gmap.Overlays.Add(ResultCalcPollutionOverlay);

                WorkMapCalc.LoadPointsMap(Gmap);
            }
            else
            {
                MessageBox.Show("Выберите опорные точки для расчёта.", "Выбор опорных точек", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Переход от декартовых к полярным координатам 
        private double GetR(double x, double y) => Math.Sqrt(Math.Pow(x - xPlantLat, 2) + Math.Pow(y - yPlantLng, 2));
        #endregion

        #region Вычисление розы ветров и угла направления ветра
        private double WindRose(double x, double y)
        {
            //Угол напрваления ветра
            double windAngle = Math.Atan((x - xPlantLat) / (y - yPlantLng)) * 180 / Math.PI + 45;
            //Роза ветров за 1996 год
            double[] roseOne = { 1, 5, 5, 7, 8, 4, 13, 14 };
            //Роза ветров за 1997 год
            double[] roseTwo = { 1, 5, 3, 17, 7, 9, 18, 5 };

            double windRose = 0;

            /*if (windAngle < 0)
                windAngle += 360;
            if (windAngle > 360)
                windAngle -= 360;*/
           

            if (YearsCB.SelectedIndex == 0)
            {
                /*if (windAngle >= 0 && windAngle <= 45)
                    windRose = roseOne[0] + (roseOne[1] - roseOne[2]) * windAngle / 45;
                else if (windAngle >= 45 && windAngle <= 90)
                    windRose = roseOne[1] + (roseOne[2] - roseOne[1]) * (windAngle - 45) / 45;
                else if (windAngle >= 90 && windAngle <= 135)
                    windRose = roseOne[2] + (roseOne[3] - roseOne[2]) * (windAngle - 90) / 45;
                else if (windAngle >= 135 && windAngle <= 180)
                    windRose = roseOne[3] + (roseOne[4] - roseOne[3]) * (windAngle - 135) / 45;
                else if (windAngle >= 180 && windAngle <= 225)
                    windRose = roseOne[4] + (roseOne[5] - roseOne[4]) * (windAngle - 180) / 45;
                else if (windAngle >= 225 && windAngle <= 270)
                    windRose = roseOne[5] + (roseOne[6] - roseOne[5]) * (windAngle - 225) / 45;
                else if (windAngle >= 270 && windAngle <= 315)
                    windRose = roseOne[6] + (roseOne[7] - roseOne[6]) * (windAngle - 270) / 45;
                else if (windAngle >= 315 && windAngle <= 360)
                    windRose = roseOne[7] + (roseOne[0] - roseOne[7]) * (windAngle - 315) / 45;*/
                if (y - yPlantLng < 0)
                {
                    windAngle += 180;
                }
                if (windAngle < 0)
                {
                    windAngle += 360;
                }
                if (windAngle >= 0 && windAngle <= 45)
                    windRose = (roseOne[1] * windAngle + roseOne[0] * (45 - windAngle)) / 45;
                else if (windAngle >= 45 && windAngle <= 90)
                    windRose = (roseOne[2] * (windAngle - 45) + roseOne[1] * (90 - windAngle)) / 45;
                else if (windAngle >= 90 && windAngle <= 135)
                    windRose = (roseOne[3] * (windAngle - 90) + roseOne[2] * (135 - windAngle)) / 45;
                else if (windAngle >= 135 && windAngle <= 180)
                    windRose = (roseOne[4] * (windAngle - 135) + roseOne[3] * (180 - windAngle)) / 45;
                else if (windAngle >= 180 && windAngle <= 225)
                    windRose = (roseOne[5] * (windAngle - 180) + roseOne[4] * (225 - windAngle)) / 45;
                else if (windAngle >= 225 && windAngle <= 270)
                    windRose = (roseOne[6] * (windAngle - 225) + roseOne[5] * (270 - windAngle)) / 45;
                else if (windAngle >= 270 && windAngle <= 315)
                    windRose = (roseOne[7] * (windAngle - 270) + roseOne[6] * (315 - windAngle)) / 45;
                else if (windAngle >= 315 && windAngle <= 360)
                    windRose = (roseOne[0] * (windAngle - 315) + roseOne[7] * (360 - windAngle)) / 45;
            }

            else if (YearsCB.SelectedIndex == 1)
            {
                if (y - yPlantLng <= 0)
                {
                    windAngle += 180;
                }
                if (windAngle < 0)
                {
                    windAngle += 360;
                }
                if (windAngle >= 0 && windAngle <= 45)
                    windRose = roseTwo[2] + (roseTwo[3] - roseTwo[2]) * windAngle / 45;
                else if (windAngle >= 45 && windAngle <= 90)
                    windRose = roseTwo[3] + (roseTwo[4] - roseTwo[3]) * (windAngle - 45) / 45;
                else if (windAngle >= 90 && windAngle <= 135)
                    windRose = roseTwo[4] + (roseTwo[5] - roseTwo[4]) * (windAngle - 90) / 45;
                else if (windAngle >= 135 && windAngle <= 180)
                    windRose = roseTwo[5] + (roseTwo[6] - roseTwo[5]) * (windAngle - 135) / 45;
                else if (windAngle >= 180 && windAngle <= 225)
                    windRose = roseTwo[6] + (roseTwo[7] - roseTwo[6]) * (windAngle - 180) / 45;
                else if (windAngle >= 225 && windAngle <= 270)
                    windRose = roseTwo[7] + (roseTwo[0] - roseTwo[7]) * (windAngle - 225) / 45;
                else if (windAngle >= 270 && windAngle <= 315)
                    windRose = roseTwo[0] + (roseTwo[1] - roseTwo[0]) * (windAngle - 270) / 45;
                else if (windAngle >= 315 && windAngle <= 360)
                    windRose = roseTwo[1] + (roseTwo[2] - roseTwo[1]) * (windAngle - 315) / 45;
            }

            return windRose;
        }
        #endregion

        #region Вычисление концентрации примеси в точке с координатами (x,y)

        private void CalcFieldConcentration(double x, double y, double tet1, double tet2)
        {
            double windRose = WindRose(x, y);

            //6371 - средний радиус Земли в километрах

            double rMax = 5;
            //Нахождение расстояния r
            double r = GetR(x, y) * 6371;

            //Вычисление концентрации
            double Q = windRose * tet1 * Math.Pow(r, tet2) * Math.Exp(-2 * rMax / r);
            GMapPoint point = new GMapPoint(new PointLatLng(x, y), Q);
            ResultCalcPollutionOverlay.Markers.Add(point);
        }
        #endregion

        #endregion       
    }
}

using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using TechnogenicSoilPollution.Controllers;
using TechnogenicSoilPollution.Helpers;
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
        }

        #region Загрузка пользовательского контрола
        private void UCMap_Load(object sender, EventArgs e)
        {
            MapController.LoadElementsCB(ChemicalElementsCB);
            MapController.LoadPhasesCB(PhasesCB);
            MapController.LoadYearsCB(YearsCB);
            MapController.LoadPivotPoints(PivotPointsCLB);

            sqlConnection.Close();
        }
        #endregion

        #region Загрузка карты
        private void Gmap_Load(object sender, EventArgs e)
        {
            MapController.MapSettings(Gmap);
            MapController.LoadPointsMap(Gmap);
        }
        #endregion

        #region Обработчики событий

        private void ExportMapBtn_Click(object sender, EventArgs e)
        {
            MapController.SaveMapPNG(Gmap);
        }

        private void CalcPollutionBtn_Click(object sender, EventArgs e)
        {
            CalculatePollution();
        }

        private void YearsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapController.ImageRoseWind(YearsCB, RoseWindPictureBox, RoseWindLabel);
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
                customMarker.ToolTipText = "Метка пользователя" + " (" + Convert.ToDouble(Math.Round(xUserLat, 6)) + "; " + Convert.ToDouble(Math.Round(yUserLng, 6)) + ")";
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
                        windt[counter] = MapController.WindRose(x, y, xPlantLat, yPlantLng, YearsCB);
                        rt[counter] = MapController.GetR(x, y, xPlantLat, yPlantLng) * 6371;
                        counter++;
                    }
                    catch
                    {
                        MessageBox.Show("Для данного элемента не проводились измерения", "Нет измерений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        CalcFieldConcentration(i, j, tet1, tet2);
                    }
                }
                
                if (Gmap.Overlays.Contains(ResultCalcPollutionOverlay))
                {
                    Gmap.Overlays.Clear();
                }
                Gmap.Overlays.Add(ResultCalcPollutionOverlay);

                MapController.LoadPointsMap(Gmap);

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
        private void CalcFieldConcentration(double x, double y, double tet1, double tet2)
        {
            double windRose = MapController.WindRose(x, y, xPlantLat, yPlantLng, YearsCB);

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

        #endregion       
    }
}

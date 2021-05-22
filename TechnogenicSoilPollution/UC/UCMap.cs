using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using TechnogenicSoilPollution.Data;
using TechnogenicSoilPollution.Forms;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCMap : UserControl
    {
        #region Списки маркеров
        GMapOverlay PointsSamplingOverlay = new GMapOverlay("samplingpoints");
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
            //Угол наклона карты
            Gmap.Bearing = 0;
            //Перетаскивание левой кнопкой мыши
            Gmap.CanDragMap = true;
            //Перетаскивание карты левой кнопкой мыши
            Gmap.DragButton = MouseButtons.Left;

            //Максимальное приближение
            Gmap.MaxZoom = 13;
            //Минимальное приближение
            Gmap.MinZoom = 12;
            //Приближение при загрузке
            Gmap.Zoom = 12;

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

            LoadPoints();
        }
        #endregion

        #region Обработчики событий

        private void ExportMapBtn_Click(object sender, EventArgs e)
        {
            WorkMapCalc.SaveMapPNG(Gmap);
        }

        private void CalcPollutionBtn_Click(object sender, EventArgs e)
        {

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
            if (e.NewValue == CheckState.Checked && PivotPointsCLB.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("2 опорные точки для расчёта уже выбраны.", "Выбор опорных точек", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Методы

        #region Загрзка точек из базы данных

        List<CoordinatesPoint> ListPoints = new List<CoordinatesPoint>();
        SqlCommand sqlPointsCommand;

        private void LoadPoints()
        {
            PointsSamplingOverlay.Clear();
            sqlConnection.Open();

            sqlPointsCommand = new SqlCommand("SELECT * FROM SamplingPoints", sqlConnection);
            SqlDataReader sqlDataReader = sqlPointsCommand.ExecuteReader();

            GMarkerGoogle plantMarker = new GMarkerGoogle(new PointLatLng(xPlantLat, yPlantLng), GMarkerGoogleType.red_small);
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

            Gmap.Overlays.Add(PointsSamplingOverlay);
        }
        #endregion

        #region Расчёт загрязнения
        private void CalculatePollution()
        {
            if (PivotPointsCLB.CheckedItems.Count != 0)
            {

            }
            else
            {
                MessageBox.Show("Выберите опорные точки для расчёта.", "Выбор опорных точек", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Вычисление розы ветров и угла направления ветра
        private double WindRose(double x, double y)
        {
            //Угол напрваления ветра
            double windAngle = 180 / Math.PI * Math.Atan((x - xPlantLat) / (y - yPlantLng));
            //Роза ветров за 1996 год
            double[] roseOne = { 1, 5, 5, 7, 8, 4, 13, 14 };
            //Роза ветров за 1997 год
            double[] roseTwo = { 1, 5, 3, 17, 7, 9, 18, 5 };

            double windRose = 0;

            if (y - yPlantLng <= 0)
                windAngle += 180;
            if (windAngle < 0)
                windAngle += 360;

            if (YearsCB.SelectedIndex == 0)
            {
                if (windAngle >= 0 && windAngle <= 45)
                    windRose = roseOne[0] + (roseOne[1] - roseOne[2]) * windAngle / 45;
                else if (windAngle >= 45 && windAngle <= 90)
                    windRose = roseOne[1] + (roseOne[2] - roseOne[1]) * (windAngle - 45) / 45;
                else if (windAngle >= 90 && windAngle < 135)
                    windRose = roseOne[2] + (roseOne[3] - roseOne[2]) * (windAngle - 90) / 45;
                else if (windAngle >= 135 && windAngle <= 180)
                    windRose = roseOne[3] + (roseOne[4] - roseOne[3]) * (windAngle - 135) / 45;
                else if (windAngle >= 180 && windAngle < 225)
                    windRose = roseOne[4] + (roseOne[5] - roseOne[4]) * (windAngle - 180) / 45;
                else if (windAngle >= 225 && windAngle < 270)
                    windRose = roseOne[5] + (roseOne[6] - roseOne[5]) * (windAngle - 225) / 45;
                else if (windAngle >= 270 && windAngle < 315)
                    windRose = roseOne[6] + (roseOne[7] - roseOne[6]) * (windAngle - 270) / 45;
                else windRose = roseOne[7] + (roseOne[0] - roseOne[7]) * (windAngle - 315) / 45;
            }

            if (YearsCB.SelectedIndex == 1)
            {
                if (windAngle >= 0 && windAngle <= 45)
                    windRose = roseTwo[0] + (roseTwo[1] - roseTwo[2]) * windAngle / 45;
                else if (windAngle >= 45 && windAngle <= 90)
                    windRose = roseTwo[1] + (roseTwo[2] - roseTwo[1]) * (windAngle - 45) / 45;
                else if (windAngle >= 90 && windAngle < 135)
                    windRose = roseTwo[2] + (roseTwo[3] - roseTwo[2]) * (windAngle - 90) / 45;
                else if (windAngle >= 135 && windAngle <= 180)
                    windRose = roseTwo[3] + (roseTwo[4] - roseTwo[3]) * (windAngle - 135) / 45;
                else if (windAngle >= 180 && windAngle < 225)
                    windRose = roseTwo[4] + (roseTwo[5] - roseTwo[4]) * (windAngle - 180) / 45;
                else if (windAngle >= 225 && windAngle < 270)
                    windRose = roseTwo[5] + (roseTwo[6] - roseTwo[5]) * (windAngle - 225) / 45;
                else if (windAngle >= 270 && windAngle < 315)
                    windRose = roseTwo[6] + (roseTwo[7] - roseTwo[6]) * (windAngle - 270) / 45;
                else windRose = roseTwo[7] + (roseTwo[0] - roseTwo[7]) * (windAngle - 315) / 45;
            }

            return windRose;
        }
        #endregion

        #region Вычисление концентрации примеси в точке с координатами (x,y)
        private void CalcFieldConcentration(double x, double y, double tet1, double tet2)
        {
            double windRose = WindRose(x, y);

            //константа (км) определяется высотой источника (её оценка составляет 15-20 высот источника)
            double rMax = 5;

            //Нахождение расстояния r
            double r = Math.Sqrt((x * x - 2 * x * xPlantLat + xPlantLat * xPlantLat) + (y * y - 2 * y * yPlantLng + yPlantLng * yPlantLng));

            //Вычисление концентрации
            double Q = windRose * tet1 * Math.Pow(r, tet2) * Math.Exp(-2 * rMax / r);
        }
        #endregion

        #endregion       
    }
}

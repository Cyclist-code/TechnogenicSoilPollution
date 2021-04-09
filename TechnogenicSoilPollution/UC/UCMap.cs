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

namespace TechnogenicSoilPollution.UC
{
    public partial class UCMap : UserControl
    {
        #region Списки маркеров
        GMapOverlay PointsSampling = new GMapOverlay("markers");
        GMapOverlay CustomMarkers = new GMapOverlay("user");
        #endregion

        private SqlConnection sqlConnection = null;

        public UCMap()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        #region Загрузка пользовательского контрола
        private void UCMap_Load(object sender, EventArgs e)
        {
            LoadElementsCB();
            LoadPhasesCB();
            LoadYearsCB();
            LoadPivotPoints();

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

        #region Обработчики кнопок

        private void ExportMapBtn_Click(object sender, EventArgs e)
        {
            SaveMapPNG();
        }

        private void CalcPollutionBtn_Click(object sender, EventArgs e)
        {

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
            if (e.Button == MouseButtons.Middle)
            {
                Gmap.Overlays.Add(CustomMarkers);

                double userLat = Gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double userLng = Gmap.FromLocalToLatLng(e.X, e.Y).Lng;

                GMarkerGoogle customMarker = new GMarkerGoogle(new PointLatLng(userLat, userLng), GMarkerGoogleType.blue_small);
                customMarker.ToolTip = new GMapToolTip(customMarker);
                customMarker.ToolTipText = "Метка пользователя";
                CustomMarkers.Markers.Add(customMarker);
            }
        }

        //Удаление пользовательского маркера
        private void Gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GMapOverlay mapOverlay = CustomMarkers;
                mapOverlay.Markers.Remove(item);
            }
        }
        #endregion

        #region Методы

        //Загрузка хим. элементов из базы данных
        private void LoadElementsCB()
        {
            string dataFillingComboBox = "SELECT Name_element FROM ChemicalElements";
            DataTable dataTable = new DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            ChemicalElementsCB.DataSource = dataTable;
            ChemicalElementsCB.ValueMember = "Name_element";
            ChemicalElementsCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Загрузка фаз из базы данных
        private void LoadPhasesCB()
        {
            string dataFillingComboBox = "SELECT Name_phase FROM Phases";
            DataTable dataTable = new DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            PhasesCB.DataSource = dataTable;
            PhasesCB.ValueMember = "Name_phase";
            PhasesCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Загрузка годов из базы данных
        private void LoadYearsCB()
        {
            string dataFillingComboBox = "SELECT DISTINCT Year_sampling FROM SamplingPoints";
            DataTable dataTable = new DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            YearsCB.DataSource = dataTable;
            YearsCB.ValueMember = "Year_sampling";
            YearsCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Загрузка номера опорных точек из базы данных
        private void LoadPivotPoints()
        {
            string dataFillingComboBox = "SELECT Number_point FROM SamplingPoints";
            DataTable dataTable = new DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            PivotPointsCLB.DataSource = dataTable;
            PivotPointsCLB.ValueMember = "Number_point";
        }

        List<CoordinatesPoint> ListPoints = new List<CoordinatesPoint>();
        SqlCommand sqlPointsCommand;

        //Загрзка точек из базы данных
        private void LoadPoints()
        {
            PointsSampling.Clear();
            sqlConnection.Open();

            sqlPointsCommand = new SqlCommand("SELECT * FROM SamplingPoints", sqlConnection);
            SqlDataReader sqlDataReader = sqlPointsCommand.ExecuteReader();

            GMarkerGoogle plantMarker = new GMarkerGoogle(new PointLatLng(52.191713, 104.084576), GMarkerGoogleType.red_small);
            plantMarker.ToolTip = new GMapRoundedToolTip(plantMarker);
            plantMarker.ToolTipText = "Алюминиевый Завод";
            PointsSampling.Markers.Add(plantMarker);

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    ListPoints.Add(new CoordinatesPoint(Convert.ToDouble(sqlDataReader[4]), Convert.ToDouble(sqlDataReader[5])));
                }
            }
            sqlDataReader.Close();

            for(int i = 0; i < ListPoints.Count; i++)
            {
                GMarkerGoogle samplingMarker = new GMarkerGoogle(new PointLatLng(ListPoints[i].x, ListPoints[i].y), GMarkerGoogleType.black_small);
                samplingMarker.ToolTip = new GMapRoundedToolTip(samplingMarker);
                samplingMarker.ToolTipText = "Точка пробоотбора";
                PointsSampling.Markers.Add(samplingMarker);
            }

            Gmap.Overlays.Add(PointsSampling);
        }

        //Сохранение карты в PNG
        private void SaveMapPNG()
        {
            try
            {
                using(SaveFileDialog saveMapDialog = new SaveFileDialog())
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

        #region Выборка розы ветров на основе выбранного года
        private void YearsCB_SelectedIndexChanged(object sender, EventArgs e)
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

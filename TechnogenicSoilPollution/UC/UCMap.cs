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
using TechnogenicSoilPollution.CPoint;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCMap : UserControl
    {
        // Список маркеров
        GMapOverlay pointsOverlay = new GMapOverlay("markers");      

        private SqlConnection sqlConnection = null;

        public UCMap()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ImpurityEmissionDB"].ConnectionString);
        }

        private void UCMap_Load(object sender, EventArgs e)
        {
            //sqlConnection.Open();
            LoadElementsCB();
            LoadPhasesCB();
            LoadYearsCB();

            sqlConnection.Close();
        }

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

        private void ExportMapBtn_Click(object sender, EventArgs e)
        {
            SaveMapPNG();
        }

        private void CalcPollutionBtn_Click(object sender, EventArgs e)
        {

        }

        #region Методы

        //Загрузка хим. элементов из базы данных
        private void LoadElementsCB()
        {
            string dataFillingComboBox = "SELECT Name_element FROM ChemicalElements";
            System.Data.DataTable dataTable = new System.Data.DataTable();
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
            System.Data.DataTable dataTable = new System.Data.DataTable();
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
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlCommand commandFilling = new SqlCommand(dataFillingComboBox, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandFilling);
            adapter.Fill(dataTable);
            YearsCB.DataSource = dataTable;
            YearsCB.ValueMember = "Year_sampling";
            YearsCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        List<CoordinatesPoint> ListPoints = new List<CoordinatesPoint>();
        SqlCommand sqlPointsCommand;

        //Загрзка точек из базы данных
        private void LoadPoints()
        {
            pointsOverlay.Clear();
            sqlConnection.Open();

            sqlPointsCommand = new SqlCommand("SELECT * FROM SamplingPoints", sqlConnection);
            SqlDataReader sqlDataReader = sqlPointsCommand.ExecuteReader();

            GMarkerGoogle plantMarker = new GMarkerGoogle(new PointLatLng(52.191713, 104.084576), GMarkerGoogleType.red_small);
            plantMarker.ToolTip = new GMapRoundedToolTip(plantMarker);
            plantMarker.ToolTipText = "Алюминиевый Завод";
            pointsOverlay.Markers.Add(plantMarker);

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
                pointsOverlay.Markers.Add(samplingMarker);
            }

            Gmap.Overlays.Add(pointsOverlay);
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

        
    }
}

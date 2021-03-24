using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace TechnogenicSoilPollution.UC
{
    public partial class UCMap : UserControl
    {
        // Список маркеров
        GMapOverlay pointsOverlay = new GMapOverlay("markers");

        public UCMap()
        {
            InitializeComponent();
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

        private void LoadPoints()
        {
            GMarkerGoogle plantMarker = new GMarkerGoogle(new PointLatLng(52.191713, 104.084576), GMarkerGoogleType.red_small);
            plantMarker.ToolTipText = "Алюминиевый Завод";
            pointsOverlay.Markers.Add(plantMarker);
            Gmap.Overlays.Add(pointsOverlay);
        }

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

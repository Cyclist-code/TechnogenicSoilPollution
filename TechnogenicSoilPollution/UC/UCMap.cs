using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using TechnogenicSoilPollution.Controllers;
using TechnogenicSoilPollution.Forms;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCMap : UserControl
    {
        #region Слои
        GMapOverlay CustomMarkersOverlay = new GMapOverlay("user");
        #endregion

        #region Глобальные переменные
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
            MapController.CalculatePollution(ChemicalElementsCB, PhasesCB, PivotPointsCLB, YearsCB, Gmap);
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
            if (e.NewValue == CheckState.Checked && PivotPointsCLB.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("2 опорные точки для расчёта уже выбраны.", "Выбор опорных точек", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}

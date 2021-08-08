using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using TechnogenicSoilPollution.UC;
using TechnogenicSoilPollution.Forms;
using TechnogenicSoilPollution.Helpers;

namespace TechnogenicSoilPollution
{
    public partial class MainForm : MaterialForm
    {
        #region UserControls
        private UCHome HomePage = new UCHome();
        private UCData DataPage = new UCData();
        private UCMap MapPage = new UCMap();
        #endregion

        #region Глобальные переменные
        int openForm = 0;
        ReferenceProgramForm programForm;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            // Дефолтная тема
            FormSettings.InstallingAppTheme(this, HomePage, DarkThemeCheckBox);

            PanelLoadUserControl.Controls.Add(HomePage);
        }

        #region Открытие окна со справкой
        private void BtnOpenHelp_Click(object sender, EventArgs e)
        {                       
            foreach(Form form in Application.OpenForms)
            {
                if (form.Name == "ReferenceProgramForm")
                    openForm = 1;
                else openForm = 0;
            }

            if (openForm == 0)
            {
                programForm = new ReferenceProgramForm();
                programForm.Show();
            }
        }
        #endregion

        #region Переходы между UserControl
        private void OpenPageBtn(object sender, EventArgs e)
        {
            Button button = sender as Button;
            PanelLoadUserControl.Controls.Clear();

            if (button != null)
            {
                switch (button.Name)
                {
                    case "BtnOpenHome":
                        HomePage.Dock = DockStyle.Fill;
                        PanelLoadUserControl.Controls.Add(HomePage);
                        break;
                    case "BtnOpenData":
                        DataPage.Dock = DockStyle.Fill;
                        PanelLoadUserControl.Controls.Add(DataPage);
                        break;
                    case "BtnOpenMap":
                        MapPage.Dock = DockStyle.Fill;
                        PanelLoadUserControl.Controls.Add(MapPage);
                        break;
                    default:
                        PanelLoadUserControl.Controls.Clear();
                        break;
                }
            }
        }
        #endregion

        #region Подтверждение закрытия приложения
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход из приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        #endregion

        #region Выбор темы оформления приложения
        private void DarkThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FormSettings.ChoosingTheme(HomePage, DarkThemeCheckBox);
        }
        #endregion
    }
}

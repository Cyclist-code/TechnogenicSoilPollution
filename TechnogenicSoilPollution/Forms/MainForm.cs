using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using TechnogenicSoilPollution.UC;
using TechnogenicSoilPollution.Forms;

namespace TechnogenicSoilPollution
{
    public partial class MainForm : MaterialForm
    {
        #region UserControls
        private UCHome HomePage = new UCHome();
        private UCData DataPage = new UCData();
        private UCMap MapPage = new UCMap();
        #endregion

        public MainForm()
        {
            InitializeComponent();

            #region Дефолтная тема
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            string theme = Properties.Settings.Default.DarkTheme;

            if((theme == "") || (theme == " ") || (theme == "0"))
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
            if (theme == "1")
            {
                DarkThemeCheckBox.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
            }
            #endregion

            PanelLoadUserControl.Controls.Add(HomePage);
        }

        #region Открытие окна со справкой
        private void BtnOpenHelp_Click(object sender, EventArgs e)
        {
            ReferenceProgramForm programForm = new ReferenceProgramForm();
            programForm.ShowDialog();
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
            if (DarkThemeCheckBox.Checked)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                Properties.Settings.Default.DarkTheme = "1";
                Properties.Settings.Default.Save();
            }
            if (!DarkThemeCheckBox.Checked)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                Properties.Settings.Default.DarkTheme = "0";
                Properties.Settings.Default.Save();
            }
        }
        #endregion

    }
}

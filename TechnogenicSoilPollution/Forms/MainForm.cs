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

        private UCHome HomePage = new UCHome();
        private UCData DataPage = new UCData();
        private UCMap MapPage = new UCMap();

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            PanelLoadUserControl.Controls.Add(HomePage);
        }

        private void BtnOpenHelp_Click(object sender, EventArgs e)
        {
            ReferenceProgramForm programForm = new ReferenceProgramForm();
            programForm.ShowDialog();
        }

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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйди из приложения?", "Выход", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else 
                e.Cancel = true;
        }
    }
}

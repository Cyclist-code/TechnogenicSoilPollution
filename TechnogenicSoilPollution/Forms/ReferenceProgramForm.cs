using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TechnogenicSoilPollution.Forms
{
    public partial class ReferenceProgramForm : MaterialForm
    {
        public ReferenceProgramForm()
        {
            InitializeComponent();

            #region Дизайн окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            linkLabelGitHub.LinkClicked += LinkLabelGitHub_LinkClicked;
        }

        #region Переход в профиль разработчика на GitHub
        private void LinkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Cyclist-code/TechnogenicSoilPollution");
        }
        #endregion

        #region Закрытие окна
        private void CloseFormBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion
    }
}

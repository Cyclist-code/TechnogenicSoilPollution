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
            #endregion
        }

        #region Методы действий при нажатии на кнопки
        private void FeedbackAndDocButtons(object sender, System.EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "GitHubProfileButton":
                        Process.Start("https://github.com/Cyclist-code/TechnogenicSoilPollution");
                        break;
                    case "CopyEmailButton":
                        Clipboard.SetText("cyclistcode@gmail.com");
                        break;
                    case "DocWebsiteButton":
                        Process.Start("https://cyclistcode.gitbook.io/technogenic-soil-pollution/");
                        break;
                }
            }
        }
        #endregion
    }
}

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

        #region Переход в профиль разработчика на GitHub
        private void GitHubProfileButton_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/Cyclist-code/TechnogenicSoilPollution");
        }
        #endregion

        #region Копирование электронной почты
        private void CopyEmailButton_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText("cyclistcode@gmail.com");
        }
        #endregion

        #region Закрытие окна
        private void CloseFormButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion       
    }
}

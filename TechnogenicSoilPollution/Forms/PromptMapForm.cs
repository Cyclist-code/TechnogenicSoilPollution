using MaterialSkin;
using MaterialSkin.Controls;

namespace TechnogenicSoilPollution.Forms
{
    public partial class PromptMapForm : MaterialForm
    {
        public PromptMapForm()
        {
            InitializeComponent();

            #region Установка стиля окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);           
            #endregion
        }

        #region Закрытие окна
        private void CloseFormBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion
    }
}

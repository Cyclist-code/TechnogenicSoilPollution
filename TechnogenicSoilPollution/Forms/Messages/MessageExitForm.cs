using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TechnogenicSoilPollution.Forms.Messages
{
    public partial class MessageExitForm : MaterialForm
    {
        public MessageExitForm()
        {
            InitializeComponent();

            #region Установка стиля окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            #endregion
        }

        #region Выход из приложения
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        #endregion

        #region Отмена выхода из приложения
        private void CancelExitAppButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}

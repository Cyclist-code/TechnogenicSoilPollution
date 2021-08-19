using MaterialSkin;
using MaterialSkin.Controls;

namespace TechnogenicSoilPollution.Forms.Messages
{
    public enum IconMessageForm
    {
        Error,
        Info,
        Question,
        Warning
    }

    public partial class MessageForm : MaterialForm
    {
        public MessageForm(string message, IconMessageForm icon)
        {
            InitializeComponent();

            #region Установка стиля окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            #endregion

            #region Установка текста сообщения и иконки

            MessageLabel.Text = message;

            switch (icon)
            {
                case IconMessageForm.Error:
                    IconPictureBox.Image = Properties.Resources.Error;
                    break;
                case IconMessageForm.Info:
                    IconPictureBox.Image = Properties.Resources.Info;
                    break;
                case IconMessageForm.Question:
                    IconPictureBox.Image = Properties.Resources.Question;
                    break;
                case IconMessageForm.Warning:
                    IconPictureBox.Image = Properties.Resources.Warning;
                    break;
                default:
                    break;
            }
            #endregion
        }

        #region Закрытие окна сообщения
        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion
    }
}

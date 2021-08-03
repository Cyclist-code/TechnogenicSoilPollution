using System.Drawing;
using System.Windows.Forms;

namespace TechnogenicSoilPollution.UC
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        #region Свойство для установки цвета текста у заголовка
        public Color ForeColorLabel
        {
            get { return TitleAppLabel.ForeColor; }
            set { TitleAppLabel.ForeColor = value; }
        }
        #endregion
    }
}

using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using TechnogenicSoilPollution.UC;

namespace TechnogenicSoilPollution.Helpers
{
    public static class FormSettings
    {
        #region Дефолтная тема
        public static void InstallingAppTheme(MaterialForm materialForm, UCHome home, MaterialCheckBox materialCheckBox)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(materialForm);
            string theme = Properties.Settings.Default.DarkTheme;

            if ((theme == "") || (theme == " ") || (theme == "0"))
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                home.ForeColorLabel = Color.Black;
            }
            if (theme == "1")
            {
                materialCheckBox.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                home.ForeColorLabel = Color.White;
            }
        }
        #endregion
    }
}

using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
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
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
                home.ForeColorLabel = Color.Black;
            }
            if (theme == "1")
            {
                materialCheckBox.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
                home.ForeColorLabel = Color.White;
            }
        }
        #endregion

        #region Выбор темы оформления
        public static void ChoosingTheme(UCHome home, MaterialCheckBox materialCheckBox)
        {
            if (materialCheckBox.Checked)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;               
                home.ForeColorLabel = Color.White;
                Properties.Settings.Default.DarkTheme = "1";
                Properties.Settings.Default.Save();
            }
            if (!materialCheckBox.Checked)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;               
                home.ForeColorLabel = Color.Black;
                Properties.Settings.Default.DarkTheme = "0";
                Properties.Settings.Default.Save();
            }
        }
        #endregion
    }
}

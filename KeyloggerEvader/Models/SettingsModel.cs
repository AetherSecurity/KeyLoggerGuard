using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace KeyloggerEvader.Models
{
    public class SettingsModel
    {
        #region "Properties"
        public bool TabMenuUseColors { get; set; } = true;

        public bool TabMenuHighlightWithAccent { get; set; } = true;

        public bool TabMenuBackgroundWithAccent { get; set; } = true;

        public bool TabMenuDisplayIconsWhenHidden { get; set; } = true;

        public bool TabMenuAutoShow { get; set; } = true;

        public MaterialSkinManager.Themes ThemeOption { get; set; } = MaterialSkinManager.Themes.DARK;

        public MaterialForm.FormStyles FormStyle { get; set; } = MaterialForm.FormStyles.ActionBar_64;

        public Primary Primary { get; set; } = Primary.BlueGrey800;

        public Primary DarkPrimary { get; set; } = Primary.BlueGrey900;

        public Primary LightPrimary { get; set; } = Primary.BlueGrey500;

        public Accent Accent { get; set; } = Accent.LightBlue200;

        public TextShade TextShading { get; set; } = TextShade.WHITE;

        public bool AutoStartup { get; set; } = false;

        public bool HistoryLogging { get; set; } = true;
        #endregion

        public SettingsModel()
        {
            if (IsUserSettingsAvailable() == false)
            {
                SaveSettings();
            }
        }

        #region "Static Methods"
        public void SaveSettings()
        {
            DeleteSavedSettings();
            string JsonContent = JsonConvert.SerializeObject(this);
            using (FileStream FS = new FileStream("./Settings.json", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamWriter SW = new StreamWriter(FS))
                {
                    SW.Write(JsonContent);
                }
            }
        }

        public void DeleteSavedSettings()
        {
            if (File.Exists("./Settings.json"))
            {
                File.Delete("./Settings.json");
            }
        }

        public static bool IsUserSettingsAvailable()
        {
            try
            {
                return File.Exists("./Settings.json");
            }
            catch
            {
                return false;
            }
        }

        public static SettingsModel GetUserSettings()
        {
            if (IsUserSettingsAvailable())
            {
                SettingsModel UserSettings = null;
                using (FileStream FS = new FileStream("./Settings.json", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader SR = new StreamReader(FS))
                    {
                        UserSettings = JsonConvert.DeserializeObject<SettingsModel>(SR.ReadToEnd());
                    }
                }
                return UserSettings;
            }
            else
            {
                return new SettingsModel();
            }
        }
        #endregion
    }
}
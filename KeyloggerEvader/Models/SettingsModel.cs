using System.IO;
using KeyloggerEvader.Helpers;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace KeyloggerEvader.Models
{
    public class SettingsModel
    {
        #region "Fields"
        private static readonly string filePath = FileHelper.GetBaseDirectoryPath() + "//Settings.json";
        #endregion

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

        #region "Constructors / Destructor"
        public SettingsModel()
        {
            if (IsUserSettingsAvailable() == false)
            {
                SaveSettings();
            }
        }
        #endregion

        #region "Save / Delete Settings"
        public void SaveSettings()
        {
            DeleteSavedSettings();
            string JsonContent = JsonConvert.SerializeObject(this);
            using (FileStream FS = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter SW = new StreamWriter(FS))
                {
                    SW.Write(JsonContent);
                }
            }
        }

        public void DeleteSavedSettings()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        #endregion

        #region "Static Methods"
        public static bool IsUserSettingsAvailable()
        {
            try
            {
                return File.Exists(filePath);
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
                using (FileStream FS = new FileStream(filePath, FileMode.Open, FileAccess.Read))
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
                //If we came here, this means we will initialize the SettingsModel to call the constructor
                //and the constructor will create a default settings that is called Settings.json.
                return new SettingsModel();
            }
        }
        #endregion
    }
}
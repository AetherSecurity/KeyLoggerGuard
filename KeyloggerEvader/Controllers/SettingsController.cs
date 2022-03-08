using System;
using MaterialSkin;
using MaterialSkin.Controls;
using KeyloggerEvader.Views;
using Microsoft.Win32;
using System.Windows.Forms;
using KeyloggerEvader.Helpers;
using System.Diagnostics;

namespace KeyloggerEvader.Controllers
{
    public class SettingsController
    {
        #region "Fields"
        private readonly SettingsView settingsView;
        #endregion

        #region "Constructors / Destructor"
        public SettingsController(SettingsView settingsView)
        {
            this.settingsView = settingsView;
        }

        ~SettingsController()
        {
        }
        #endregion

        #region "Public Methods"
        public void SetStartup(bool setToStartup)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            try
            {
                if (setToStartup == true)
                {
                    registryKey.SetValue(FileHelper.GetFileNameWithoutPath(Application.ExecutablePath, false), Application.ExecutablePath);
                    Debug.WriteLine("Key Added");
                }
                else
                {
                    registryKey.DeleteValue(FileHelper.GetFileNameWithoutPath(Application.ExecutablePath, false), false);
                    Debug.WriteLine("Key Deleted");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("SetStartup Exception: " + ex.Message);
            }
        }

        public void LoadData()
        {
            GetData();
            SetSelectedDataField();
        }

        private void GetData()
        {
            //Theming And Styling
            settingsView.ThemeComboBox.DataSource = Enum.GetValues(typeof(MaterialSkinManager.Themes));
            settingsView.FormStyleComboBox.DataSource = Enum.GetValues(typeof(MaterialForm.FormStyles));

            //Color Scheme
            settingsView.PrimaryComboBox.DataSource = Enum.GetValues(typeof(Primary));
            settingsView.DarkPrimaryComboBox.DataSource = Enum.GetValues(typeof(Primary));
            settingsView.LightPrimaryComboBox.DataSource = Enum.GetValues(typeof(Primary));
            settingsView.AccentComboBox.DataSource = Enum.GetValues(typeof(Accent));
            settingsView.TextShadingComboBox.DataSource = Enum.GetValues(typeof(TextShade));
        }

        private void SetSelectedDataField()
        {
            //Tab Menu
            settingsView.UseColorsSwitch.Checked = App.Instance.Settings.TabMenuUseColors;
            settingsView.HighlightAccentSwitch.Checked = App.Instance.Settings.TabMenuHighlightWithAccent;
            settingsView.BackgroundAccentSwitch.Checked = App.Instance.Settings.TabMenuBackgroundWithAccent;
            settingsView.DisplayIconsSwitch.Checked = App.Instance.Settings.TabMenuDisplayIconsWhenHidden;
            settingsView.AutoShowSwitch.Checked = App.Instance.Settings.TabMenuAutoShow;

            //Theming And Styling
            settingsView.ThemeComboBox.SelectedItem = App.Instance.Settings.ThemeOption;
            settingsView.FormStyleComboBox.SelectedItem = App.Instance.Settings.FormStyle;

            //Color Scheme
            settingsView.PrimaryComboBox.SelectedItem = App.Instance.Settings.Primary;
            settingsView.DarkPrimaryComboBox.SelectedItem = App.Instance.Settings.DarkPrimary;
            settingsView.LightPrimaryComboBox.SelectedItem = App.Instance.Settings.LightPrimary;
            settingsView.AccentComboBox.SelectedItem = App.Instance.Settings.Accent;
            settingsView.TextShadingComboBox.SelectedItem = App.Instance.Settings.TextShading;

            //Application
            settingsView.AddStartupCheckBox.Checked = App.Instance.Settings.AutoStartup;
            settingsView.EnableHistoryCheckBox.Checked = App.Instance.Settings.HistoryLogging;
        }

        public void SaveThemeSettings()
        {
            //Tab Menu
            App.Instance.Settings.TabMenuUseColors = settingsView.UseColorsSwitch.Checked;
            App.Instance.Settings.TabMenuHighlightWithAccent = settingsView.HighlightAccentSwitch.Checked;
            App.Instance.Settings.TabMenuBackgroundWithAccent = settingsView.BackgroundAccentSwitch.Checked;
            App.Instance.Settings.TabMenuDisplayIconsWhenHidden = settingsView.DisplayIconsSwitch.Checked;
            App.Instance.Settings.TabMenuAutoShow = settingsView.AutoShowSwitch.Checked;

            //Theming And Styling
            App.Instance.Settings.ThemeOption = (MaterialSkinManager.Themes)settingsView.ThemeComboBox.SelectedItem;
            App.Instance.Settings.FormStyle = (MaterialForm.FormStyles)settingsView.FormStyleComboBox.SelectedItem;

            //Color Scheme
            App.Instance.Settings.Primary = (Primary)settingsView.PrimaryComboBox.SelectedItem;
            App.Instance.Settings.DarkPrimary = (Primary)settingsView.DarkPrimaryComboBox.SelectedItem;
            App.Instance.Settings.LightPrimary = (Primary)settingsView.LightPrimaryComboBox.SelectedItem;
            App.Instance.Settings.Accent = (Accent)settingsView.AccentComboBox.SelectedItem;
            App.Instance.Settings.TextShading = (TextShade)settingsView.TextShadingComboBox.SelectedItem;

            //Apply Settings
            App.Instance.ConfigureSkinManager();

            //Save
            App.Instance.Settings.SaveSettings();
        }

        public void SaveApplicationSettings()
        {
            //Application
            App.Instance.Settings.AutoStartup = settingsView.AddStartupCheckBox.Checked;
            App.Instance.Settings.HistoryLogging = settingsView.EnableHistoryCheckBox.Checked;

            //Save
            App.Instance.Settings.SaveSettings();
        }
        #endregion
    }
}
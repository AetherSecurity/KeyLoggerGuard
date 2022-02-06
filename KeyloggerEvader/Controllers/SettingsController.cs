using System;
using MaterialSkin;
using MaterialSkin.Controls;
using KeyloggerEvader.Views;

namespace KeyloggerEvader.Controllers
{
    public class SettingsController
    {
        #region "Fields"
        private readonly SettingsView SettingsView; //NULL.
        #endregion

        public SettingsController(SettingsView SV)
        {
            SettingsView = SV;
        }

        #region "Data Management"
        public void LoadData()
        {
            GetData();
            SetSelectedDataField();
        }

        private void GetData()
        {
            //Theming And Styling
            SettingsView.ThemeComboBox.DataSource = Enum.GetValues(typeof(MaterialSkinManager.Themes));
            SettingsView.FormStyleComboBox.DataSource = Enum.GetValues(typeof(MaterialForm.FormStyles));

            //Color Scheme
            SettingsView.PrimaryComboBox.DataSource = Enum.GetValues(typeof(Primary));
            SettingsView.DarkPrimaryComboBox.DataSource = Enum.GetValues(typeof(Primary));
            SettingsView.LightPrimaryComboBox.DataSource = Enum.GetValues(typeof(Primary));
            SettingsView.AccentComboBox.DataSource = Enum.GetValues(typeof(Accent));
            SettingsView.TextShadingComboBox.DataSource = Enum.GetValues(typeof(TextShade));
        }

        private void SetSelectedDataField()
        {
            //Tab Menu
            SettingsView.UseColorsSwitch.Checked = App.Instance.Settings.TabMenuUseColors;
            SettingsView.HighlightAccentSwitch.Checked = App.Instance.Settings.TabMenuHighlightWithAccent;
            SettingsView.BackgroundAccentSwitch.Checked = App.Instance.Settings.TabMenuBackgroundWithAccent;
            SettingsView.DisplayIconsSwitch.Checked = App.Instance.Settings.TabMenuDisplayIconsWhenHidden;
            SettingsView.AutoShowSwitch.Checked = App.Instance.Settings.TabMenuAutoShow;

            //Theming And Styling
            SettingsView.ThemeComboBox.SelectedItem = App.Instance.Settings.ThemeOption;
            SettingsView.FormStyleComboBox.SelectedItem = App.Instance.Settings.FormStyle;

            //Color Scheme
            SettingsView.PrimaryComboBox.SelectedItem = App.Instance.Settings.Primary;
            SettingsView.DarkPrimaryComboBox.SelectedItem = App.Instance.Settings.DarkPrimary;
            SettingsView.LightPrimaryComboBox.SelectedItem = App.Instance.Settings.LightPrimary;
            SettingsView.AccentComboBox.SelectedItem = App.Instance.Settings.Accent;
            SettingsView.TextShadingComboBox.SelectedItem = App.Instance.Settings.TextShading;

            //Application
            SettingsView.AddStartupCheckBox.Checked = App.Instance.Settings.AutoStartup;
            SettingsView.EnableHistoryCheckBox.Checked = App.Instance.Settings.HistoryLogging;
        }
        #endregion

        #region "Save Data"
        public void SaveThemeSettings()
        {
            //Tab Menu
            App.Instance.Settings.TabMenuUseColors = SettingsView.UseColorsSwitch.Checked;
            App.Instance.Settings.TabMenuHighlightWithAccent = SettingsView.HighlightAccentSwitch.Checked;
            App.Instance.Settings.TabMenuBackgroundWithAccent = SettingsView.BackgroundAccentSwitch.Checked;
            App.Instance.Settings.TabMenuDisplayIconsWhenHidden = SettingsView.DisplayIconsSwitch.Checked;
            App.Instance.Settings.TabMenuAutoShow = SettingsView.AutoShowSwitch.Checked;

            //Theming And Styling
            App.Instance.Settings.ThemeOption = (MaterialSkinManager.Themes)SettingsView.ThemeComboBox.SelectedItem;
            App.Instance.Settings.FormStyle = (MaterialForm.FormStyles)SettingsView.FormStyleComboBox.SelectedItem;

            //Color Scheme
            App.Instance.Settings.Primary = (Primary)SettingsView.PrimaryComboBox.SelectedItem;
            App.Instance.Settings.DarkPrimary = (Primary)SettingsView.DarkPrimaryComboBox.SelectedItem;
            App.Instance.Settings.LightPrimary = (Primary)SettingsView.LightPrimaryComboBox.SelectedItem;
            App.Instance.Settings.Accent = (Accent)SettingsView.AccentComboBox.SelectedItem;
            App.Instance.Settings.TextShading = (TextShade)SettingsView.TextShadingComboBox.SelectedItem;

            //Apply Settings
            App.Instance.ConfigureSkinManager();

            //Save
            App.Instance.Settings.SaveSettings();
        }

        public void SaveApplicationSettings()
        {
            //Application
            App.Instance.Settings.AutoStartup = SettingsView.AddStartupCheckBox.Checked;
            App.Instance.Settings.HistoryLogging = SettingsView.EnableHistoryCheckBox.Checked;

            //Save
            App.Instance.Settings.SaveSettings();
        }
        #endregion
    }
}
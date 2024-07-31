using System;
using System.Windows.Forms;

namespace SearchTracker
{
    /// <summary>
    /// Fenster zur Verwaltung der Theme-Einstellungen.
    /// </summary>
    public partial class ThemeManageWindow : Form
    {
        public ThemeManageWindow()
        {
            Logger.Log("Initializing ThemeManageWindow.");
            InitializeComponent();
            InitializeThemeOptions();
        }

        /// <summary>
        /// Initialisiert die Optionen für das Theme-Wechseln in der ComboBox.
        /// </summary>
        private void InitializeThemeOptions()
        {
            Logger.Log("Initializing theme options in ComboBox.");
            cbBoxThemeChange.Items.AddRange(ThemeManager.GetAvailableThemes());
            cbBoxThemeChange.SelectedItem = ThemeManager.GetCurrentTheme();
            cbBoxThemeChange.SelectedIndexChanged += CbBoxThemeChange_SelectedIndexChanged;
        }

        /// <summary>
        /// Ereignishandler für das Ändern der Theme-Auswahl.
        /// </summary>
        private void CbBoxThemeChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTheme = cbBoxThemeChange.SelectedItem.ToString();
            Logger.Log($"\tTheme selected: {selectedTheme}");
            ThemeManager.ApplyTheme(selectedTheme);
        }
    }
}

using System;
using System.Windows.Forms;

namespace SearchTracker
{
    /// <summary>
    /// Hauptfenster der Anwendung, das die Benutzeroberfläche darstellt.
    /// </summary>
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Logger.Log("Initializing MainWindow.");
            InitializeComponent();
            ApplySelectedTheme();
        }

        /// <summary>
        /// Wendet das aktuell ausgewählte Theme an.
        /// </summary>
        private void ApplySelectedTheme()
        {
            string selectedTheme = ThemeManager.GetCurrentTheme();
            ThemeManager.ApplyTheme(selectedTheme);
            Logger.Log($"\tTheme applied: {selectedTheme}");
        }

        /// <summary>
        /// Öffnet das Fenster zur Theme-Auswahl.
        /// </summary>
        private void UIChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Log("Opening ThemeManageWindow.");
            ThemeManageWindow themeWindow = new ThemeManageWindow();
            themeWindow.ShowDialog();
            ApplySelectedTheme();
        }
    }
}

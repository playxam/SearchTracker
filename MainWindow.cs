using System;
using System.IO;
using System.Windows.Forms;

namespace SearchTracker
{
    /// <summary>
    /// Hauptfenster der Anwendung, das die Benutzeroberfläche darstellt.
    /// </summary>
    public partial class MainWindow : Form
    {
        private FileSystemWatcher watcher;
        private FileMonitorViewModel fileMonitorViewModel;

        /// <summary>
        /// Initialisiert eine neue Instanz des <see cref="MainWindow"/>-Klasse.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Logger.StartSession(); // Session-Start für das Logging
            Logger.Log("MainWindow initialized.");
            ApplySelectedTheme();
            LoadLastDirectory(); // Lädt den zuletzt verwendeten Pfad
            fileMonitorViewModel = new FileMonitorViewModel();
            DataBindings.Add("Text", fileMonitorViewModel, "DirectoryPath");
        }

        /// <summary>
        /// Lädt das zuletzt verwendete Verzeichnis aus den Anwendungseinstellungen.
        /// </summary>
        private void LoadLastDirectory()
        {
            string lastDirectory = Properties.Settings.Default.LastDirectory;
            if (!string.IsNullOrEmpty(lastDirectory) && Directory.Exists(lastDirectory))
            {
                txtDir.Text = lastDirectory;
                Logger.Log($"Loaded last directory: {lastDirectory}");
            }
        }

        /// <summary>
        /// Öffnet den Dialog zur Auswahl eines Verzeichnisses.
        /// </summary>
        private void btnDir_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Folder Selection.";

                // Wenn der Benutzer ein Verzeichnis auswählt und auf "OK" klickt
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Holen Sie den Pfad des ausgewählten Verzeichnisses
                    string folderPath = Path.GetDirectoryName(openFileDialog.FileName);
                    txtDir.Text = folderPath;
                    fileMonitorViewModel.DirectoryPath = folderPath;
                    Logger.Log($"Directory selected: {folderPath} by btnDir_Click event.");

                    // Speichern des ausgewählten Verzeichnisses in den Anwendungseinstellungen
                    Properties.Settings.Default.LastDirectory = folderPath;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Logger.Log("Directory selection canceled by btnDir_Click event");
                }
            }
        }

        /// <summary>
        /// Wendet das aktuell ausgewählte Theme an.
        /// </summary>
        private void ApplySelectedTheme()
        {
            string selectedTheme = ThemeManager.GetCurrentTheme();
            ThemeManager.ApplyTheme(selectedTheme);
            Logger.Log($"Theme applied: {selectedTheme}");
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

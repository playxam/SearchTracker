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
        private FileMonitorViewModel fileMonitorViewModel;

        public MainWindow()
        {
            InitializeComponent();
            Logger.StartSession();
            Logger.Log("MainWindow initialized.");

            fileMonitorViewModel = new FileMonitorViewModel();
            fileMonitorViewModel.OnDirectoryChanged += UpdateDirectoryChangeUI;
            InitializeFileMonitoring();

            // ListView initialisieren
            //UIHandling.InitializeListView(lvDir);
        }

        /// <summary>
        /// Initialisiert die Verzeichnisüberwachung.
        /// </summary>
        private void InitializeFileMonitoring()
        {
            txtDir.Text = Properties.Settings.Default.LastDirectory;
            fileMonitorViewModel.StartMonitoring(txtDir.Text);
        }


        /// <summary>
        /// Event-Handler für den Button-Klick, um ein Verzeichnis auszuwählen.
        /// Öffnet einen Ordnerauswahldialog, speichert den ausgewählten Pfad und lädt die Dateien in die ListView.
        /// </summary>
        /// <param name="sender">Das auslösende Objekt.</param>
        /// <param name="e">Ereignisdaten.</param>        
        private void btnDir_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.ValidateNames = false;
                    openFileDialog.CheckFileExists = false;
                    openFileDialog.CheckPathExists = true;
                    openFileDialog.FileName = "Folder Selection.";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = Path.GetDirectoryName(openFileDialog.FileName);
                        txtDir.Text = selectedPath;
                        Properties.Settings.Default.LastDirectory = selectedPath;
                        Properties.Settings.Default.Save();
                        Logger.Log($"Selected directory: {selectedPath}");
                        UIHandling.LoadDirectoryContents(selectedPath, lvDir); // Verweis auf lvDir
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Fehler beim Auswählen des Verzeichnisses: {ex.Message}");
                MessageBox.Show("Ein Fehler ist beim Auswählen des Verzeichnisses aufgetreten. Bitte versuchen Sie es erneut.");
            }
        }




        /// <summary>
        /// Speichert das ausgewählte Verzeichnis in einer neuen Textdatei.
        /// </summary>
        /// <param name="path">Der Pfad des ausgewählten Verzeichnisses.</param>
        private void SaveSelectedDirectory(string path)
        {
            string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Directory");
            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }

            string logFilePath = Path.Combine(dataDir, $"SelectedDirectory_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

            using (StreamWriter writer = new StreamWriter(logFilePath, false))
            {
                writer.WriteLine($"Selected directory: {path}");
                writer.WriteLine($"Timestamp: {DateTime.Now}");
            }

            Logger.Log($"Directory path saved to: {logFilePath}");
        }

        /// <summary>
        /// Aktualisiert die Benutzeroberfläche, um Änderungen im überwachten Verzeichnis anzuzeigen.
        /// </summary>
        /// <param name="message">Die Nachricht, die die Änderung beschreibt.</param>
        private void UpdateDirectoryChangeUI(string message)
        {
            UIHandling.UpdateLabel(lblBlinkedDirNews, "Verzeichnisinhalt wurde geändert!");
            UIHandling.UpdateTextBox(txtDirInfo, message);
        }

        /// <summary>
        /// Öffnet das Fenster zur Änderung des UI-Themes.
        /// </summary>
        private void UIChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Log("Opening ThemeManageWindow.");
            ThemeManageWindow themeWindow = new ThemeManageWindow();
            themeWindow.ShowDialog();
            ApplySelectedTheme();
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
    }
}

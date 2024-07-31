using System;
using System.IO;
using System.Windows.Forms;

namespace SearchTracker
{
    /// <summary>
    /// ViewModel zur Überwachung eines Verzeichnisses auf Dateiänderungen.
    /// </summary>
    public class FileMonitorViewModel
    {
        private FileSystemWatcher fileSystemWatcher;
        private string directoryPath;
        private string sessionLogFilePath;

        /// <summary>
        /// Ereignis, das ausgelöst wird, wenn eine Änderung im Verzeichnis erkannt wird.
        /// </summary>
        public event Action<string> OnDirectoryChanged;

        public FileMonitorViewModel()
        {
            fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.Created += OnCreated;
            fileSystemWatcher.Deleted += OnDeleted;
            StartNewSessionLog();
        }

        /// <summary>
        /// Startet die Überwachung des angegebenen Verzeichnisses.
        /// </summary>
        /// <param name="path">Der Pfad des zu überwachenden Verzeichnisses.</param>
        public void StartMonitoring(string path)
        {
            // Überprüfen, ob der Pfad nicht leer ist und das Verzeichnis existiert
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
            {
                Logger.Log($"Error: The directory '{path}' does not exist or cannot be accessed.");
                MessageBox.Show($"Das Verzeichnis '{path}' existiert nicht oder kann nicht zugegriffen werden. Bitte überprüfen Sie den Pfad.");
                throw new DirectoryNotFoundException($"The directory '{path}' does not exist or cannot be accessed.");
            }

            directoryPath = path;
            fileSystemWatcher.Path = path;
            fileSystemWatcher.EnableRaisingEvents = true;
            Logger.Log($"Started monitoring directory: {path}");
        }


        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            LogDirectoryChange("Added", e.Name);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            LogDirectoryChange("Removed", e.Name);
        }

        /// <summary>
        /// Protokolliert eine Änderung im überwachten Verzeichnis und benachrichtigt die Benutzeroberfläche.
        /// </summary>
        /// <param name="changeType">Typ der Änderung (z.B. "Added", "Removed").</param>
        /// <param name="documentName">Name des geänderten Dokuments.</param>
        private void LogDirectoryChange(string changeType, string documentName)
        {
            string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Directory");
            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }

            string changeIndicator = changeType == "Added" ? "+++++" : "------";
            string message = $"{changeIndicator} {documentName} {changeType} on {DateTime.Now}";

            using (StreamWriter writer = new StreamWriter(sessionLogFilePath, true))
            {
                writer.WriteLine(message);
            }

            Logger.Log(message);

            OnDirectoryChanged?.Invoke(message);
        }

        /// <summary>
        /// Startet eine neue Log-Datei für die aktuelle Sitzung.
        /// </summary>
        private void StartNewSessionLog()
        {
            string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Directory");
            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }

            sessionLogFilePath = Path.Combine(dataDir, $"SessionLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

            using (StreamWriter writer = new StreamWriter(sessionLogFilePath, false))
            {
                writer.WriteLine($"Session Start: {DateTime.Now}");
            }

            Logger.Log($"New session log started: {sessionLogFilePath}");
        }
    }
}

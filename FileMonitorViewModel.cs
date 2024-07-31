using System.IO;
using System.ComponentModel;
using System;

namespace SearchTracker
{
    /// <summary>
    /// ViewModel zur Verwaltung der Interaktionen zwischen View und Model.
    /// </summary>
    public class FileMonitorViewModel : INotifyPropertyChanged
    {
        private FileSystemWatcher watcher;
        private FileMonitorModel model;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="FileMonitorViewModel"/>-Klasse.
        /// </summary>
        public FileMonitorViewModel()
        {
            model = new FileMonitorModel();
        }

        /// <summary>
        /// Der Pfad des zu überwachenden Verzeichnisses.
        /// </summary>
        public string DirectoryPath
        {
            get { return model.DirectoryPath; }
            set
            {
                if (model.DirectoryPath != value)
                {
                    model.DirectoryPath = value;
                    InitializeWatcher(model.DirectoryPath);
                    OnPropertyChanged("DirectoryPath");
                }
            }
        }

        /// <summary>
        /// Ereignis, das ausgelöst wird, wenn sich eine Eigenschaft ändert.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Methode, die das <see cref="PropertyChanged"/>-Ereignis auslöst.
        /// </summary>
        /// <param name="name">Der Name der geänderten Eigenschaft.</param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Initialisiert den FileSystemWatcher für das ausgewählte Verzeichnis.
        /// </summary>
        /// <param name="directoryPath">Der Pfad des zu überwachenden Verzeichnisses.</param>
        private void InitializeWatcher(string directoryPath)
        {
            if (watcher != null)
            {
                watcher.Dispose();
            }

            watcher = new FileSystemWatcher
            {
                Path = directoryPath,
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite,
                Filter = "*.*"
            };

            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.EnableRaisingEvents = true;

            Logger.Log($"Started watching directory: {directoryPath}");
        }

        /// <summary>
        /// Ereignishandler für das Erstellen von Dateien.
        /// </summary>
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (IsMonitoredFileType(e.FullPath))
            {
                Logger.Log($"File created: {e.FullPath}");
                // Aktualisierung der View entsprechend der Anforderungen
            }
        }

        /// <summary>
        /// Ereignishandler für das Löschen von Dateien.
        /// </summary>
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            if (IsMonitoredFileType(e.FullPath))
            {
                Logger.Log($"File deleted: {e.FullPath}");
                // Aktualisierung der View entsprechend der Anforderungen
            }
        }

        /// <summary>
        /// Überprüft, ob der Dateityp überwacht wird.
        /// </summary>
        /// <param name="filePath">Der Dateipfad.</param>
        /// <returns>Gibt <c>true</c> zurück, wenn der Dateityp überwacht wird, andernfalls <c>false</c>.</returns>
        private bool IsMonitoredFileType(string filePath)
        {
            string[] monitoredExtensions = { ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".pdf", ".txt", ".csv", ".xml" };
            string fileExtension = Path.GetExtension(filePath).ToLower();
            return Array.Exists(monitoredExtensions, ext => ext == fileExtension);
        }
    }
}

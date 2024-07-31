using System.ComponentModel;

namespace SearchTracker
{
    /// <summary>
    /// Model zur Verwaltung der Dateiüberwachungsinformationen.
    /// </summary>
    public class FileMonitorModel : INotifyPropertyChanged
    {
        private string directoryPath;

        /// <summary>
        /// Der Pfad des zu überwachenden Verzeichnisses.
        /// </summary>
        public string DirectoryPath
        {
            get { return directoryPath; }
            set
            {
                if (directoryPath != value)
                {
                    directoryPath = value;
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
    }
}

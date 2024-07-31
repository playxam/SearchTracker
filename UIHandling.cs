using System;
using System.Windows.Forms;

namespace SearchTracker
{
    /// <summary>
    /// Klasse zur Handhabung von UI-bezogenen Aufgaben.
    /// </summary>
    public class UIHandling
    {
        private MainWindow mainWindow;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="UIHandling"/>-Klasse.
        /// </summary>
        /// <param name="mainWindow">Das Hauptfenster der Anwendung.</param>
        public UIHandling(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        /// <summary>
        /// Aktualisiert die UI bei Änderungen im Verzeichnis.
        /// </summary>
        /// <param name="message">Die Nachricht, die angezeigt werden soll.</param>
        public void UpdateDirectoryInfo(string message)
        {
            mainWindow.txtDirInfo.Visible = true;
            mainWindow.txtDirInfo.Text += message + Environment.NewLine;
            mainWindow.lblBlinkedDirNews.Text = "Verzeichnisinhalt wurde geändert!";
            mainWindow.lblBlinkedDirNews.Visible = true;
            BlinkLabel();
        }

        /// <summary>
        /// Lässt das Label lblBlinkedDirNews blinken.
        /// </summary>
        private void BlinkLabel()
        {
            // Implementiere die Logik, um das Blinken des Labels zu ermöglichen
        }
    }
}

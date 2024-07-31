using System;
using System.Windows.Forms;

namespace SearchTracker
{
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Starte die Log-Session
            Logger.StartSession();
            Logger.Log("Application started.");

            Application.Run(new MainWindow());

            // Beende die Log-Session
            Logger.EndSession();
        }
    }
}

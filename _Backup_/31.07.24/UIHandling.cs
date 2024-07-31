using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace SearchTracker
{
    /// <summary>
    /// Klasse zur Verwaltung der Benutzeroberfläche.
    /// </summary>
    public static class UIHandling
    {
        private static System.Timers.Timer blinkTimer;
        private static bool blinkState;
        private static int blinkDuration = 8000; // 8 Sekunden

        /// <summary>
        /// Aktualisiert ein Label mit dem angegebenen Text, setzt es auf fett und startet einen Blink-Effekt.
        /// </summary>
        /// <param name="label">Das zu aktualisierende Label.</param>
        /// <param name="text">Der anzuzeigende Text.</param>
        public static void UpdateLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new MethodInvoker(() => UpdateLabel(label, text)));
            }
            else
            {
                label.Text = text;
                label.Visible = true;
                label.Font = new Font(label.Font, FontStyle.Bold);
                StartBlinking(label);
            }
        }

        /// <summary>
        /// Startet den Blink-Effekt für ein Label.
        /// </summary>
        /// <param name="label">Das zu blinkende Label.</param>
        private static void StartBlinking(Label label)
        {
            blinkTimer = new System.Timers.Timer(500); // 500 ms Intervall für das Blinken
            blinkTimer.Elapsed += (sender, e) => ToggleLabelVisibility(label);
            blinkTimer.Start();

            System.Timers.Timer stopTimer = new System.Timers.Timer(blinkDuration); // Timer zum Stoppen des Blinkens
            stopTimer.Elapsed += (sender, e) => StopBlinking(label);
            stopTimer.AutoReset = false;
            stopTimer.Start();
        }

        /// <summary>
        /// Wechselt die Sichtbarkeit eines Labels, um den Blink-Effekt zu erzeugen.
        /// </summary>
        /// <param name="label">Das Label, dessen Sichtbarkeit gewechselt wird.</param>
        private static void ToggleLabelVisibility(Label label)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new MethodInvoker(() => ToggleLabelVisibility(label)));
            }
            else
            {
                label.Visible = !blinkState;
                blinkState = !blinkState;
            }
        }

        /// <summary>
        /// Stoppt den Blink-Effekt und blendet das Label aus.
        /// </summary>
        /// <param name="label">Das Label, das gestoppt werden soll.</param>
        private static void StopBlinking(Label label)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new MethodInvoker(() => StopBlinking(label)));
            }
            else
            {
                blinkTimer.Stop();
                label.Visible = false;
            }
        }

        /// <summary>
        /// Aktualisiert eine TextBox mit dem angegebenen Text.
        /// </summary>
        /// <param name="textBox">Die zu aktualisierende TextBox.</param>
        /// <param name="text">Der anzuzeigende Text.</param>
        public static void UpdateTextBox(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new MethodInvoker(() => UpdateTextBox(textBox, text)));
            }
            else
            {
                textBox.Text = text;
                textBox.Visible = true;

                System.Timers.Timer hideTimer = new System.Timers.Timer(blinkDuration);
                hideTimer.Elapsed += (sender, e) => HideTextBox(textBox);
                hideTimer.AutoReset = false;
                hideTimer.Start();
            }
        }

        /// <summary>
        /// Blendet die TextBox aus.
        /// </summary>
        /// <param name="textBox">Die TextBox, die ausgeblendet werden soll.</param>
        private static void HideTextBox(TextBox textBox)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new MethodInvoker(() => HideTextBox(textBox)));
            }
            else
            {
                textBox.Visible = false;
            }
        }
    }
}

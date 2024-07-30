using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Statische Klasse, die für das Management der Anwendungsthemen verantwortlich ist.
/// </summary>
public static class ThemeManager
{
    private static string currentTheme = "Hell";

    /// <summary>
    /// Wendet das ausgewählte Thema auf alle offenen Formulare an.
    /// </summary>
    /// <param name="themeName">Der Name des zu verwendenden Themas ("Hell", "Dunkel").</param>
    public static void ApplyTheme(string themeName)
    {
        Logger.Log($"Applying theme: {themeName}");

        if (string.IsNullOrEmpty(themeName))
        {
            Logger.Log("Error: Theme name cannot be null or empty.");
            throw new ArgumentException("Theme name cannot be null or empty.");
        }

        currentTheme = themeName;

        foreach (Form form in Application.OpenForms)
        {
            if (themeName == "Hell")
            {
                form.BackColor = SystemColors.Control;
                SetControlForeColor(form, SystemColors.ControlText); // Standard-Schriftfarbe
                Logger.Log($"\tLight theme applied to form: {form.Name}");
            }
            else if (themeName == "Dunkel")
            {
                form.BackColor = SystemColors.ControlDarkDark;
                SetControlForeColor(form, Color.White); // Weiße Schriftfarbe für dunkles Theme
                Logger.Log($"\tDark theme applied to form: {form.Name}");
            }
            form.Invalidate();
            form.Update();
        }
    }

    /// <summary>
    /// Rekursive Methode zum Setzen der Schriftfarbe aller Steuerelemente in einer Form.
    /// </summary>
    /// <param name="control">Das Steuerelement, dessen Schriftfarbe gesetzt werden soll.</param>
    /// <param name="color">Die zu setzende Schriftfarbe.</param>
    private static void SetControlForeColor(Control control, Color color)
    {
        foreach (Control subControl in control.Controls)
        {
            if (subControl is TextBox || subControl is Label || subControl is Button || subControl is CheckBox || subControl is RadioButton)
            {
                subControl.ForeColor = color;
            }
            if (subControl.HasChildren)
            {
                SetControlForeColor(subControl, color);
            }
        }
    }

    /// <summary>
    /// Gibt die verfügbaren Themen als String-Array zurück.
    /// </summary>
    /// <returns>Ein Array mit den Namen der verfügbaren Themen.</returns>
    public static string[] GetAvailableThemes()
    {
        Logger.Log("Fetching available themes.");
        return new string[] { "Hell", "Dunkel" };
    }

    /// <summary>
    /// Gibt das aktuelle Thema zurück.
    /// </summary>
    /// <returns>Der Name des aktuellen Themas als String.</returns>
    public static string GetCurrentTheme()
    {
        Logger.Log("Fetching current theme.");
        return currentTheme;
    }
}

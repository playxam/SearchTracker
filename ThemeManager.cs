using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Statische Klasse, die für das Management der Anwendungsthemen verantwortlich ist.
/// </summary>
public static class ThemeManager
{
    private static string currentTheme = "Standard";

    /// <summary>
    /// Wendet das ausgewählte Thema auf alle offenen Formulare an.
    /// </summary>
    /// <param name="themeName">Der Name des zu verwendenden Themas ("Standard", "Dunkel", "Weiß", "Grau").</param>
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
            switch (themeName)
            {
                case "Standard":
                    ApplyStandardTheme(form);
                    break;
                case "Dunkel":
                    ApplyDarkTheme(form);
                    break;
                case "Weiß":
                    ApplyWhiteTheme(form);
                    break;
                case "Grau":
                    ApplyGrayTheme(form);
                    break;
                default:
                    Logger.Log($"Unknown theme: {themeName}");
                    throw new ArgumentException($"Unknown theme: {themeName}");
            }

            form.Invalidate();
            form.Update();
        }
    }

    private static void ApplyStandardTheme(Form form)
    {
        form.BackColor = SystemColors.Control;
        SetControlColors(form, SystemColors.ControlText, SystemColors.Control);
        Logger.Log($"\tStandard theme applied to form: {form.Name}");
    }

    private static void ApplyDarkTheme(Form form)
    {
        form.BackColor = Color.FromArgb(45, 45, 48);
        SetControlColors(form, Color.White, Color.FromArgb(30, 30, 30));
        Logger.Log($"\tDark theme applied to form: {form.Name}");
    }

    private static void ApplyWhiteTheme(Form form)
    {
        form.BackColor = Color.WhiteSmoke;
        SetControlColors(form, Color.Black, Color.WhiteSmoke);
        Logger.Log($"\tWhite theme applied to form: {form.Name}");
    }

    private static void ApplyGrayTheme(Form form)
    {
        form.BackColor = Color.Gray;
        SetControlColors(form, Color.Black, Color.LightGray);
        Logger.Log($"\tGray theme applied to form: {form.Name}");
    }

    private static void SetControlColors(Control control, Color foreColor, Color backColor)
    {
        foreach (Control subControl in control.Controls)
        {
            if (subControl is TextBox || subControl is ComboBox || subControl is ListBox || subControl is Label || subControl is CheckBox || subControl is RadioButton)
            {
                subControl.ForeColor = foreColor;
                subControl.BackColor = backColor;
            }
            else if (subControl is Button)
            {
                subControl.BackColor = foreColor;
                subControl.ForeColor = backColor;
            }
            if (subControl.HasChildren)
            {
                SetControlColors(subControl, foreColor, backColor);
            }
        }
    }

    public static string[] GetAvailableThemes()
    {
        Logger.Log("Fetching available themes.");
        return new string[] { "Standard", "Dunkel", "Weiß", "Grau" };
    }

    public static string GetCurrentTheme()
    {
        Logger.Log("Fetching current theme.");
        return currentTheme;
    }
}

using System;
using System.IO;

/// <summary>
/// Logger-Klasse zum Protokollieren von Debug- und Log-Nachrichten.
/// </summary>
public static class Logger
{
    private static string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
   // private static string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "Debug");


    private static string logFilePath;

    /// <summary>
    /// Startet eine neue Logging-Session.
    /// </summary>
    public static void StartSession()
    {
        if (!Directory.Exists(logDirectory))
        {
            Directory.CreateDirectory(logDirectory);
        }

        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        logFilePath = Path.Combine(logDirectory, $"Debug_{timestamp}.log");

        using (StreamWriter writer = new StreamWriter(logFilePath, false))
        {
            writer.WriteLine($"Session Start: {DateTime.Now}");
        }

        Log("Logging session started.");
    }

    /// <summary>
    /// Protokolliert eine Nachricht in der aktuellen Log-Datei.
    /// </summary>
    /// <param name="message">Die zu protokollierende Nachricht.</param>
    public static void Log(string message)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    /// <summary>
    /// Beendet die aktuelle Logging-Session.
    /// </summary>
    public static void EndSession()
    {
        Log("Logging session ended.");

        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"Session End: {DateTime.Now}");
        }
    }
}

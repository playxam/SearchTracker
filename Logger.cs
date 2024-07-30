using System;
using System.IO;

/// <summary>
/// Logger ist verantwortlich für das Protokollieren von Debug-Nachrichten.
/// </summary>
public static class Logger
{
    private static string logDirectory = "SearchTracker";
    private static string logFilePath;

    /// <summary>
    /// Startet eine neue Logging-Session. Erstellt eine neue Log-Datei.
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
        if (string.IsNullOrEmpty(logFilePath))
        {
            throw new InvalidOperationException("Log session not started.");
        }

        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    /// <summary>
    /// Beendet die aktuelle Logging-Session und protokolliert das Ende.
    /// </summary>
    public static void EndSession()
    {
        if (string.IsNullOrEmpty(logFilePath))
        {
            throw new InvalidOperationException("Log session not started.");
        }

        Log("Logging session ended.");

        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"Session End: {DateTime.Now}");
        }
    }
}

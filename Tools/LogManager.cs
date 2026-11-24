using System.IO;

using System.Globalization;


namespace Tools;

public static class LogManager
{
    private const string LogSuffix = ".log";

    // בונה את הנתיב המלא: .../Logs/yyyy-MM-dd.log
    private static string BuildLogPath()
    {
        string folder = Path.Combine(AppContext.BaseDirectory, "Logs");
        Directory.CreateDirectory(folder);

        string fileName = $"{DateTime.Now:yyyy-MM-dd}{LogSuffix}";
        return Path.Combine(folder, fileName);
    }

    public static void WritingToLog(string projectName, string funcName, string message)
    {
        string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{projectName}.{funcName}:\t{message}"
                      + Environment.NewLine;

        File.AppendAllText(BuildLogPath(), line);
    }


    public static void CleanOldLogs()
    {
        string root = Path.Combine(AppContext.BaseDirectory, "Logs");
        if (!Directory.Exists(root))
        {
            return;
        }
        DateTime threshold = DateTime.Now.AddMonths(-2);
        foreach (string dir in Directory.GetDirectories(root))
        {
            DateTime dirDate;
            if (!DateTime.TryParseExact(Path.GetFileName(dir), "yyyy-MM-dd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out dirDate))
            {
                dirDate = Directory.GetLastWriteTime(dir);
            }

            if (dirDate >= threshold)
            {
                continue;
            }

            try
            {
                Directory.Delete(dir, recursive: true);
            }

            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                Console.WriteLine($"לא ניתן למחוק{dir}: {ex.Message}");
            }

        }

        foreach (string file in Directory.GetFiles(root, "*.log"))
        {
            if (File.GetLastWriteTime(file) < threshold)
            {
                try { File.Delete(file); }
                catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
                {
                    Console.WriteLine($"לא ניתן למחוק{file}: {ex.Message}");
                }


            }
        }


    }


}

using System.Collections.Concurrent;
using System.Text;

public static class TestLogger
{
    private static readonly ConcurrentDictionary<string, StringBuilder> _testLogs =
        new ConcurrentDictionary<string, StringBuilder>();

    private static readonly object fileLock = new object();
    private static string reportPath;

    public static void Init(string reportDirectory)
    {
        Directory.CreateDirectory(reportDirectory);
        reportPath = Path.Combine(
            reportDirectory,
            $"TestReport_{DateTime.Now:dd_MM_yyyy_HH_mm_ss}.log"
        );
    }

    public static void Log(string message)
    {
        var testName = TestContext.CurrentContext.Test.Name;

        var log = _testLogs.GetOrAdd(testName, _ => new StringBuilder());
        log.AppendLine($"[{DateTime.Now:HH:mm:ss}] {message}");

        TestContext.WriteLine(message);
    }

    public static void FlushReport()
    {
        lock (fileLock)
        {
            using var writer = new StreamWriter(reportPath, false, Encoding.UTF8);

            writer.WriteLine("=== TEST REPORT ===");
            writer.WriteLine($"Generated: {DateTime.Now}");
            writer.WriteLine();

            foreach (var test in _testLogs)
            {
                writer.WriteLine($"--- {test.Key} ---");
                writer.WriteLine(test.Value.ToString());
                writer.WriteLine();
            }
        }
    }
}

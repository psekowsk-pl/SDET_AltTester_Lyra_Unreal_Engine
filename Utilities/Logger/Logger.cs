public static class Logger
{
    public static void Pass(string message)
    {
        TestLogger.Log($"[PASS] {message}");    
    }

    public static void Info(string message)
    {
        TestLogger.Log($"[INFO] {message}");
    }

    public static void Warning(string message)
    {
        TestLogger.Log($"[WARN] {message}");
    }

    public static void Error(string message)
    {
        TestLogger.Log($"[ERROR] {message}");
    }

    public static void TestFailed()
    {
        TestLogger.Log(@"/// TEST FAILED \\\");
    }

    public static void TestPassed()
    {
        TestLogger.Log(@"/// TEST PASSED \\\");
    }
}

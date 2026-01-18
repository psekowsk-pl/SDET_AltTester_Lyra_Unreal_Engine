[SetUpFixture]
public class TestSetupFixture
{
    [OneTimeSetUp]
    public void GlobalSetup()
    {
        TestLogger.Init(Path.Combine(FilePath.GetBaseProjectPath(), "TestReports"));
        AltDriverManager.Start();
    }

    [OneTimeTearDown]
    public void GlobalTearDown()
    {
        TestLogger.FlushReport();
        AltDriverManager.Stop();
    }
}
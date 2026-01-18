using AltTester.AltTesterSDK.Driver;

public class BaseTest
{
    protected AltDriver Driver;

    [SetUp]
    public void SetUp()
    {
        Driver = AltDriverManager.Driver;
    }

    [TearDown]
    public void AfterEachTest()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Logger.Error(TestContext.CurrentContext.Result.Message!);
            Logger.Error(TestContext.CurrentContext.Result.StackTrace!);
            Logger.TestFailed();
        }
        else
        {
            Logger.TestPassed();
        }
    }
}

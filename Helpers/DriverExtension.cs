using AltTester.AltTesterSDK.Driver;

namespace Helper.DriverExtension;

public static class DriverExtension
{
    public static AltObject GetElementByPath(this AltDriver driver, string value) => driver.WaitForObject(By.PATH, value, timeout: 10);

    public static void DoubleCheckClick(this AltDriver driver, string objPathToClick, string objPathToSeen)
    {
        bool objClicked = false;
        int retries = 3;

        while (!objClicked && retries > 0)
        {
            driver.WaitForObject(By.PATH, objPathToClick).Click();

            try
            {
                driver.WaitForObject(By.PATH, objPathToSeen, timeout: 3);
                objClicked = true;
            }
            catch
            {
                retries--;
            }
        }
    }
}

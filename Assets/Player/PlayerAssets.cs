using AltTester.AltTesterSDK.Driver;

namespace Assets.PlayerAssets;

public static class PlayerAssets
{
    // Player
    private static string PlayerPath => "//*[contains(@name,Hero)]";

    // Gun assets
    public const string MagAmmoLeftText = "AmmoLeftInMagazineWidget";
    public const string TotalAmmoText = "TotalCountWidget";

    // Keyboard & Mouse bindings
    private static AltKeyCode ShootButton => AltKeyCode.Mouse0;
    private static AltKeyCode JumpButton => AltKeyCode.Space;

    // Player function
    public static AltObject GetPlayer(this AltDriver driver, bool isMainPlayer = true)
    {
        try
        {
            var players = driver.FindObjects(By.PATH, PlayerPath);
            foreach (var player in players)
            {
                var isBotControlled = player.CallComponentMethod<bool>("Pawn", "IsBotControlled", "", []);
                if (isMainPlayer ? !isBotControlled : isBotControlled)
                {
                    return player;
                }
            }

            throw new Exception("Couldn't find the player.");
        }
        catch (Exception exc)
        {
            throw new Exception($"Couldn't find anything with this path: {PlayerPath}.", exc);
        }
    }

    // Gun functions
    public static int GetAmmoCount(this AltDriver driver, string ammoTextObjectName) => int.Parse(driver.WaitForObject(By.NAME, ammoTextObjectName).GetText());
    public static void Shoot(this AltDriver driver, int bulletsToShoot)
    {
        for (int i = 0; i < bulletsToShoot; i++)
        {
            Thread.Sleep(300);
            driver.PressKey(ShootButton);
        }
    }

    // Movement functions
    public static void Jump(this AltDriver driver)
    {
        driver.PressKey(JumpButton);
    }
}
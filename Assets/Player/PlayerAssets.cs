using AltTester.AltTesterSDK.Driver;
namespace Assets.PlayerAssets;

public static class PlayerAssets
{
    // Hero
    private static string HeroPath => "//*[contains(@name,Hero)]";

    // Player
    public static string PlayerControllerPath => "//*[contains(@name,LyraPlayerController)]";

    // Gun assets
    public const string MagAmmoLeftText = "AmmoLeftInMagazineWidget";
    public const string TotalAmmoText = "TotalCountWidget";

    // Keyboard & Mouse bindings
    private static AltKeyCode ShootButton => AltKeyCode.Mouse0;
    private static AltKeyCode JumpButton => AltKeyCode.Space;

    // Heros function
    public static bool PlayerHasBeenSpawned(this AltDriver driver) => driver.WaitForObject(By.NAME, driver.GetHero().name).enabled;

    public static AltObject GetHero(this AltDriver driver, bool isPlayer = true)
    {
        try
        {
            var heros = driver.FindObjects(By.PATH, HeroPath);
            foreach (var hero in heros)
            {
                var isBotControlled = hero.CallComponentMethod<bool>("Pawn", "IsBotControlled", "", []);
                if (isPlayer ? !isBotControlled : isBotControlled)
                {
                    return hero;
                }
            }

            throw new Exception("Couldn't find the hero.");
        }
        catch (Exception exc)
        {
            throw new Exception($"Couldn't find anything with this path: {HeroPath}.", exc);
        }
    }

    // Gun functions
    public static int GetAmmoCount(this AltDriver driver, string ammoTextObjectName) => int.Parse(driver.WaitForObject(By.NAME, ammoTextObjectName).GetText());
    public static void Shoot(this AltDriver driver, int bulletsToShoot)
    {
        for (int i = 0; i < bulletsToShoot; i++)
        {
            // Delay between shots
            Thread.Sleep(200);

            // Shoot
            driver.PressKey(ShootButton);
        }
    }

    // Movement functions
    public static void Jump(this AltDriver driver)
    {
        driver.PressKey(JumpButton);
    }
}
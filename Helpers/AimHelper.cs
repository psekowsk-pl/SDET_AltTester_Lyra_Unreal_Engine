using AltTester.AltTesterSDK.Driver;
using Assets.PlayerAssets;
using Helper.DriverExtension;
using Helper.ObjectHelper;

namespace Helper.AimHelper;

public static class AimHelper
{
    public static void RotatePlayerToObject(this AltDriver driver, string targetName, int rotationZOffset = -5)
    {
        // Get Player object
        var player = driver.GetHero();

        // Get Target object
        var targetObject = driver.FindObjectWhichContains(By.NAME, targetName);

        // Get Player & Target location
        var playerLocation = player.GetObjectLocation();
        var targetLocation = targetObject.GetObjectLocation();

        // Get new direction for the Player
        var direction = driver.SetNewDirection(playerLocation, targetLocation);
    
        if (rotationZOffset != 0)
        {
            ObjectRotation newObjectRotation = ObjectRotation.Parse(direction);
            newObjectRotation.Yaw += rotationZOffset;
            direction = newObjectRotation.ToString();
        }

        // Set new rotation for Player Controller
        var playerController = driver.GetElementByPath(PlayerAssets.PlayerControllerPath);
        playerController.SetObjectRotation(direction);
    }
}


using Assets.PlayerAssets;
using Helper.AimHelper;
using Helper.DriverExtension;
using Helper.ObjectHelper;

namespace SDET_psekowsk.Tests;

public class GameplaySmokeTests : BaseTest
{
    [SetUp]
    public void TestsSetup()
    {
        // Load Scene on test start
        Driver.LoadScene(SceneAssets.ShooterGymMap);
    }

    [Test]
    public void GST1_VerifyIfPlayerCanRotateTowardsEnemy()
    {
        // Player spawn verification
        Assert.True(Driver.PlayerHasBeenSpawned());
        Logger.Info("Player has been spawned.");

        // Get Player object
        var player = Driver.GetHero();

        // Set Player starting rotation with higher aim (to avoid false negative result)
        ObjectRotation startingRotation = ObjectRotation.Parse(player.GetObjectRotation());
        startingRotation.Pitch = 60;

        var playerController = Driver.GetElementByPath(PlayerAssets.PlayerControllerPath);
        playerController.SetObjectRotation(startingRotation.ToString());
        Logger.Info($"Setting new Camera rotation to {startingRotation}.");

        // Get Player start rotation
        string playerStartRotation = player.UpdateObject().GetObjectRotation();
        Logger.Info($"Player's new starting rotation is: {playerStartRotation}.");

        // Aim at target
        Driver.RotatePlayerToObject(Driver.GetHero(false).name);
        Logger.Info($"Player's is now looking at different player.");

        // Verify Rotation change
        string playerCurrentRotation = player.UpdateObject().GetObjectRotation();
        Logger.Info($"Player's new current rotation is: {playerCurrentRotation}.");
        Assert.That(playerStartRotation, Is.Not.EqualTo(playerCurrentRotation));
        Logger.Pass("Player has rotated to proper target.");
    }
}
using AltTester.AltTesterSDK.Driver;
using Assets.PlayerAssets;

namespace SDET_psekowsk.Tests;

public class PlayterSmokeTests : BaseTest
{
    [SetUp]
    public void TestsSetup()
    {
        // Load Scene on test start
        Driver.LoadScene(SceneAssets.ShooterTestFireWeapon);
    }

    [Test]
    public void PST1_VerifyIfPlayerCanFireWithAWeapon()
    {
        int ammoToShoot = 1;

        // Player spawn verification
        Assert.True(Driver.PlayerHasBeenSpawned());
        Logger.Info("Player has been spawned.");

        // Get ammo from magazine and shoot
        int ammoBeforeShooting = Driver.GetAmmoCount(PlayerAssets.MagAmmoLeftText);
        Driver.Shoot(ammoToShoot);
        Logger.Info($"Shot {ammoToShoot} bullets.");

        // Check magazine
        int ammoAfterShooting = Driver.GetAmmoCount(PlayerAssets.MagAmmoLeftText);
        Assert.That(ammoAfterShooting, Is.EqualTo(ammoBeforeShooting - ammoToShoot));
        Logger.Pass($"Fire functionality is working.");
    }

    [TestCase(new[] { AltKeyCode.W }, true, false)]
    [TestCase(new[] { AltKeyCode.S }, true, false)]
    [TestCase(new[] { AltKeyCode.A }, false, true)]
    [TestCase(new[] { AltKeyCode.D }, false, true)]
    [TestCase(new[] { AltKeyCode.W, AltKeyCode.D }, true, true)]
    [TestCase(new[] { AltKeyCode.W, AltKeyCode.A }, true, true)]
    [TestCase(new[] { AltKeyCode.S, AltKeyCode.D }, true, true)]
    [TestCase(new[] { AltKeyCode.S, AltKeyCode.A }, true, true)]
    public void PST2_VerifyIfPlayerCanMove(AltKeyCode[] keys, bool expectedMovingByX, bool expectedMovingByY)
    {
        // Player spawn verification
        Assert.True(Driver.PlayerHasBeenSpawned());
        Logger.Info("Player has spawned.");

        // Get Player object
        var player = Driver.GetHero();

        // Get Player stating location
        AltVector3 startLocation = player.GetWorldPosition();
        Logger.Info($"Player start location: {startLocation}");

        // Move Player
        if (keys.Length == 1)
        {
            Driver.PressKey(keys[0], duration: 1);
        }
        else
        {
            Driver.PressKeys(keys, duration: 1);
        }

        // Get Player location after moving
        AltVector3 currentLocation = player.UpdateObject().GetWorldPosition();
        Logger.Info($"Player current location: {currentLocation}");

        // Assert
        var movedDisX = currentLocation.x - startLocation.x;
        var movedDisY = currentLocation.y - startLocation.y;

        if (expectedMovingByX)
        {
            Assert.That(movedDisX, Is.Not.EqualTo(0));
        }

        if (expectedMovingByY)
        {
            Assert.That(movedDisY, Is.Not.EqualTo(0));
        }

        Logger.Pass($"Player has moved properly.");
    }

    [Test]
    public void PST3_VerifyIfPlayerCanJump()
    {
        // Player spawn verification
        Assert.True(Driver.PlayerHasBeenSpawned());
        Logger.Info("Player has spawned.");

        // Get Player object
        var player = Driver.GetHero();

        // Get Player start height
        var startHeight = player.worldZ;
        Logger.Info($"Player start height: {startHeight}");

        // Jump
        Driver.Jump();

        // Get Player current height (in air)
        var currentHeight = player.UpdateObject().worldZ;
        Logger.Info($"Player current height: {currentHeight}");

        // Assert
        var jumpHeight = currentHeight - startHeight;
        Logger.Info($"Jump height: {jumpHeight}");
        Assert.That(jumpHeight, Is.GreaterThan(0), "Playerd didn't jump.");
        Logger.Pass("Player has jumped properly.");
    }
}
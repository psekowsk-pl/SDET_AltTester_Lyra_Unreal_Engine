using Assets.GameModesPage;
using Assets.MainMenuPage;
using Assets.OptionsPage;
using Assets.StartGamePage;
using Helper.DriverExtension;

namespace SDET_psekowsk.Tests;

public class MainMenuSmokeTests : BaseTest
{
    [SetUp]
    public void TestsSetup()
    {
        // Load Scene on test start
        SceneAssets.LoadScene(ref Driver, SceneAssets.LyraFrontEnd);
    }

    [Test]
    public void MMST1_VerifyIfMainMenuElementsAreVisible()
    {
        // Verify Main Menu elements
        Assert.True(Driver.GetElementByPath(MainMenuPage.MainMenuLogo).enabled);
        Assert.True(Driver.GetElementByPath(MainMenuPage.StartGameButton).enabled);
        Assert.True(Driver.GetElementByPath(MainMenuPage.OptionsButton).enabled);
        Assert.True(Driver.GetElementByPath(MainMenuPage.CreditsButton).enabled);
        Assert.True(Driver.GetElementByPath(MainMenuPage.ShowReplaysButton).enabled);
        Assert.True(Driver.GetElementByPath(MainMenuPage.QuitGameButton).enabled);
        Logger.Info("Main Menu elements are visible.");

        // Verify Start Game elements
        Driver.DoubleCheckClick(MainMenuPage.StartGameButton, StartGamePage.StartGameLogo);
        Assert.True(Driver.GetElementByPath(StartGamePage.StartGameLogo).enabled);
        Assert.True(Driver.GetElementByPath(StartGamePage.BrowseButton).enabled);
        Assert.True(Driver.GetElementByPath(StartGamePage.HostButton).enabled);
        Assert.True(Driver.GetElementByPath(StartGamePage.QuickplayButton).enabled);
        Logger.Info("Start Game elements are visible.");

        // Verify Gamemode elements
        Driver.DoubleCheckClick(StartGamePage.HostButton, GameModesPage.GameModesLogo);
        Assert.True(Driver.GetElementByPath(GameModesPage.GameModesLogo).enabled);
        Assert.True(Driver.GetElementByPath(GameModesPage.BotsButton).enabled);
        Assert.True(Driver.GetElementByPath(GameModesPage.SessionButton).enabled);
        Assert.True(Driver.GetElementByPath(GameModesPage.EliminationText).enabled);
        Assert.True(Driver.GetElementByPath(GameModesPage.ControlText).enabled);
        Assert.True(Driver.GetElementByPath(GameModesPage.ExploderText).enabled);
        Assert.True(Driver.GetElementByPath(GameModesPage.ExploderMultiplayerText).enabled);
        Logger.Info("Gamemode elements are visible.");
        Logger.Pass("All elements have been verified.");
    }

    [Test]
    public void MMST2_VerifyIfOptionsAreVisible()
    {
        // Open Options
        Assert.True(Driver.GetElementByPath(MainMenuPage.MainMenuLogo).enabled);
        Driver.DoubleCheckClick(MainMenuPage.OptionsButton, OptionsPage.GameplayButton);

        // Verify Tab buttons
        Assert.True(Driver.GetElementByPath(OptionsPage.GameplayButton).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.VideoButton).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.AudioButton).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.MouseAndKeyboardButton).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.GamepadButton).enabled);
        Logger.Info("Tab buttons are visible.");
    
        // Verify Gameplay setting elements
        Assert.True(Driver.GetElementByPath(OptionsPage.LanguageLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.LanguageText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ReplaysLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.RecordReplaysText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.KeepReplayLimitText).enabled);
        Logger.Info("Gameplay settings are visible.");

        // Verify Video setting elements
        Driver.DoubleCheckClick(OptionsPage.VideoButton, OptionsPage.DisplayLabel);
        Assert.True(Driver.GetElementByPath(OptionsPage.DisplayLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.WindowModeText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ResolutionText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.PerformanceStatsText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.GraphicsLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ColorBlindModeText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ColorBlindStrengthText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.PerformanceStatsText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.GraphicsLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.AutoSetQualityText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.QualityPresetsText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ThreeDResolutionText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.GlobalIlluminationText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ShadowsText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.AntiAliasingText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ViewDistanceText).enabled);
        Logger.Info("Gameplay settings are visible.");
        
        // Verify Audio setting elements
        Driver.GetElementByPath(OptionsPage.AudioButton).Click();
        Assert.True(Driver.GetElementByPath(OptionsPage.VolumeLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.OverallText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.MusicText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.SoundEffectsText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.DialogueText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.VoiceChatText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.SoundLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.SubtitlesText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.BackgroundAudioText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ThreeDHeadphonesText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.HighDynamicRangeAudioText).enabled);
        Logger.Info("Audio settings are visible.");

        // Verify Mouse & Keyboard setting elements
        Driver.DoubleCheckClick(OptionsPage.MouseAndKeyboardButton, OptionsPage.SensitivityLabel);
        Assert.True(Driver.GetElementByPath(OptionsPage.SensitivityLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.XAxisSensitivityText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.YAxisSensitivityText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.TargetingSensitivityText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.InvertVerticalAxisText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.InvertHorizontalAxisText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.DefaultExperiencesLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.MoveForwardText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.MoveBackwardsText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.MoveLeftText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.MoveRightText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.WeaponFireText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.JumpText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.CrouchText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ReloadText).enabled);
        Logger.Info("Mouse & Keyboard settings are visible.");

        // Verify Gamepad setting elements
        Driver.DoubleCheckClick(OptionsPage.GamepadButton, OptionsPage.HardwareLabel);
        Assert.True(Driver.GetElementByPath(OptionsPage.HardwareLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ControllerHardwareText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.VibrationText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.InvertVerticalAxisText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.InvertHorizontalAxisText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.SensitivityLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.LookSensitivityText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.ControllerDeadZoneLabel).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.LeftStickDeadZoneText).enabled);
        Assert.True(Driver.GetElementByPath(OptionsPage.RightStickDeadZoneText).enabled);
        Logger.Info("Gamepad settings are visible.");
        Logger.Pass("All Option elements have been verified.");
    }
}
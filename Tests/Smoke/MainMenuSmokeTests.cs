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
        Driver.LoadScene(SceneAssets.LyraFrontEnd);
    }

    [Test]
    public void MMST1_VerifyIfMainMenuElementsAreVisible()
    {
        bool elementsAreVisible = true;


        Driver.FindObjects(AltTester.AltTesterSDK.Driver.By.PATH, MainMenuPage.MainMenuLogo);
        // Verify Main Menu elements
        Dictionary<string, bool> mainMenuElements = new()
        {
            { MainMenuPage.MainMenuLogo, Driver.IsUIElementVisible(MainMenuPage.MainMenuLogo) },
            { MainMenuPage.StartGameButton, Driver.IsUIElementVisible(MainMenuPage.StartGameButton) },
            { MainMenuPage.OptionsButton, Driver.IsUIElementVisible(MainMenuPage.OptionsButton) },
            { MainMenuPage.CreditsButton, Driver.IsUIElementVisible(MainMenuPage.CreditsButton) },
            { MainMenuPage.ShowReplaysButton, Driver.IsUIElementVisible(MainMenuPage.ShowReplaysButton) },
            { MainMenuPage.QuitGameButton, Driver.IsUIElementVisible(MainMenuPage.QuitGameButton) }
        };

        // Verify Start Game elements
        Driver.DoubleCheckClick(MainMenuPage.StartGameButton, StartGamePage.StartGameLogo);
        Dictionary<string, bool> startGameElements = new()
        {
            { StartGamePage.StartGameLogo, Driver.IsUIElementVisible(StartGamePage.StartGameLogo) },
            { StartGamePage.BrowseButton, Driver.IsUIElementVisible(StartGamePage.BrowseButton) },
            { StartGamePage.HostButton, Driver.IsUIElementVisible(StartGamePage.HostButton) },
            { StartGamePage.QuickplayButton, Driver.IsUIElementVisible(StartGamePage.QuickplayButton) }
        };

        // Verify Gamemode elements
        Driver.DoubleCheckClick(StartGamePage.HostButton, GameModesPage.GameModesLogo);
        Dictionary<string, bool> gameModeElements = new()
        {
            { GameModesPage.GameModesLogo, Driver.IsUIElementVisible(GameModesPage.GameModesLogo) },
            { GameModesPage.BotsButton, Driver.IsUIElementVisible(GameModesPage.BotsButton) },
            { GameModesPage.SessionButton, Driver.IsUIElementVisible(GameModesPage.SessionButton) },
            { GameModesPage.EliminationText, Driver.IsUIElementVisible(GameModesPage.EliminationText) },
            { GameModesPage.ControlText, Driver.IsUIElementVisible(GameModesPage.ControlText) },
            { GameModesPage.ExploderText, Driver.IsUIElementVisible(GameModesPage.ExploderText) },
            { GameModesPage.ExploderMultiplayerText, Driver.IsUIElementVisible(GameModesPage.ExploderMultiplayerText) }
        };

        // Get elements status
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(mainMenuElements);
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(startGameElements);
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(gameModeElements);

        if (elementsAreVisible)
        {
            Logger.Info("Main Menu elements are visible.");
            Logger.Info("Start Game elements are visible.");
            Logger.Info("Gamemode elements are visible.");
            Logger.Pass("All elements have been verified.");
        }
        else
        {
            Logger.Error("Some elements were not visible.");
        }

        Assert.True(elementsAreVisible);
    }

    [Test]
    public void MMST2_VerifyIfOptionsAreVisible()
    {
        bool elementsAreVisible = true;

        // Open Options
        Assert.True(Driver.IsUIElementVisible(MainMenuPage.MainMenuLogo));
        Driver.DoubleCheckClick(MainMenuPage.OptionsButton, OptionsPage.GameplayButton);

        // Verify Tab buttons
        Dictionary<string, bool> tabButtons = new()
        {
            { OptionsPage.GameplayButton, Driver.IsUIElementVisible(OptionsPage.GameplayButton) },
            { OptionsPage.VideoButton, Driver.IsUIElementVisible(OptionsPage.VideoButton) },
            { OptionsPage.AudioButton, Driver.IsUIElementVisible(OptionsPage.AudioButton) },
            { OptionsPage.MouseAndKeyboardButton, Driver.IsUIElementVisible(OptionsPage.MouseAndKeyboardButton) },
            { OptionsPage.GamepadButton, Driver.IsUIElementVisible(OptionsPage.GamepadButton) }
        };
    
        // Verify Gameplay setting elements
        Dictionary<string, bool> gameplaySettingElements = new()
        {
            { OptionsPage.LanguageLabel, Driver.IsUIElementVisible(OptionsPage.LanguageLabel) },
            { OptionsPage.LanguageText, Driver.IsUIElementVisible(OptionsPage.LanguageText) },
            { OptionsPage.ReplaysLabel, Driver.IsUIElementVisible(OptionsPage.ReplaysLabel) },
            { OptionsPage.RecordReplaysText, Driver.IsUIElementVisible(OptionsPage.RecordReplaysText) },
            { OptionsPage.KeepReplayLimitText, Driver.IsUIElementVisible(OptionsPage.KeepReplayLimitText) }
        };

        // Verify Video setting elements
        Driver.DoubleCheckClick(OptionsPage.VideoButton, OptionsPage.DisplayLabel);
        Dictionary<string, bool> videoSettingElements = new()
        {
            { OptionsPage.DisplayLabel, Driver.IsUIElementVisible(OptionsPage.DisplayLabel) },
            { OptionsPage.WindowModeText, Driver.IsUIElementVisible(OptionsPage.WindowModeText) },
            { OptionsPage.ResolutionText, Driver.IsUIElementVisible(OptionsPage.ResolutionText) },
            { OptionsPage.PerformanceStatsText, Driver.IsUIElementVisible(OptionsPage.PerformanceStatsText) },
            { OptionsPage.GraphicsLabel, Driver.IsUIElementVisible(OptionsPage.GraphicsLabel) },
            { OptionsPage.ColorBlindModeText, Driver.IsUIElementVisible(OptionsPage.ColorBlindModeText) },
            { OptionsPage.ColorBlindStrengthText, Driver.IsUIElementVisible(OptionsPage.ColorBlindStrengthText) },
            { OptionsPage.AutoSetQualityText, Driver.IsUIElementVisible(OptionsPage.AutoSetQualityText) },
            { OptionsPage.QualityPresetsText, Driver.IsUIElementVisible(OptionsPage.QualityPresetsText) },
            { OptionsPage.ThreeDResolutionText, Driver.IsUIElementVisible(OptionsPage.ThreeDResolutionText) },
            { OptionsPage.GlobalIlluminationText, Driver.IsUIElementVisible(OptionsPage.GlobalIlluminationText) },
            { OptionsPage.ShadowsText, Driver.IsUIElementVisible(OptionsPage.ShadowsText) },
            { OptionsPage.AntiAliasingText, Driver.IsUIElementVisible(OptionsPage.AntiAliasingText) },
            { OptionsPage.ViewDistanceText, Driver.IsUIElementVisible(OptionsPage.ViewDistanceText) },
        };
        
        // Verify Audio setting elements
        Driver.DoubleCheckClick(OptionsPage.AudioButton, OptionsPage.VolumeLabel);
        Dictionary<string, bool> audioSettingElements = new()
        {
            { OptionsPage.VolumeLabel, Driver.IsUIElementVisible(OptionsPage.VolumeLabel) },
            { OptionsPage.OverallText, Driver.IsUIElementVisible(OptionsPage.OverallText) },
            { OptionsPage.MusicText, Driver.IsUIElementVisible(OptionsPage.MusicText) },
            { OptionsPage.SoundEffectsText, Driver.IsUIElementVisible(OptionsPage.SoundEffectsText) },
            { OptionsPage.DialogueText, Driver.IsUIElementVisible(OptionsPage.DialogueText) },
            { OptionsPage.VoiceChatText, Driver.IsUIElementVisible(OptionsPage.VoiceChatText) },
            { OptionsPage.SoundLabel, Driver.IsUIElementVisible(OptionsPage.SoundLabel) },
            { OptionsPage.SubtitlesText, Driver.IsUIElementVisible(OptionsPage.SubtitlesText) },
            { OptionsPage.BackgroundAudioText, Driver.IsUIElementVisible(OptionsPage.BackgroundAudioText) },
            { OptionsPage.ThreeDHeadphonesText, Driver.IsUIElementVisible(OptionsPage.ThreeDHeadphonesText) },
            { OptionsPage.HighDynamicRangeAudioText, Driver.IsUIElementVisible(OptionsPage.HighDynamicRangeAudioText) }
        };

        // Verify Mouse & Keyboard setting elements
        Driver.DoubleCheckClick(OptionsPage.MouseAndKeyboardButton, OptionsPage.SensitivityLabel);
        Dictionary<string, bool> mouseAndKeyboardSettingElements = new()
        {
            { OptionsPage.SensitivityLabel, Driver.IsUIElementVisible(OptionsPage.SensitivityLabel) },
            { OptionsPage.XAxisSensitivityText, Driver.IsUIElementVisible(OptionsPage.XAxisSensitivityText) },
            { OptionsPage.YAxisSensitivityText, Driver.IsUIElementVisible(OptionsPage.YAxisSensitivityText) },
            { OptionsPage.TargetingSensitivityText, Driver.IsUIElementVisible(OptionsPage.TargetingSensitivityText) },
            { OptionsPage.InvertVerticalAxisText, Driver.IsUIElementVisible(OptionsPage.InvertVerticalAxisText) },
            { OptionsPage.InvertHorizontalAxisText, Driver.IsUIElementVisible(OptionsPage.InvertHorizontalAxisText) },
            { OptionsPage.DefaultExperiencesLabel, Driver.IsUIElementVisible(OptionsPage.DefaultExperiencesLabel) },
            { OptionsPage.MoveForwardText, Driver.IsUIElementVisible(OptionsPage.MoveForwardText) },
            { OptionsPage.MoveBackwardsText, Driver.IsUIElementVisible(OptionsPage.MoveBackwardsText) },
            { OptionsPage.MoveLeftText, Driver.IsUIElementVisible(OptionsPage.MoveLeftText) },
            { OptionsPage.MoveRightText, Driver.IsUIElementVisible(OptionsPage.MoveRightText) },
            { OptionsPage.WeaponFireAutoText, Driver.IsUIElementVisible(OptionsPage.WeaponFireText) },
            { OptionsPage.JumpText, Driver.IsUIElementVisible(OptionsPage.JumpText) }
        };

        // Verify Gamepad setting elements
        Driver.DoubleCheckClick(OptionsPage.GamepadButton, OptionsPage.HardwareLabel);
        Dictionary<string, bool> gamepadSettingElements = new()
        {
            { OptionsPage.HardwareLabel, Driver.IsUIElementVisible(OptionsPage.HardwareLabel) },
            { OptionsPage.ControllerHardwareText, Driver.IsUIElementVisible(OptionsPage.ControllerHardwareText) },
            { OptionsPage.VibrationText, Driver.IsUIElementVisible(OptionsPage.VibrationText) },
            { OptionsPage.InvertVerticalAxisText, Driver.IsUIElementVisible(OptionsPage.InvertVerticalAxisText) },
            { OptionsPage.InvertHorizontalAxisText, Driver.IsUIElementVisible(OptionsPage.InvertHorizontalAxisText) },
            { OptionsPage.SensitivityLabel, Driver.IsUIElementVisible(OptionsPage.SensitivityLabel) },
            { OptionsPage.LookSensitivityText, Driver.IsUIElementVisible(OptionsPage.LookSensitivityText) },
            { OptionsPage.ControllerDeadZoneLabel, Driver.IsUIElementVisible(OptionsPage.ControllerDeadZoneLabel) },
            { OptionsPage.LeftStickDeadZoneText, Driver.IsUIElementVisible(OptionsPage.LeftStickDeadZoneText) },
            { OptionsPage.RightStickDeadZoneText, Driver.IsUIElementVisible(OptionsPage.RightStickDeadZoneText) }
        };

        // Get elements status
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(tabButtons);
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(gameplaySettingElements);
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(videoSettingElements);
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(audioSettingElements);
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(mouseAndKeyboardSettingElements);
        elementsAreVisible &= DictionaryHelper.AreElementsVisible(gamepadSettingElements);

        if (elementsAreVisible)
        {
            Logger.Info("Tab buttons are visible.");
            Logger.Info("Gameplay settings are visible.");
            Logger.Info("Video settings are visible.");
            Logger.Info("Audio settings are visible.");
            Logger.Info("Mouse & Keyboard settings are visible.");
            Logger.Info("Gamepad settings are visible.");
            Logger.Pass("All Option elements have been verified.");
        }
        else
        {
            Logger.Error("Some elements were not visible.");
        }
        
        Assert.True(elementsAreVisible);
    }
}
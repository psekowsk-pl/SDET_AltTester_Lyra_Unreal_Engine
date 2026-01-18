namespace Assets.OptionsPage;

public static class OptionsPage
{
    // Prefixes
    private static string TabElementPrefix(string text) => $"//*[contains(@name,LyraButtonTab)]//ButtonTextBlock[contains(@text,{text})]";
    private static string LabelElementPrefix(string text) => $"//*[contains(@name,SettingsListEntry_Header)]//Text_SettingName[contains(@text,{text})]";
    private static string SettingElementPrefix(string text) => $"//ResponsivePanel//Text_SettingName[contains(@text,{text})]";

    // Header buttons
    public static string GameplayButton => TabElementPrefix("Gameplay");
    public static string VideoButton => TabElementPrefix("Video");
    public static string AudioButton => TabElementPrefix("Audio");
    public static string MouseAndKeyboardButton => TabElementPrefix("Mouse & Keyboard");
    public static string GamepadButton => TabElementPrefix("Gamepad");

    // Gameplay settings
    public static string LanguageLabel => LabelElementPrefix("Language");
    public static string LanguageText => SettingElementPrefix("Language");
    public static string ReplaysLabel => LabelElementPrefix("Replays");
    public static string RecordReplaysText => SettingElementPrefix("Record Replays");
    public static string KeepReplayLimitText => SettingElementPrefix("Keep Replay Limit");

    // Display settings
    public static string DisplayLabel => LabelElementPrefix("Display");
    public static string WindowModeText => SettingElementPrefix("Window Mode");
    public static string ResolutionText => SettingElementPrefix("Resolution");
    public static string PerformanceStatsText => SettingElementPrefix("Performance Stats");

    public static string GraphicsLabel => LabelElementPrefix("Graphics");
    public static string ColorBlindModeText => SettingElementPrefix("Color Blind Mode");
    public static string ColorBlindStrengthText => SettingElementPrefix("Color Blind Strength");
    public static string BrightnessText => SettingElementPrefix("Brightness");

    public static string GraphicsQualityLabel => LabelElementPrefix("Graphics quality");
    public static string AutoSetQualityText => SettingElementPrefix("Auto-Set Quality");
    public static string QualityPresetsText => SettingElementPrefix("Quality Presets");
    public static string ThreeDResolutionText => SettingElementPrefix("3D Resolution");
    public static string GlobalIlluminationText => SettingElementPrefix("Global Illumination");
    public static string ShadowsText => SettingElementPrefix("Shadows");
    public static string AntiAliasingText => SettingElementPrefix("Anti-Aliasing");
    public static string ViewDistanceText => SettingElementPrefix("View Distance");
    public static string TexturesText => SettingElementPrefix("Textures");
    public static string EffectsText => SettingElementPrefix("Effects");
    public static string ReflectionsText => SettingElementPrefix("Reflections");
    public static string PostProcessingText => SettingElementPrefix("Post Processing");

    public static string AdvancedGraphicsLabel => LabelElementPrefix("Advanced graphics");
    public static string VerticalSyncText => SettingElementPrefix("Vertical Sync");
    public static string FrameRateLimitText => SettingElementPrefix("Frame Rate Limit");

    // Audio settings
    public static string VolumeLabel => LabelElementPrefix("Volume");
    public static string OverallText => SettingElementPrefix("Overall");
    public static string MusicText => SettingElementPrefix("Music");
    public static string SoundEffectsText => SettingElementPrefix("Sound Effects");
    public static string DialogueText => SettingElementPrefix("Dialogue");
    public static string VoiceChatText => SettingElementPrefix("Voice Chat");

    public static string SoundLabel => LabelElementPrefix("Sound");
    public static string SubtitlesText => SettingElementPrefix("Subtitles");
    public static string BackgroundAudioText => SettingElementPrefix("Background Audio");
    public static string ThreeDHeadphonesText => SettingElementPrefix("3D Headphones");
    public static string HighDynamicRangeAudioText => SettingElementPrefix("High Dynamic Range Audio");

    // Mouse & keyboard settings
    public static string SensitivityLabel => LabelElementPrefix("Sensitivity");
    public static string XAxisSensitivityText => SettingElementPrefix("X-Axis Sensitivity");
    public static string YAxisSensitivityText => SettingElementPrefix("Y-Axis Sensitivity");
    public static string TargetingSensitivityText => SettingElementPrefix("Targeting Sensitivity");
    public static string InvertVerticalAxisText => SettingElementPrefix("Invert Vertical Axis");
    public static string InvertHorizontalAxisText => SettingElementPrefix("Invert Horizontal Axis");

    public static string DefaultExperiencesLabel => LabelElementPrefix("Default Experiences");
    public static string MoveForwardText => SettingElementPrefix("Move Forward");
    public static string MoveBackwardsText => SettingElementPrefix("Move Backwards");
    public static string MoveLeftText => SettingElementPrefix("Move Left");
    public static string MoveRightText => SettingElementPrefix("Move Right");
    public static string WeaponFireText => SettingElementPrefix("Weapon Fire");
    public static string JumpText => SettingElementPrefix("Jump");
    public static string CrouchText => SettingElementPrefix("Crouch");
    public static string ReloadText => SettingElementPrefix("Reload");
    public static string DashText => SettingElementPrefix("Dash");
    public static string AutoRunText => SettingElementPrefix("Auto-run");
    public static string WeaponFireAutoText => SettingElementPrefix("Weapon Fire (Auto)");

    public static string ShooterCoreLabel => LabelElementPrefix("Shooter Core");
    public static string ShowScoreboardText => SettingElementPrefix("Show Scoreboard");
    public static string AimDownSightText => SettingElementPrefix("Aim Down Sight");
    public static string ThrowGrenadeText => SettingElementPrefix("Throw Grenade");
    public static string EmoteText => SettingElementPrefix("Emote");
    public static string QuickSlot1Text => SettingElementPrefix("Quick Slot 1");
    public static string QuickSlot2Text => SettingElementPrefix("Quick Slot 2");
    public static string QuickSlot3Text => SettingElementPrefix("Quick Slot 3");
    public static string MeleeText => SettingElementPrefix("Melee");
    public static string QuickslotCycleBackwardText => SettingElementPrefix("Quickslot Cycle Backward");
    public static string QuickslotCycleForwardText => SettingElementPrefix("Quickslot Cycle Forward");

    // Gamepad settings
    public static string HardwareLabel => LabelElementPrefix("Hardware");
    public static string ControllerHardwareText => SettingElementPrefix("Controller Hardware");
    public static string VibrationText => SettingElementPrefix("Vibration");
    
    public static string LookSensitivityText => SettingElementPrefix("Look Sensitivity");
    
    public static string ControllerDeadZoneLabel => LabelElementPrefix("Controller DeadZone");
    public static string LeftStickDeadZoneText => SettingElementPrefix("Left Stick DeadZone");
    public static string RightStickDeadZoneText => SettingElementPrefix("Right Stick DeadZone");
}
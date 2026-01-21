using AltTester.AltTesterSDK.Driver;

public static class SceneAssets
{
    private static string ScenePrefix => "L_";

    // Maps
    public static string ConvolutionBlockout => $"{ScenePrefix}Convolution_Blockout";
    public static string DefaultEditorOverview => $"{ScenePrefix}DefaultEditorOverview";
    public static string Expanse => $"{ScenePrefix}Expanse";
    public static string ExpanseBlockout => $"{ScenePrefix}Expanse_Blockout";
    public static string FiringRangeWP => $"{ScenePrefix}FiringRange_WP";
    public static string InteractionTestMap => $"{ScenePrefix}InteractionTestMap";
    public static string InventoryTestMap => $"{ScenePrefix}InventoryTestMap";
    public static string LyraFrontEnd => $"{ScenePrefix}LyraFrontEnd";
    public static string ShooterFrontendBackground => $"{ScenePrefix}ShooterFrontendBackground";
    public static string ShooterGymMap => $"{ScenePrefix}ShooterGym";
    public static string ShooterTestAutoRun => $"{ScenePrefix}ShooterTest_AutoRun";
    public static string ShooterTestDeviceProperties => $"{ScenePrefix}ShooterTest_DeviceProperties";
    public static string ShooterTestFireWeapon => $"{ScenePrefix}ShooterTest_FireWeapon";
    public static string TopDownLocalMultiplayer => $"{ScenePrefix}TopDown_LocalMultiplayer";
    public static string TopDownArenaGym => $"{ScenePrefix}TopDownArenaGym";
    public static string TransitionMap => $"TransitionMap";

    // Functions
    public static void LoadScene(this AltDriver driver, string sceneName)
    {
        driver.LoadScene(sceneName);

        // Verify if Scene has been changed
        driver.WaitForCurrentSceneToBe(sceneName);
    }
}
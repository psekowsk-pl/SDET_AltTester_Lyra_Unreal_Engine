namespace Assets.GameModesPage;

public static class GameModesPage
{
    // Prefixes
    private static string ExperienceTitlePrefix(string text) => $"//ExperienceTitle[contains(@text,{text})]";

    // Game Mode logo
    public static string GameModesLogo => "//AnimBoundHeaderHB//*[contains(@text,Host a game)]";

    // Game Mode buttons
    public static string BotsButton => "//BotsToggleButton";
    public static string SessionButton => "//SessionTypeButton";
    public static string EliminationText => ExperienceTitlePrefix("Elimination");
    public static string ControlText => ExperienceTitlePrefix("Control");
    public static string ExploderText => ExperienceTitlePrefix("Exploder");
    public static string ExploderMultiplayerText => ExperienceTitlePrefix("Exploder Multiplayer");
}
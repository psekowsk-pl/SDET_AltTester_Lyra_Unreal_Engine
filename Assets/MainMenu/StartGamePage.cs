namespace Assets.StartGamePage;

public static class StartGamePage
{
    // StartGame logo
    public static string StartGameLogo => "//AnimBoundHeaderHB//*[contains(@text,Main Menu)]";

    // StartGame buttons
    public static string QuickplayButton => "//QuickplayButton//ButtonTextBlock[contains(@text,Quickplay)]";
    public static string HostButton => "//HostButton//ButtonTextBlock[contains(@text,Start a Game)]";
    public static string BrowseButton => "//BrowseButton//ButtonTextBlock[contains(@text,Browse)]";
}
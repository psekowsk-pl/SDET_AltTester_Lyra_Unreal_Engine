public static class FilePath
{
    public static string GetBasePath() => AppContext.BaseDirectory;
    public static string GetBaseProjectPath() => Path.GetFullPath(Path.Combine(GetBasePath(), "..", "..", ".."));
    public static string GetAltTesterConfigJSON() => Path.Combine(GetBaseProjectPath(), "Config/AltTesterSettings.json"); 
}
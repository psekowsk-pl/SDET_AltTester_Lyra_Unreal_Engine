
using AltTester.AltTesterSDK.Driver;

public static class AltDriverManager
{
    public static AltDriver Driver { get; private set; } = default!;
    public static float ObjectTimeout { get; set; } = 60;

    public static void Start()
    {
        AltTesterConfig? altTesterConfig = null;
        try
        {
            altTesterConfig = JsonReader.Read<AltTesterConfig>(FilePath.GetAltTesterConfigJSON());   
        }
        catch {}

        if (altTesterConfig == null)
        {
            Driver = new();
        }
        else
        {
            Driver = new(
                host: altTesterConfig.Host,
                port: altTesterConfig.Port,
                appName: altTesterConfig.AppName,
                enableLogging: altTesterConfig.EnableLogging,
                connectTimeout: altTesterConfig.ConnectTimeout
            );
        }
    }

    public static void Stop()
    {
        Driver?.Stop();
    }
}
using System.Globalization;
using AltTester.AltTesterSDK.Driver;

namespace Helper.ObjectHelper;

public static class ObjectExtension
{
    // Component names
    public static string ActorComponent => "Actor";
    public static string KismetMathComponent => "KismetMathLibrary";
    public static string ControllerComponent => "Controller";

    // Object methods
    public static string GetActorLocationMethod => "K2_GetActorLocation";
    public static string GetActorRotationMethod => "K2_GetActorRotation";
    public static string SetControlLocationMethod => "SetControlLocation";
    public static string SetControlRotationMethod => "SetControlRotation";
    public static string FindLookRotationMethod => "FindLookAtRotation";

    // Object functions
    public static string GetObjectLocation(this AltObject obj) => obj.CallComponentMethod<string>(ActorComponent, GetActorLocationMethod, "", []);
    public static string GetObjectRotation(this AltObject obj) => obj.CallComponentMethod<string>(ActorComponent, GetActorRotationMethod, "", []);
    public static string SetObjectLocation(this AltObject obj, string newLocation) => obj.CallComponentMethod<string>(ControllerComponent, SetControlLocationMethod, "", [newLocation]);
    public static string SetObjectRotation(this AltObject obj, string newDirection) => obj.CallComponentMethod<string>(ControllerComponent, SetControlRotationMethod, "", [newDirection]);
    public static string SetNewDirection(this AltDriver driver, string objLocation, string targetLocation) => driver.CallStaticMethod<string>(KismetMathComponent, FindLookRotationMethod, "", [objLocation, targetLocation]);
}

public struct ObjectRotation(double pitch, double yaw, double roll)
{
    public double Pitch = pitch;
    public double Yaw = yaw;
    public double Roll = roll;

    public override readonly string ToString()
    {
        return $"(Pitch={Pitch.ToString(CultureInfo.InvariantCulture)},Yaw={Yaw.ToString(CultureInfo.InvariantCulture)},Roll={Roll.ToString(CultureInfo.InvariantCulture)})";
    }

    public static ObjectRotation Parse(string rotationString)
    {
        rotationString = rotationString.Trim('(', ')');
        var components = rotationString.Split(',');

        double pitch = double.Parse(components[0].Split('=')[1], CultureInfo.InvariantCulture);
        double yaw = double.Parse(components[1].Split('=')[1], CultureInfo.InvariantCulture);
        double roll = double.Parse(components[2].Split('=')[1], CultureInfo.InvariantCulture);

        return new ObjectRotation(pitch, yaw, roll);
    }
}
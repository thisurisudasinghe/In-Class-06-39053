public class EntertainmentRobot : Robot
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }
    public string EntertainmentFeature { get; set; }

    public EntertainmentRobot(string modelName, int batteryCapacity,
                               string softwareVersion,
                               string entertainmentFeature)
    {
        ModelName = modelName;
        BatteryCapacity = batteryCapacity;
        SoftwareVersion = softwareVersion;
        EntertainmentFeature = entertainmentFeature;
    }

    public Robot Clone()
    {
        return new EntertainmentRobot(
            ModelName,
            BatteryCapacity,
            SoftwareVersion,
            EntertainmentFeature
        );
    }

    public void DisplayRobot()
    {
        Console.WriteLine("Entertainment Robot");
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
        Console.WriteLine("Software Version: " + SoftwareVersion);
        Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
        Console.WriteLine();
    }
}
public class IndustrialRobot : Robot
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }
    public string IndustrialTask { get; set; }

    public IndustrialRobot(string modelName, int batteryCapacity,
                           string softwareVersion, string industrialTask)
    {
        ModelName = modelName;
        BatteryCapacity = batteryCapacity;
        SoftwareVersion = softwareVersion;
        IndustrialTask = industrialTask;
    }

    public Robot Clone()
    {
        return new IndustrialRobot(
            ModelName,
            BatteryCapacity,
            SoftwareVersion,
            IndustrialTask
        );
    }

    public void DisplayRobot()
    {
        Console.WriteLine("Industrial Robot");
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
        Console.WriteLine("Software Version: " + SoftwareVersion);
        Console.WriteLine("Industrial Task: " + IndustrialTask);
        Console.WriteLine();
    }
}
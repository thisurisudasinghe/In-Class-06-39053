public class ServiceRobot : Robot
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }
    public string ServiceTask { get; set; }

    public ServiceRobot(string modelName, int batteryCapacity,
                        string softwareVersion, string serviceTask)
    {
        ModelName = modelName;
        BatteryCapacity = batteryCapacity;
        SoftwareVersion = softwareVersion;
        ServiceTask = serviceTask;
    }

    public Robot Clone()
    {
        return new ServiceRobot(
            ModelName,
            BatteryCapacity,
            SoftwareVersion,
            ServiceTask
        );
    }

    public void DisplayRobot()
    {
        Console.WriteLine("Service Robot");
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
        Console.WriteLine("Software Version: " + SoftwareVersion);
        Console.WriteLine("Service Task: " + ServiceTask);
        Console.WriteLine();
    }
}
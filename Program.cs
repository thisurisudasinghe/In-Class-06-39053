ServiceRobot serviceRobot = new ServiceRobot(
    "SR-100",
    10,
    "V1.0",
    "Patient Assistance"
);

IndustrialRobot industrialRobot = new IndustrialRobot(
    "IR-200",
    20,
    "V2.0",
    "Welding"
);

EntertainmentRobot entertainmentRobot = new EntertainmentRobot(
    "ER-300",
    8,
    "V1.5",
    "Dancing and Talking"
);


// Create Robot Factory
RobotFactory factory = new RobotFactory();


// Register prototype robots
factory.RegisterRobot("service", serviceRobot);
factory.RegisterRobot("industrial", industrialRobot);
factory.RegisterRobot("entertainment", entertainmentRobot);


// Clone Service Robot
ServiceRobot customerRobot =
    (ServiceRobot)factory.CreateRobot("service");


// Customize cloned robot
customerRobot.BatteryCapacity = 15;
customerRobot.SoftwareVersion = "V2.0";


// Display original robot
Console.WriteLine("===== ORIGINAL ROBOT =====");
serviceRobot.DisplayRobot();


// Display cloned robot
Console.WriteLine("===== CLONED ROBOT =====");
customerRobot.DisplayRobot();
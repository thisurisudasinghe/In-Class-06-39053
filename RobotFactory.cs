using System.Collections.Generic;

public class RobotFactory
{
    private Dictionary<string, Robot> robotRegistry =
        new Dictionary<string, Robot>();

    public void RegisterRobot(string name, Robot robot)
    {
        robotRegistry[name] = robot;
    }

    public Robot CreateRobot(string name)
    {
        if (robotRegistry.ContainsKey(name))
        {
            return robotRegistry[name].Clone();
        }

        return null;
    }
}
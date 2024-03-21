using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH5.FlyweightPattern
{
    internal class RobotFactory
    {
        Dictionary<string, IRobot> shapes = new Dictionary<string, IRobot>();
        public int TotalObjectCreated
        {
            get { return shapes.Count; }
        }
        public IRobot GetRobotFromFactory(string robotType)
        {
            IRobot robotCategory = null;
            if (shapes.ContainsKey(robotType))
            {
                robotCategory = shapes[robotType];
            }
            else
            {
                switch(robotType)
                {
                    case "Small":
                        robotCategory = new SmallRobot();
                        shapes.Add(robotType, robotCategory);
                        break;
                    case "Large":
                        robotCategory = new LargeRobot();
                        shapes.Add(robotType, robotCategory);
                        break;
                    default:
                        throw new Exception("Robot Factory can create only small or large robots");

                }
            }
            return robotCategory;
        }
    }
}

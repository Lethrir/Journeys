using System;

namespace Journeys.Actions
{
    public class ActionFactory
    {
        public IRobotAction BuildAction(RobotAction action)
        {
            switch (action)
            {
                case RobotAction.F:
                    return new Forward();
                case RobotAction.L:
                    return new Left();
                case RobotAction.R:
                    return new Right();
            }
            throw new Exception("Cannot create action, invalid action type");
        }

    }
}

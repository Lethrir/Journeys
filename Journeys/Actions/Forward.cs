using System;

namespace Journeys.Actions
{
    public class Forward : IRobotAction
    {
        public RobotState UpdateState(RobotState current)
        {
            switch (current.Facing)
            {
                case 0:
                    return new RobotState(current.X, current.Y + 1, current.Facing);
                case 90:
                    return new RobotState(current.X + 1, current.Y, current.Facing);
                case 180:
                    return new RobotState(current.X, current.Y - 1, current.Facing);
                case 270:
                    return new RobotState(current.X - 1, current.Y, current.Facing);
            }
            throw new Exception("Could not move forwards, invalid facing");
        }
    }
}

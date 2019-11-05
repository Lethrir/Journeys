namespace Journeys.Actions
{
    public class Left : IRobotAction
    {
        public RobotState UpdateState(RobotState current)
        {
            var facing = current.Facing - 90;
            if (facing < 0)
            {
                facing += 360;
            }
            return new RobotState(current.X, current.Y, facing);
        }
    }
}

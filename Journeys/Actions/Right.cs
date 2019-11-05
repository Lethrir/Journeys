namespace Journeys.Actions
{
    public class Right : IRobotAction
    {
        public RobotState UpdateState(RobotState current)
        {
            var facing = current.Facing + 90;
            if (facing == 360)
            {
                facing = 0;
            }
            return new RobotState(current.X, current.Y, facing);
        }
    }
}

namespace Journeys.Actions
{
    public interface IRobotAction
    {
        RobotState UpdateState(RobotState current);
    }
}

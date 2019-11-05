using System.Collections.Generic;

namespace Journeys
{
    public class Journey
    {
        public RobotState InitialState { get; }
        public RobotState FinalState { get; }
        public IEnumerable<RobotAction> Commands { get; }

        public Journey(RobotState initialState, RobotState finalState, IEnumerable<RobotAction> commands)
        {
            InitialState = initialState;
            FinalState = finalState;
            Commands = commands;
        }
    }
}

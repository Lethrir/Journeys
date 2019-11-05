using Journeys.Actions;

namespace Journeys
{
    public class JourneyProcessor
    {
        private readonly ActionFactory _actionFactory = new ActionFactory();

        public bool VerifyJourney(Journey journey)
        {
            var state = journey.InitialState;
            foreach (var command in journey.Commands)
            {
                var action = _actionFactory.BuildAction(command);
                state = action.UpdateState(state);
            }

            return state.Equals(journey.FinalState);
        }
    }
}

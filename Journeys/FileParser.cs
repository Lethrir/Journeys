using System;
using System.Collections.Generic;
using System.IO;

namespace Journeys
{
    public class FileParser
    {
        public IEnumerable<RobotAction> GetActions(string actionsList)
        {
            var actions = new List<RobotAction>();

            foreach (var action in actionsList.ToCharArray())
            {
                actions.Add(Enum.Parse<RobotAction>(action.ToString()));
            }

            return actions;
        }

        public RobotState GetState(string stateLine)
        {
            var parts = stateLine.Split(' ');
            if (parts.Length != 3)
            {
                throw new Exception("Invalid position");
            }
            return new RobotState(
                int.Parse(parts[0]),
                int.Parse(parts[1]),
                Enum.Parse<Facing>(parts[2]));
        }

        public Journey[] GetJourneysFromFile(string path)
        {
            var journeys = new List<Journey>();
            var file = File.OpenText(path);
            string line;
            do
            {
                line = file.ReadLine();
                var startState = GetState(line);
                line = file.ReadLine();
                var commands = GetActions(line);
                line = file.ReadLine();
                var endState = GetState(line);
                journeys.Add(new Journey(startState, endState, commands));

                line = file.ReadLine();
            } while (line != null);

            return journeys.ToArray();
        }
    }
}

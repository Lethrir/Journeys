using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Journeys.Tests
{
    [TestClass]
    public class JourneyProcessorTests
    {
        private readonly JourneyProcessor _processor = new JourneyProcessor();

        [TestMethod]
        public void TestJourney1()
        {
            /*
             * 1 1 E
             * RFRFRFRF
             * 1 1 E
             */
            var initialState = new RobotState(1, 1, Facing.E);
            var finalState = new RobotState(1, 1, Facing.E);
            var commands = new List<RobotAction>
            {
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F
            };

            var journey = new Journey(initialState, finalState, commands);

            var result = _processor.VerifyJourney(journey);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestJourney2()
        {
            /*
             * 3 2 N
             * FRRFLLFFRRFLL
             * 3 3 N
             */
            var initialState = new RobotState(3, 2, Facing.N);
            var finalState = new RobotState(3, 3, Facing.N);
            var commands = new List<RobotAction>
            {
                RobotAction.F,
                RobotAction.R,
                RobotAction.R,
                RobotAction.F,
                RobotAction.L,
                RobotAction.L,
                RobotAction.F,
                RobotAction.F,
                RobotAction.R,
                RobotAction.R,
                RobotAction.F,
                RobotAction.L,
                RobotAction.L
            };

            var journey = new Journey(initialState, finalState, commands);

            var result = _processor.VerifyJourney(journey);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestJourney3()
        {
            /*
             * 0 3 W
             * LLFFFLFLFL
             * 2 4 S
             */
            var initialState = new RobotState(0, 3, Facing.W);
            var finalState = new RobotState(2, 4, Facing.S);
            var commands = new List<RobotAction>
            {
                RobotAction.L,
                RobotAction.L,
                RobotAction.F,
                RobotAction.F,
                RobotAction.F,
                RobotAction.L,
                RobotAction.F,
                RobotAction.L,
                RobotAction.F,
                RobotAction.L
            };

            var journey = new Journey(initialState, finalState, commands);

            var result = _processor.VerifyJourney(journey);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestJourneyWrongFacing()
        {
            /*
             * 1 1 E
             * RFRFRFRF
             * 1 1 E
             */
            var initialState = new RobotState(1, 1, Facing.E);
            var finalState = new RobotState(1, 1, Facing.S);
            var commands = new List<RobotAction>
            {
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F
            };

            var journey = new Journey(initialState, finalState, commands);

            var result = _processor.VerifyJourney(journey);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestJourneyWrongX()
        {
            /*
             * 1 1 E
             * RFRFRFRF
             * 1 1 E
             */
            var initialState = new RobotState(1, 1, Facing.E);
            var finalState = new RobotState(2, 1, Facing.E);
            var commands = new List<RobotAction>
            {
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F
            };

            var journey = new Journey(initialState, finalState, commands);

            var result = _processor.VerifyJourney(journey);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestJourneyWrongY()
        {
            /*
             * 1 1 E
             * RFRFRFRF
             * 1 1 E
             */
            var initialState = new RobotState(1, 1, Facing.E);
            var finalState = new RobotState(1, 2, Facing.E);
            var commands = new List<RobotAction>
            {
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F,
                RobotAction.R,
                RobotAction.F
            };

            var journey = new Journey(initialState, finalState, commands);

            var result = _processor.VerifyJourney(journey);

            Assert.IsFalse(result);
        }
    }
}

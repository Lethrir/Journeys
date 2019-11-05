using Journeys.Actions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Journeys.Tests.Actions
{
    [TestClass]
    public class ForwardTests
    {
        [TestMethod]
        public void ForwardFacing0()
        {
            var state = new RobotState(0, 0, 0);
            var forward = new Forward();
            var result = forward.UpdateState(state);
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(1, result.Y);
        }

        [TestMethod]
        public void ForwardFacing90()
        {
            var state = new RobotState(0, 0, 90);
            var forward = new Forward();
            var result = forward.UpdateState(state);
            Assert.AreEqual(1, result.X);
            Assert.AreEqual(0, result.Y);
        }

        [TestMethod]
        public void ForwardFacing180()
        {
            var state = new RobotState(0, 0, 180);
            var forward = new Forward();
            var result = forward.UpdateState(state);
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(-1, result.Y);
        }

        [TestMethod]
        public void ForwardFacing270()
        {
            var state = new RobotState(0, 0, 270);
            var forward = new Forward();
            var result = forward.UpdateState(state);
            Assert.AreEqual(-1, result.X);
            Assert.AreEqual(0, result.Y);
        }
    }
}

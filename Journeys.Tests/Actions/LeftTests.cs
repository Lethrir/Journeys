using Journeys.Actions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Journeys.Tests.Actions
{
    [TestClass]
    public class LeftTests
    {
        [TestMethod]
        public void LeftFrom0()
        {
            var state = new RobotState(0, 0, 0);
            var forward = new Left();
            var result = forward.UpdateState(state);
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
            Assert.AreEqual(270, result.Facing);
        }

        [TestMethod]
        public void LeftFrom180()
        {
            var state = new RobotState(0, 0, 180);
            var forward = new Left();
            var result = forward.UpdateState(state);
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
            Assert.AreEqual(90, result.Facing);
        }
    }
}

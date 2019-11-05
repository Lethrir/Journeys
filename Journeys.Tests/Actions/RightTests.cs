using Journeys.Actions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Journeys.Tests.Actions
{
    [TestClass]
    public class RightTests
    {
        [TestMethod]
        public void RightFrom0()
        {
            var state = new RobotState(0, 0, 0);
            var forward = new Right();
            var result = forward.UpdateState(state);
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
            Assert.AreEqual(90, result.Facing);
        }

        [TestMethod]
        public void RightFrom270()
        {
            var state = new RobotState(0, 0, 270);
            var forward = new Right();
            var result = forward.UpdateState(state);
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
            Assert.AreEqual(0, result.Facing);
        }
    }
}

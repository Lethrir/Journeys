using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Journeys.Tests
{
    [TestClass]
    public class FileParserTests
    {
        [TestMethod]
        public void ParseFile()
        {
            var fileParser = new FileParser();
            var journeys = fileParser.GetJourneysFromFile("journeys.txt");
            Assert.AreEqual(3, journeys.Length);
        }
    }
}

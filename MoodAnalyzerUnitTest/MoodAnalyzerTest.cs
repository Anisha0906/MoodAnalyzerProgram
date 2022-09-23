using MoodAnalyszerProgram;

namespace MoodAnalyzerUnitTest
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]
        public void Sad()
        {
            string expected = "Sad";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am Sad");
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }
    }
}
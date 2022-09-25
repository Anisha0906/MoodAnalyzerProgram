
using MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       public void Sad()
       {
         string expected = "Sad";
         MoodAnalyser1 moodAnalyzer = new MoodAnalyser1("I am Sad");
         Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
       }
        public void Happy()
        {
            string expected = "Happy";
             MoodAnalyser1 moodAnalyzer = new MoodAnalyser1("I am Happy");
             Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }

    }
}
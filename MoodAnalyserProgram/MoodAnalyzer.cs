using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyszerProgram
{
    public class MoodAnalyzer
    {
        private string Message;
        public MoodAnalyzer(string message)
        {
            this.Message = message;
        }
        public string AnalyzeMood()
        {
            if (this.Message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}

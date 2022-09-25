using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser1
    {
        private string Message;
        public MoodAnalyser1(string message)
        {
            this.Message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (this.Message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionsType.NULL_MESSAGE, "Message should not be Null");
            }
        }
    }
            
    }


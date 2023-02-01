
using System.Data.Common;

namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            //Get length
            List<int> sentenceLength = new List<int>();

            //Split setence on dot
            string[] dot = s.Split('.');
         
            for (int i = 0; i < dot.Length; i++)
            {
                //Split setence if contains ?
                if (dot[i].Contains("?"))
                {
                    string[] q = s.Split('?');
                    for (int qu = 0; qu < q.Length; qu++)
                    {
                        string[] words = dot[qu].Split(' ');
                        sentenceLength.Add(words.Length);
                    }
                }
                //Split setence if contains !
                else if (dot[i].Contains("!"))
                {
                    string[] ex = s.Split('!');
                    for (int e = 0; e < ex.Length;e++)
                    {
                        string[] words = dot[e].Split(' ');
                        sentenceLength.Add(words.Length);
                    }
                }
                else
                {
                    string[] words = dot[i].Split(' ');
                    sentenceLength.Add(words.Length);
                }
            }


            return sentenceLength.Max();
        }
    }
}





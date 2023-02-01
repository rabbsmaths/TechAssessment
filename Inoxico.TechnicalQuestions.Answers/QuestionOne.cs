
using System;
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
                //Split setence if contains ? then split words
                if (dot[i].Contains("?"))
                {
                    string[] q = s.Split('?');
                    for (int qu = 0; qu < q.Length; qu++)
                    {
                        string[] words = dot[qu].Split(' ');

                        //Check if word is valid word else remove
                        for(int wd = 0; wd < words.Length; wd++)
                        {
                            if (!words[wd].All(Char.IsLetter))
                            {
                                List<string> pos = new List<string>(words);
                                pos.RemoveAt(wd);
                                words = pos.ToArray();
                            }
                        }
                        sentenceLength.Add(words.Length);
                    }
                }
                //Split setence if contains ! then split words
                else if (dot[i].Contains("!"))
                {
                    string[] ex = s.Split('!');
                    for (int e = 0; e < ex.Length;e++)
                    {
                        string[] words = dot[e].Split(' ');
                        //Check if word is valid word else remove
                        for (int wd = 0; wd < words.Length; wd++)
                        {
                            if (!words[wd].All(Char.IsLetter))
                            {
                                List<string> pos = new List<string>(words);
                                pos.RemoveAt(wd);
                                words = pos.ToArray();
                            }
                        }
                        sentenceLength.Add(words.Length);
                    }
                }
                else
                {
                    //then split words
                    string[] words = dot[i].Split(' ');
                    //Check if word is valid word else remove
                    for (int wd = 0; wd < words.Length; wd++)
                    {
                        if (!words[wd].All(Char.IsLetter))
                        {
                            List<string> pos = new List<string>(words);
                            pos.RemoveAt(wd);
                            words = pos.ToArray();
                        }
                    }
                    sentenceLength.Add(words.Length);
                }
            }


            return sentenceLength.Max();
        }
    }
}





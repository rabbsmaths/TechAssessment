
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            //Declare variable
            int pitdepth = 0;
            int p, q, r;

            for(int i  = 0; i < points.Length; i++)
            {
                p = i;
                q = i + 1;
                r = i + 2;

                //Check depth condition and return pitdepth
                if (r <= points.Length)
                {
                    if ((points[p] >= 0) && (points[p] > points[q]) && (points[q] < points[r]))
                    {
                        pitdepth = Math.Min(points[p] - points[q], points[r] - points[q]);
                    }
                }
            }

            return pitdepth;
        }
    }
}

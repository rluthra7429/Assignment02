using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
  public static class TriangleSolver
  {
    public  static string Analyze(int s1, int s2, int s3)
    {
            int a = s1+s2, b = s2+s3, c = s3+s1;

            if ((a > s3) && (b > s1) && (c > s2))
            {
                Console.WriteLine("Trinagle is Posssible. Press Enter to Reveal");
                Console.ReadLine();
                if (s1 > 0 && s2 > 0 && s3 > 0)
                {
                    if (s1 == s2 && s2 == s3 && s3 == s1)
                        return "It's Equilateral";

                    if ((s1 == s2 && s2 != s3 && s3 != s1) || (s1 != s2 && s2 == s3 && s3 != s1) || (s1 != s2 && s2 != s3 && s3 == s1))
                        return "It's Isosceles";

                    if (s1 != s2 && s2 != s3 && s3 != s1)
                        return "It's Scalene";

                }
            }
            else
            {
                return "Trinagle is Not Posssible";
            }

            

            return "";
          
        }
  }
}

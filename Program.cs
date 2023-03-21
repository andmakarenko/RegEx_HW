using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RegEx_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            string text = "soidflk jl sldfk_j@f_il.uaj fl @f";
            Regex regex = new Regex(@"[\d\w_]{1,20}\@[\d\w_]{1,20}\.\w{2,20}");
            
            Match match = regex.Match(text);
            
            if (match.Success)
                Console.WriteLine("index:" + match.Index + ", " + match.Value);
            
            
            #endregion



            #region 2
            string text1 = "243433:25:43";
            
            Regex regex1 = new Regex(@"([0-1][0-9]|2[0-3])\:([0-5][0-9])\:([0-5][0-9])");
            Match match1 = regex1.Match(text1);
            
            if (match1.Success)
                Console.WriteLine("index:" + match1.Index + ", " + match1.Value);
            
            #endregion

            #region 3

            string text2 = "02.05.2026 lfkjoei 43.12.1895, 03.12.3456";

            Regex regex2 = new Regex(@"(0[1-9]|[1-2][0-9]|3[0-1])\.(0[1-9]|1[0-2])\.\d*");
            MatchCollection match2 = regex2.Matches(text2);

            DateTime date;


            foreach (var elem in match2)
            {
                if (DateTime.TryParse(elem.ToString(), out date))
                {
                    Console.WriteLine(elem.ToString());
                }
            }
            #endregion

            Console.Read();

        }
    }
}

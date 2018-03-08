using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataTypes01
{
    class DataTypes04
    {
        static void Main(string[] args)
        {
            #region Variables
            //int I;
            //I = 5;
            //DateTime dt = DateTime.Now;
            //DateTime dFuture = dt.AddDays(I);
            //int J = I * 5;
            //string S = "This is a string";
            //// Next 2 lines are the same but with a different method of notation
            //J = J + 6;
            //J += 6;
            //J++;      // ++ means +1
            //Console.WriteLine(I);
            //Console.WriteLine(J);
            //Console.WriteLine(S);
            //Console.WriteLine(dFuture);
            #endregion

            #region Casting
            //int I = 10;
            //long J = I * 10;
            //I = (int)J;
            //string sDate = "01/01/2015";
            //DateTime dt = DateTime.Parse(sDate);
            //string result = dt.ToString();

            //Console.WriteLine(dt);
            //Console.WriteLine(result);
            #endregion

            #region Manipulate Strings
            //string data; // = "This is a string.";
            ////data =  data + "\n\rThis is more data.";
            ////data += "\nHere is another block \\...";

            //StringBuilder sb = new StringBuilder();
            //sb.Append("This is a string.\n");
            //sb.Append("This is more data.\n\r");
            //sb.Append("\tThis is more...");
            //data = sb.ToString();
            //string formatted = string.Format("Demo: {0} \n {1}", dt, data);
            ////Console.WriteLine(formatted);

            //string testText = "Hell0 W0rld";
            //string re = "\\d";
            //var r = Regex.Match(testText, re, RegexOptions.None);
            //if (r.Success)
            //{
            //    Console.WriteLine("Match");
            //}
            #endregion

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            //if(value == 10)
            //{
            //    Console.WriteLine("Your value is 10");
            //}
            //else if (value > 10)
            //{
            //    Console.WriteLine("Your value is BIG");
            //}
            //else
            //{
            //    Console.WriteLine("Your value is small");
            //}

            switch (value)
            {
                case 0:
                    Console.WriteLine("You entered zero");
                    break;
                case 10:
                    Console.WriteLine("You entered ten");
                    break;
                default:
                    Console.WriteLine("You entered {0}", value);
                    break;
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

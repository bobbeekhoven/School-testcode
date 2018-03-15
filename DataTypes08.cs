using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using DataTypes01.Demos;

namespace DataTypes01
{
    class DataTypes08
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

            #region Logical
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

            //switch (value)
            //{
            //    case 0:
            //        Console.WriteLine("You entered zero");
            //        break;
            //    case 10:
            //        Console.WriteLine("You entered ten");
            //        break;
            //    default:
            //        Console.WriteLine("You entered {0}", value);
            //        break;
            //}
            #endregion

            #region Looping
            //while (value !=  10)
            //{
            //    Console.WriteLine("Guess again");
            //    input = Console.ReadLine();
            //    value = int.Parse(input);
            //}

            //for(int lcv=0;lcv<101;lcv++)
            //{
            //    if (lcv == value)
            //    {
            //        Console.WriteLine("{0} is the value", lcv);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is not the value", lcv);
            //    }
            //}
            #endregion

            #region Arrays
            //string[] names = new string[5];
            //names[0] = "Bob";
            //names[1] = "Sue";
            //names[2] = "Ashley";
            //names[3] = "Ben";
            //names[4] = "Linda";

            //string[,] locations = new string[2, 2];
            //locations[0, 0] = "Eastern Europe";
            //locations[0, 1] = "Western Europe";
            //locations[1, 0] = "North America";
            //locations[1, 1] = "South America";

            //string[][] companies = new string[2][];
            //companies[0] = new string[3];
            //companies[1] = new string[2];
            //companies[0][0] = "Bob";
            //companies[0][1] = "Sue";
            //companies[0][2] = "Linda";
            //companies[1][0] = "Ashley";
            //companies[1][1] = "Ben";

            //string[] employees = { "Bob", "Sue", "Linda", "Ashley", "Ben" };

            //Console.WriteLine(employees[0]);
            //Console.WriteLine(companies[1][0]);

            //for (int lcv = 0; lcv < companies[0].Length; lcv++)
            //{
            //    Console.WriteLine(companies[0][lcv]);
            //}

            //foreach (string emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region NameSpaces
            //bool fileExists = System.IO.File.Exists(@"c:\test.text");

            //DemoClass dc = new DemoClass();
            //Console.WriteLine(dc.Greeting());
            #endregion

            int intA = 5;
            if ((intA > 0) || (intA == 0))
            {
                intA++;
            }
            else if (intA == 5)
            {
                intA--;
            }
            Console.WriteLine(intA.ToString());

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

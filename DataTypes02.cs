using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes01
{
    class DataTypes02
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

            int I = 10;
            long J = I * 10;
            I = (int)J;
            string sDate = "01/01/2015";
            DateTime dt = DateTime.Parse(sDate);
            string result = dt.ToString();

            Console.WriteLine(dt);
            Console.WriteLine(result);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

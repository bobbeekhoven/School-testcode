using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReference
{
    class ValueReference
    {
        static void Main(string[] args)
        {
            SimpleClass c1 = new SimpleClass() { Payload = "Class 1" };
            SimpleStruct s1 = new SimpleStruct() { Payload = "Struct 1" };
            SimpleClass c2 = c1;
            SimpleStruct s2 = s1;
            c2.Payload = "Second Class";
            s2.Payload = "Second Struct";
            Console.Write("Structures\n\t{0}\n\t{1}\nClasses\n\t{2}\n\t{3}", s1.Payload, s2.Payload, c1.Payload, c2.Payload);
            Console.ReadLine();
        }
    }
    public class SimpleClass
    {
        public string Payload { get; set; }
    }
    public struct SimpleStruct
    {
        public string Payload { get; set; }
    }
}

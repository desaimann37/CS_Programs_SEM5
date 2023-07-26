using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02_3;

namespace Kite
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers For Add/Sub : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = Sum.addition(a, b);
            int sub = Sub.subtraction(a, b);
            Console.WriteLine($"Addition of {a} + {b} is : {sum}");
            Console.WriteLine($"Addition of {a} - {b} is : {sub}");
            Console.ReadLine();
        }
    }
}

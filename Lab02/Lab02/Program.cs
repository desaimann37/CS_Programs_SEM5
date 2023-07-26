using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02;

namespace Kite
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers To Sum Them up : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int ans = Sum.Add(a, b);
            Console.WriteLine($"Sum of {a} + {b} is : {ans}");
            Console.ReadLine();
        }
    }
}

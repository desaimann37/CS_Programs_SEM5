using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab03_2;

namespace Kite2
{
    public class Runner1
    {
        public static void Main(string[] args)
        {
            int a = Add1.Addition(10, 30);
            int b = Sub1.Subtraction(20, 30);
            Console.WriteLine($"{a} \n {b}");
            Console.ReadLine();

        }
    }
}

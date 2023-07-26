using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab03_3;

namespace kite3
{
    public class Running2
    {
        public static void Main(string[] args)
        {
            int a = Add2.Addition(10, 30);
            int b = Sub2.Subtraction(20, 40);
            Console.WriteLine($"{a} \n {b}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab03;

namespace Kite
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            int r = Add.Addition(10, 7);
            int l = Sub.Subtraction(6, 4);
            Console.WriteLine($"{r} \n {l}");
            Console.ReadLine();
        }
    }
}

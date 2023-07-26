using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02_2;

namespace Kite
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Press 0 for Addition...");
            Console.WriteLine($"Press 1 for Subtraction...");
            Console.WriteLine($"Press 2 for Multiplication...");
            Console.WriteLine($"Press 3 for Division...");
            Console.WriteLine("Enter Operation You Wanted to perform According to Given Operators Choose One : ");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Two Numbers for Operation: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Calc calculator = new Calc();
            switch (op)
            {
                case 0:
                    int add = calculator.Add(a, b);
                    Console.WriteLine($"Addition of {a} + {b} is {add}");
                    break;
                case 1:
                    int sub = calculator.Sub(a, b);
                    Console.WriteLine($"Subtraction of {a} - {b} is {sub}");
                    break;
                case 2:
                    int mul = calculator.Mul(a, b);
                    Console.WriteLine($"Multiplication of {a} * {b} is {mul}");
                    break;
                case 3:
                    double div = calculator.Div(a, b);
                    Console.WriteLine($"Division of {a} / {b} is {div}");
                    break;
                default:
                    Console.WriteLine("Enter from 0-3 numbers Try Again!! ");
                    break;

            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public int Add(int x , int y)
        {
            return x + y;
        }
        public int Sub(int x , int y)
        {
            return x - y;
        }
        public int Mul(int x , int y)
        {
            return x * y;
        }
        public double Div(int x , int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Addition");
            Console.WriteLine("Press 2 For Subtraction");
            Console.WriteLine("Press 3 For Multiplication");
            Console.WriteLine("Press 4 For Division");
            Program p3 = new Program();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Operand : ");
            int op1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Operand : ");
            int op2 = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    int ans1 = p3.Add(op1 , op2);
                    Console.WriteLine("Result After Addition of {0} + {1} is : {2}", op1 , op2 , ans1);
                    break;
                case 2:
                    int ans2 = p3.Sub(op1, op2);
                    Console.WriteLine("Result After Subtraction of {0} - {1} is : {2}", op1, op2, ans2);
                    break;
                case 3:
                    int ans3 = p3.Mul(op1, op2);
                    Console.WriteLine("Result After Multiplication of {0} * {1} is : {2}", op1, op2, ans3);
                    break;
                case 4:
                    double ans4 = p3.Div(op1, op2);
                    Console.WriteLine("Result After Division of {0} / {1} is : {2}", op1, op2, ans4);
                    break;
                default:
                    Console.WriteLine("Enter Something Else ...");
                    break;
            }


        }
    }
}

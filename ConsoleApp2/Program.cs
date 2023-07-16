using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public bool isPrime(int num)
        {
            for(int i=2; i<num/2; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Check For Prime Or Not : ");
            int num = int.Parse(Console.ReadLine());
            Program p2 = new Program();
            bool flag = p2.isPrime(num);
            if (flag)
            {
                Console.WriteLine("{0} Number is Prime Number" , num);
            }
            else
            {
                Console.WriteLine("{0} Number is Not Prime Number", num);
            }

        }
    }
}

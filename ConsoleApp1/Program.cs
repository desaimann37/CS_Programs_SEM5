using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Author : Mann Desai
    Objective : Check for Palindromic Number 
*/
namespace ConsoleApp1
{
    internal class Program
    {
        public bool IsPalindrome(String num)
        {
            
            int i = 0;
            int j = num.Length - 1;
            while (i <= j)
            {
                if (num[i] != num[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something to Check that is it palindrome? : ");
            String num = Console.ReadLine();
            Program p = new Program();
            bool flag = p.IsPalindrome(num);
            if (flag == true)
            {
                Console.WriteLine("{0} is Palindrome" , num);
            }
            else
            {
                Console.WriteLine("{0} is not Palindrome", num);
            }
       
        }
    }
}

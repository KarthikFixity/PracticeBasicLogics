using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasicLogics
{
    internal class Swapping
    {
        public static void swapingoftwonumbersusingthirdvarible()
        {
            int number1 = 20, number2 = 40, temp = 0;
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"number1 ={number1} number2 ={number2}");
        }
        public static void reverse()
        {
            var sum=0;
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                var r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if(sum == temp)
            {
                Console.WriteLine("it is palindrome");

            }
            else
            {
                Console.WriteLine("it is not palindrome");
            }
        }
        public static void amstrong()
        {
            Console.WriteLine("enter amstrong num");
            int num = int.Parse(Console.ReadLine());
           int temp = num;
            var sum = 0;
            while (num > 0)
            {
                int r=num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if(sum == temp)
            {
                Console.WriteLine("it is a amstrong");
            }
            else
            {
                Console.WriteLine("it is not amstrong");
            }
            
        }
        
    }
}

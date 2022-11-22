using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasicLogics
{
    internal class CSharpBasics
    {
        public static void Fabnocci()
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine("enter A number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");
            for (int i = 3; i <= number; i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
        public static void PrimeNumber()
        {
            Console.WriteLine("enter A number");
            int number = int.Parse(Console.ReadLine());

            int m = number / 2;
            var flag = 0;

            // int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("not a prime number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("prime number");
            }
        }
        public static void sumoftwodigits()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, reminder;
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            Console.WriteLine($"sum of the digits:{sum}");
            Console.ReadKey();

        }
        public static void palindrome()
        {
            int n, reminder, sum = 0;
            Console.WriteLine("enter  a  number");
            int number = int.Parse(Console.ReadLine());
            var flag = 1;
            while (number > 0)
            {
                reminder = number % 10;
                sum = (sum * 10) + reminder;
                n = number / 10;
                if (flag == 0)
                {
                    Console.WriteLine("palindrome");
                }
                else
                {
                    Console.WriteLine("not a palindrome");

                }

            }
        }
        public static void swapping()
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
            Console.ReadKey();
        }
        public static void array()
        {
            int[] arr = { 100, 99, 40, 50, 60, 20};
            int i, max, min, n;
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("max value={0}", max);
            Console.WriteLine("min value={0}", min);
        }
    }
}

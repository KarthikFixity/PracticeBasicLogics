using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasicLogics
{
    internal class Class1
    {
        public static void Swapping()
        {
            int number1 = 20, number2 = 40, temp = 0;
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write($"number1={number1},number={number2}");
        }
        public static void Febnccoi()
        {
            int n1 = 0, n2 = 1;
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");
            for (int i = 3; i <= n; i++)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.WriteLine(n3 + " ");
            }
        }
        public static void sumofdigits()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, temp, rem;
            for (int i = 0; i < n; i++)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
        public static void Buzznum()
        {
            Console.WriteLine("enter a num");
            int n = int.Parse(Console.ReadLine());
            if (n % 10 == 7 || n % 7 == 0)
            {
                Console.WriteLine("it is a Buzz num:" + n);
            }
            else
            {
                Console.WriteLine("it is not a Buzz num:" + n);
            }
        }
        public static void DuckNumber()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, temp, a = 0;
            temp = n;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    a = 1;
                    break;

                }
                n = n / 10;
            }
            if (temp > 0 && a == 1)
            {
                Console.WriteLine("it is a Ducknum:" + temp);
            }
            else
            {
                Console.WriteLine("it is a not Ducknum:" + temp);
            }

        }
        public static void angleofhours()
        {
            Console.WriteLine("Enter a hours");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a minute");
            int m = int.Parse(Console.ReadLine());
            Double hd = (h * 30) + (m * 30.0 / 60);
            double md = (m * 6);
            double diff = Math.Abs(hd - md);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine(diff);
        }
        public static void deseriumnum()
        {
            Console.WriteLine("enter a num ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, t = n, rem;
            string s = n.ToString();
            int l = s.Length;
            while (t > 0)
            {
                rem = t % 10;
                sum = sum + (int)Math.Pow(rem, l);
                l--;
                t = t / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("it is a deserium num");
            }
            else
            {
                Console.WriteLine("it is not a  deserium num");

            }
        }
        public static void palindroome()
        {
            Console.WriteLine("Enter a nUm");
            int n = int.Parse(Console.ReadLine());

            int sum = 0, temp, rem;
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("It is a pLaindrome:" + temp);
            }
            else
            {
                Console.WriteLine("It is not a pLaindrome:" + temp);

            }



        }
        public static void Amstrong()
        {
            Console.WriteLine("Enter A NUM");
            int n = int.Parse(Console.ReadLine());
            int temp, sum = 0, rem;
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;

            }
            if (sum == temp)
            {
                Console.WriteLine("it is a amstrong");
            }
            else
            {
                Console.WriteLine("it is not a amstrong");

            }

        }
        public static void brinarytodecimal()
        {
            Console.WriteLine("enter a brinary num");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, temp, rem, Base = 1;
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem * Base;
                n = n / 10;
                Base = Base * 2;
            }
            Console.WriteLine("it is a decimal number is:" + sum);
        }
        public static void Reversesting()
        {
            Console.WriteLine("enter a string");
            string s = string.Empty;
            string r = string.Empty;
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r = r + s[i];
            }
            Console.WriteLine("reverse string is:" + r);
        }
        public static void leftRotation()
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("given number is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();
            int temp;

            for (int j = 0; j < n - 1; j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;

            }
            Console.WriteLine("Left rotation is:");
            foreach (int i in a)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
        public static void rightrotation()
        {
            Console.Write("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Given number is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n - 1; j++)
            {
                temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("right rotation is:");
            foreach (int i in a)
            {
                Console.WriteLine(i + " ");

            }

        }
        public static void reversewords()
        {
            string str = Console.ReadLine();
            string temp2 = " ";
            foreach (string word in str.Split(' '))
            {
                string temp = " ";
                for (int j = 0; j < word.Length; j++)
                {
                    temp = word[j] + temp;

                }
                temp2 = temp + temp2;

            }
            Console.WriteLine(temp2);
        }
        public static void removeduplicates()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            string r = String.Empty;
            string str = n.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (!r.Contains(str[i]))
                {
                    r = r + str[i];
                }

            }
            Console.WriteLine(r);
        }
        public static void removestring()
        {
            Console.WriteLine("enter a string");
            string s = string.Empty;
            string r = String.Empty;
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (!r.Contains(s[i]))
                {
                    r = r + s[i];
                }
            }
            Console.WriteLine(r);
        }
        public static void substring()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    Console.WriteLine(s.Substring(i, j + 1));
                }
            }
        }
        public static void primenum()
        {
            Console.WriteLine("Enter A  Number");
            int n = int.Parse(Console.ReadLine());
            int m = n / 2;
            int temp = 0;
            for (int i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    temp = 1;
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("it is a prime");
            }
            else
            {
                Console.WriteLine("it is not a prime");

            }
        }
        public static void twistedprime()
        {
            Console.WriteLine("Enter a num");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, a;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            a = 0;
            for (int i = 2; i < sum / 2; i++)
            {
                if (sum % i == 0)
                {
                    a = 1;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("it is twisted ");
            }
            else
            {
                Console.WriteLine("it is npt twisted ");

            }
        }
        public static void kraperkernum()
        {
            Console.WriteLine("num");
            int n = int.Parse(Console.ReadLine());
            int temp, sum = 0, sq, d = 0;
            sq = n * n;
            temp = sq;
            while (sq > 0)
            {
                d++;
                sq = sq / 10;

            }
            int k = (int)Math.Pow(10, (d / 2));
            while (temp > 0)
            {
                sum = sum + (temp % k);
                temp = temp / k;
            }
            if (sum == n)
            {
                Console.WriteLine("it is a kapreker num");
            }
            else
            {
                Console.WriteLine("it is anot a kapreker num");

            }
        }
        public static void strongnum()
        {
            Console.WriteLine("enter a num");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, fact, rem, temp;
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                fact = 1;

                for (int i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("wrong");

            }


        }
        public static void cahrocc()
        {
            int c, i;
            string s = Console.ReadLine();
            while (s.Length > 0)
            {
                Console.WriteLine(s[0] + " ");
                c = 0;

                for (i = 0; i < s.Length; i++)
                {
                    if (s[0] == s[i])
                    {
                        c++;
                    }

                }

                Console.WriteLine(c);
                s = s.Replace(s[0].ToString(), String.Empty);
            }
        }
        public static void decimaltobrinary()
        {
            Console.WriteLine("enter a NUM");
            int n=int.Parse(Console.ReadLine());
            int[] a=new int[10];
            for(int i = 0; i > n; i++)
            {
                a[i] = n % 2;
                n=n/ 2;
                for(i=i-1; i>=0; i--)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
            public static void areaofsqure()
            {
                Console.WriteLine("enter a num");
                int s = int.Parse(Console.ReadLine());
                int a = s * s;
                Console.WriteLine("squre is: " + a);


            }
            public static void areaoftringle()
            {
                Console.Write("Enter Height: ");
                int h = int.Parse(Console.ReadLine());
                Console.Write("Enter Base : ");
                int b = int.Parse(Console.ReadLine());
                int a = (1 / 2) * b * h;
                Console.WriteLine("Area of Traingle : " + a);
            }


        }

    }

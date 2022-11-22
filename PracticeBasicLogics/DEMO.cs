using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasicLogics
{
    internal class DEMO
    {
        public static void palindrome()
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            var temp = n;
            int sum = 0, r;

            while (temp > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                temp = n / 10;
                if (sum == 0)
                {
                    Console.WriteLine("it is a palindrome");
                }
                else
                {
                    Console.WriteLine("it is not a palindrome");
                }
            }
            Console.WriteLine(sum);

        }
        public static void DecimaltoBrinary()
        {
            int i;
            Console.WriteLine("Enter decimal number");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[10];

            for (i = 0; n > 0; i++)
            {
                arr[i] = n % 2;
                n = n / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }


        }
        public static void BrinarytoDecimal()
        {
            Console.WriteLine("enter brinary num");
            int number = int.Parse(Console.ReadLine());
            int reminder, sum = 0, Base = 1;
            for (int i = 0; number > 0; i++)
            {
                reminder = number % 10;
                sum = sum + reminder * Base;
                number /= 10;
                Base = Base * 2;

            }
            Console.WriteLine($"decimal number is:{sum}");
        }
        public static void revese()
        {

            string s = string.Empty;
            string r = string.Empty;
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r = r + s[i];
            }
            Console.WriteLine(r);
        }
        public static void charocc()
        {
            Console.Write("enter a string : ");
            string s = Console.ReadLine();
            while (s.Length > 0)
            {
                Console.Write(s[0] + "=");
                int c = 0;

                for (int i = 0; i < s.Length; i++)
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
        public static void sum()
        {
            int sum = 0, reminder;
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
        public static void occurenace()
        {
            int c, i;
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            while (s.Length > 0)
            {
                Console.Write(s[0] + "=");
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
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not a prime number");
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
            int[] arr = { 100, 99, 40, 50, 60, 20 };
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
        //--------15-Nov-2022---------\\
        public static void Dupilicate()
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            string r = string.Empty;
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
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder n = new StringBuilder();

                for (int j = i; j < s.Length; j++)
                {
                    n.Append(s[j]);
                    Console.WriteLine(n + "");
                }
            }
        }
        public static void strreverse()
        {
            Console.WriteLine("Enter the number of strings");
            int n;
            n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            foreach (string s in str)
            {
                char[] chars = s.ToCharArray();
                Console.WriteLine(s + " Reverse is:" + "----");
                for (int i = chars.Length - 1; i >= 0; i--)
                {
                    Console.Write(chars[i]);

                }
                Console.WriteLine();
            }
        }
        public static void oneTotwo()
        {
            Console.Write("Enter no of rows");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter no of rows");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[,] b = new int[n, m];
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < m; h++)
                {
                    Console.Write("Enter values [{0}][{1}] : ", g, h);
                    b[g, h] = int.Parse(Console.ReadLine());
                }
            }
            int i, j, k = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    k = i * m + j;
                    a[k] = b[i, j];
                    k++;
                }
            }

            // displaying elements in 1-d array
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write((a[i * m + j]) + " ");
            }
        }
        public static void TwoToOne()
        {

            Console.WriteLine("enter num of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num of column");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Two dimensional array ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int x = m * n;
            int[] a = new int[x];
            int k, l, z = 0;
            for (k = 0; k < n; k++)
            {
                for (l = 0; l < n; l++)
                {
                    z = k * n + l;
                    a[z] = arr[k, l];
                    z++;
                }
            }
            Console.WriteLine("one dimensional array ");
            for (k = 0; k < n; k++)
            {
                for (l = 0; l < n; l++)
                {
                    Console.Write(a[k * n + l] + " ");
                }
            }
            Console.WriteLine();

        }
        //-------16-Nov-2022----------\\
        public static void DuckNumber()
        {
            Console.Write("Enter a Number :");
            int n = int.Parse(Console.ReadLine());
            int temp, a = 0;
            temp = n;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    a = 1;
                    break;
                }
                n /= 10;
            }
            if (temp > 0 && a == 1)
            {
                Console.WriteLine("Given Number is a Duck Number :" + temp);
            }
            else
            {
                Console.WriteLine("Given Number is not a Duck Number:" + temp);
            }
        }
        public static void AngleOfHours()
        {
            Console.WriteLine("enter a hours");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a minutes");
            int m = int.Parse(Console.ReadLine());
            double hd = (h * 30) + (m * 30.0 / 60);
            double md = (m * 6);
            double diff = Math.Abs(hd - md);
            if (diff > 180)
            {
                diff = 360 - diff;

            }
            Console.WriteLine("angle of degree:" + diff);


        }
        public static void RightRotation()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n - 1; j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Right circular rotation   ---   ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void RDEIA1()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[50];
            int i, j;
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array elements");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(" After removing duplicates ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    if (a[j] == a[i])
                        break;
                }

                if (n == j)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }

        //------17-Nov-2022-----\\
        public static void Buzznumber()
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            if (n % 10 == 7 || n % 7 == 0)
            {
                Console.WriteLine("it is a Buzz number:" + n);
            }
            else
            {
                Console.WriteLine("it is not a Buzz number:" + n);

            }

        }
        public static void StrongNumber()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, f, temp;
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                f = 1;
                for (int i = 1; i <= rem; i++)
                {
                    f *= i;
                }
                sum += f;
                n /= 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Strong number");
            }
            else
            {
                Console.WriteLine("Not Strong number");
            }
        }
        public static void TwistedPrime()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, a;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n /= 10;
            }
            a = 0;
            for (int i = 2; i <= sum / 2; i++)
            {
                if (sum % i == 0)
                {
                    a = 1;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Twisted Prime Number");
            }
            else
            {
                Console.WriteLine("Not Twisted Prime Number");
            }
        }
        public static void prime()
        {
            Console.WriteLine("enter a number");
            int n= int.Parse(Console.ReadLine());
            int rem,a=0,sum=0;
            while (n > 0)
            {
                rem= n % 10;
                sum= sum * 10 + rem;
                n = n / 10;
            }
            
            for(int i = 2; i <= sum / 2; i++)
            {
                if(sum % i == 0)
                a= 1;
                break;
            }
            if(a == 0)
            {
                Console.WriteLine("prime num");
            }
            else
            {
                Console.WriteLine("prime not num");
            }
        }
        public static void desirumnumber()
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, t = n;
            string s = n.ToString();
            int l = s.Length;
            while (t > 0)
            {
                rem = t % 10;
                sum = sum + (int)Math.Pow(rem, l);
                l--;
                t /= 10;
            }
            if (sum == n)
                Console.WriteLine("Disarium Number");
            else
                Console.WriteLine("Not Disarium number");
        }
        public static void KaprekarNumber()
        {
            int n = int.Parse(Console.ReadLine());
            int temp, sum = 0, sq, d = 0;
            sq = n * n;
            temp = sq;
            while (sq > 0)
            {
                d++;
                sq /= 10;
            }
            int k = (int)Math.Pow(10, (d / 2));
            while (temp > 0)
            {
                sum = sum + (temp % k);
                temp = temp / k;
            }
            if (sum == n)
            {
                Console.WriteLine(" Kaprekar Number");
            }
            else
            {
                Console.WriteLine("Not Kaprekar Number");
            }

        }

        //-----18-nov-2022--------\\
        public static void AreaofRectange()
        {
            Console.Write("Enter Length : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter Width : ");
            int w = int.Parse(Console.ReadLine());
            int a = l * w;
            Console.WriteLine("Area of Rectangle : " + a);
        }
        public static void AreaofSquare()
        {
            Console.Write("Enter square : ");
            int s = int.Parse(Console.ReadLine());
            int a = s * s;
            Console.WriteLine("Area of square : " + a);
        }
        public static void AreaofTriangle()
        {
            Console.Write("Enter Height: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Base : ");
            int b = int.Parse(Console.ReadLine());
            int a = (1 / 2) * b * h;
            Console.WriteLine("Area of Traingle : " + a);
        }
        public static void AreaofCircle()
        {
            Console.Write("Enter radius: ");
            int r = int.Parse(Console.ReadLine());
            double a = 3.141 * (r * r);
            Console.WriteLine("Area of Circle : " + a);
        }
        public static void SurfaceAreaofCube()
        {
            Console.Write("Enter side Length of the Cube: ");
            int a = int.Parse(Console.ReadLine());
            double area = 6 * (a * a);
            Console.WriteLine("Surface area of cube : " + area);
        }

    }
}







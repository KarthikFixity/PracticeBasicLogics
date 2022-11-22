using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasicLogics
{
    internal class Pattern1
    {
        public static void pattern()
        {
            for(int i=0; i<5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i <= 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();
            }
        }
        public static void pattern1()
        {
            int num = 6,i,j;

            for( i=1; i <= num; i++)
            {
                for ( j = 1; j <= i;j++)
                {
                    
                        Console.Write("*");
                    
                }
                Console.WriteLine();
            }
           

        }
        public static void pattern2()
        {
           
            for (int i = 6; i >=1; i--)
            {
                for (int j = 1; j >= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

        }
        public static void pattern3()
        {

        }

    }
}

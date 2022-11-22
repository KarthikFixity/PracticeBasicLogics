using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasicLogics
{
    internal class ArrayLogics
    {
        public static void Array()
        {
            int[] intArray = new int[6] { 0,1,2,3,4,5};


            if (intArray.IsFixedSize)
            {


                Console.WriteLine("Array is fixed size");
                Console.WriteLine($"Size : {intArray.Length.ToString()}");
                Console.WriteLine($"Rank : {intArray.Rank.ToString()}");
                 

            }
        }
        public static void Swapping()
        {

            int a = 20;
            int b = 50;
           
            // Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;       
            b = a - b;     
            a = a - b;
          
            Console.Write("After swap a= " + a + " b= " + b);

        }
        public static void swapping()
        {
             
        }
    }
}

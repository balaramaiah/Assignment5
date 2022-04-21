using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class ArrayOperationsOnInt
    {
        public static void Main()
        {
            Console.WriteLine("Enter Array Size:");
            int size=int.Parse(Console.ReadLine());
            int[] intarry = new int[size];
            int[] intarry2 = new int[size];

            Console.WriteLine("Enter Elements to the Array:");

            for (int i=0; i < size;i++)
            {
                intarry[i]= int.Parse( Console.ReadLine());
            }


            Array.Copy(intarry, intarry2, size);

            Console.WriteLine("After Copying :");

            foreach (int b in intarry2)
            {
                Console.WriteLine(b);
                // display sorted array
            }

            //After Sorting

            Array.Sort(intarry);

            Console.WriteLine("After Sorting :");

            foreach (int a in intarry)
            {
                Console.WriteLine(a);
                // display sorted array
            }

            //After clear
            Array.Clear(intarry,2, 2);
           
            Console.WriteLine("After Clear Elements in Arrray :");
            foreach (int a in intarry)
            {
                Console.WriteLine(a);
                // display sorted array
            }

            //After Reversing

            Array.Reverse(intarry);
            Console.WriteLine("After Reversing");
            foreach (int a in intarry)
            {
                Console.WriteLine(a);
                // display sorted array
            }
            
            Console.ReadKey();

        }
    }
}

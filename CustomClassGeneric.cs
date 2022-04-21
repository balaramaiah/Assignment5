using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{

    public class CustomGenericClassMyStack<Int>  //creating custom generic class
    {
       
        static readonly int MAX = 100;  //size of the array
        int top2;                        //integer var to store top position
        int[] str = new int[MAX]; //int array




        public void Push(int data)  //performing push operation
        {
            if (top2 > MAX)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                str[top2++] = data;
            }
        }
        public void Pop()  //performing pop operation
        {
            if (top2 < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                int value = str[top2--];               
                Console.WriteLine("Popped Value: " +value);
            }
        }
    }
    internal class CustomClassGeneric
    {
        static void Main(string[] args)
        {         
            CustomGenericClassMyStack<int> cg = new CustomGenericClassMyStack<int>();
            cg.Push(10);  //adding values to stack
            cg.Push(20);
            //cg.Push(30);
            //cg.Push(40);
            //cg.Push(50);

            cg.Pop();  
            cg.Pop();
            cg.Pop();
            cg.Pop();//Stack Underflow
            Console.ReadKey();
        }
    }
}

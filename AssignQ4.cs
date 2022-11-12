using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment5
{
    class Q4
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(3);
            Data();
            void Data()
            {
                Console.WriteLine("Generic Stack Elements : ");
                foreach (int i in stack)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Press 1 to add an element into stack and 2 to remove an element fron the stack");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j == 1)
            {
                Console.WriteLine("Enter Element into Stack:");
                stack.Push(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("After Adding The Stack Elements are:");

                Data();




            }
            if (j == 2)
            {
                Console.WriteLine("Element Popped successfully");
                stack.Pop();
                Console.WriteLine("Total Number of elements present in Stack after popping was :   {0}", stack.Count);
                Data();
            }
            Console.ReadLine();



        }





    }
}
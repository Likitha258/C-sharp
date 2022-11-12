using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ4
    {
           



       int n1, n2;
        public void Swap()
        {
            Console.WriteLine("enter the number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr the another number");
            n2 = Convert.ToInt32(Console.ReadLine());



        }
        public void swap1()
        {
            Console.WriteLine(" before swapping.");
            Console.WriteLine("n1 =" + " " + n2);
            Console.WriteLine("n2 =" + " " + n1);



            int swapp = n1;
            n1 = n2;
            n2 = swapp;
            Console.WriteLine(" after swapping.");
            Console.WriteLine("n1 =" + " " + n2);
            Console.WriteLine("n2 =" + " " + n1);



        }
        public static void Main()
        {
            AssignQ4 Q = new AssignQ4();
            Q.Swap();
            Q.swap1();
        }
    }
}

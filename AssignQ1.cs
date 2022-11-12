using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
 class AssignQ1
    




    {
        static void Main(string[] args)




        {
            Console.WriteLine("enter a number");
            int X = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("enter another number");
            int Y = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("1.Addition: ");
            Console.WriteLine("2.Substraction: ");
            Console.WriteLine("3.multiplication ");
            Console.WriteLine("4.division ");
            Console.WriteLine("5.modulus: ");



            int A = Convert.ToInt32(Console.ReadLine());
            switch (A)
            {
                case 1:
                    Console.WriteLine("Addition of two numbers :" + (X + Y));
                    break;
                case 2:
                    Console.WriteLine("Substraction of two numbers :" + (X - Y));
                    break;
                case 3:
                    Console.WriteLine("multiplication of two numbers :" + (X * Y));
                    break;
                case 4:
                    Console.WriteLine("division of two numbers :" + (X / Y));
                    break;
                case 5:
                    Console.WriteLine("Modulus of two numbers :" + (X % Y));
                    break;
                default:
                    Console.WriteLine("choose only 1 to 5");
                    break;
            }
            Console.ReadLine();



        }




    }
}

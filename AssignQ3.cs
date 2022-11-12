using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Assignment5
{
    internal class Q3
    {
        public static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();
            //ADDING ELEMENTS TO THE LIST
            list.AddLast("Likhi");
            list.AddLast("tejaswi");
            list.AddLast("leelu");
            list.AddLast("ravali");
            list.AddLast("sidha");
            list.AddLast("Sai");
            list.AddLast("Anu");
            Display();

            void Display()
            {
                //DISPLAYING ALL EMPLOYEES
                Console.WriteLine("Employees present here are :");
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
                // COUNT NUMBER OF EMPLOYEES
                Console.WriteLine("Total Number of Employees : {0}", list.Count);




                Console.WriteLine("Enter 1 to Add New Employee or else 2 or 3 ");
                int Num = Convert.ToInt32(Console.ReadLine());
                if (Num == 1)
                {
                    Add();
                }
                if (Num == 2)
                {
                    Display();
                }
                if (Num == 3)
                {
                    Console.WriteLine("Changes made successfull ------Press any key to exit");
                }
            }



            void Add()
            {



                Console.WriteLine("Enter new employee to add:");
                list.AddLast(Console.ReadLine());
                Console.WriteLine("-----------NEW EMPLOYEE ADDEDD SUCCESSFULY------------");
                Display();
            }





            Console.ReadLine();



        }
    }
}
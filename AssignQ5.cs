using System;
namespace Assignment5
{
    internal class Q5
    {
        public static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();
            //ADDING ELEMENTS TO THE LIST
            list.AddLast("Keerthi");
            list.AddLast("satya");
            list.AddLast("Sandeep");
            list.AddLast("Pravallika");
            list.AddLast("Sakshi");
            list.AddLast("Srinu");
            list.AddLast("Vamsi");
            Display();



            void Display()
            {
                //DISPLAYING ALL EMPLOYEES
                Console.WriteLine("Employees present here are :");
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
                //TO COUNT NUMBER OF EMPLOYEES PRESENT HERE
                Console.WriteLine("Total Number of Employees : {0}", list.Count);




                Console.WriteLine("Enter 1 to Add New Employee or else 2 or 3 to search an element in stack or 4 to exit");
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
                    Console.WriteLine("Enter an employee to search if it present in stack or not :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Is Employee Present : {0}", list.Contains(name));

                }
                if (Num == 4)
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
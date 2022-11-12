using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AssignQ2
    {
        static void Main() {
            int n1, n2, n3, n4, n5, avg;
            Console.WriteLine("enter 5 numbers:");
                n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine()); 
            n4 = Convert.ToInt32(Console.ReadLine());
            n5 = Convert.ToInt32(Console.ReadLine()); 
            avg = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine("Average :" + avg);
            Console.ReadLine(); if ((n1 >= n2) && (n1 >= n3) && (n1 >= n4) && (n1 >= n5)) 
            {
                Console.WriteLine(" The biggest number is:{0}", n1);
                return; 
            }
            if ((n2 >= n1) && (n2 >= n3) && (n2 >= n4) && (n2 >= n5))
            {
                Console.WriteLine(" The biggest number is:{0}", n2); 
                return; 
            }
            if ((n3 >= n1) && (n3 >= n2) && (n3 >= n4) && (n3 >= n5))
            {
                Console.WriteLine(" The biggest number is:{0}", n3);
                return; 
            }
            if ((n4 >= n1) && (n4 >= n2) && (n4 >= n3) && (n4 >= n5)) 
            {
                Console.WriteLine(" The biggest number is:{0}", n4); 
                return; 
            }
            if ((n4 >= n1) && (n4 >= n2) && (n4 >= n3) && (n5 >= n4)) 
            {
                Console.WriteLine(" The biggest number is:{0}", n5);
                return;
            }
        }
    }

   
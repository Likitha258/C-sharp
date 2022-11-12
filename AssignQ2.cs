using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace Assignment5
{
    public class Student
    {
        public string name;
        public int id;
        public int rollNum;



        public Student(string name, int id, int rollNo)
        {
            this.name = name;
            this.id = id;
            this.rollNum = rollNo;




            Console.WriteLine("Student Name : {0}", name);
            Console.WriteLine("Student Id : {0}", id);
            Console.WriteLine("Student Roll number : {0}", rollNo);
        }
    }



    public class AddingData
    {

        public void StudentData()
        {
            Student s1 = new Student("Likhitha", 1234, 04);
            Student s2 = new Student("Keerthy", 4321, 20);
            Student s3 = new Student("vesa", 1212, 02);



            ArrayList StudentList = new ArrayList();



            StudentList.Add(s1);
            StudentList.Add(s2);
            StudentList.Add(s3);





        }
    }
    public class RetriveData
    {
        public static void Main()
        {
            AddingData data = new AddingData();
            data.StudentData();



            Console.ReadKey();
        }

    }

}
using System;

namespace Program_1
{
    public class Student{
            public string StudentName { get ; set ;}
    }
    class Program
    {
        static void ChangeReFerenceType(Student std2){
            std2.StudentName = "Steve";
        }
        static void Main(string[] args)
        {
            Student std1 =  new Student();
            std1.StudentName = "Bill";
            ChangeReFerenceType(std1);
            System.Console.WriteLine(std1.StudentName);

        }


    }
}

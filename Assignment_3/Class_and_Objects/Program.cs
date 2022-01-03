using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Student = new Student_detail("Kajal","GGHSS",5,53,99,99,99,100,100);
            Student.Display(Student);
            Student.TotalScore(Student);
           
        }
        
    }
}

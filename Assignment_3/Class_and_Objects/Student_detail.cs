using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Student_detail
    {
        private object grade;

        public string Name { get; set; }
        public string School { get; set; }
        public int Class { get; set; }
        public int Roll_no { get; set; }
        public double Marks1 { get; set; }
        public double Marks2 { get; set; }
        public double Marks3 { get; set; }
        public double Marks4 { get; set; }
        public double Marks5 { get; set; }
        public double Total { get; set; }


        public Student_detail(string name, string school, int currentlass, int roll_no, double mark1, double mark2, double mark3, double mark4, double mark5)
        {
            Name = name;
            Marks1 = mark1;
            Marks2 = mark2;
            Marks3 = mark3;
            Marks4 = mark4;
            Marks5 = mark5;
            Roll_no = roll_no;
            School = school;
            Class = currentlass;

        }

        public void Display(Student_detail Student)
        {
            double[] marks = { Student.Marks1, Student.Marks2, Student.Marks3, Student.Marks4, Student.Marks5 };
            List<string> grade = new List<string>();

            foreach (var values in marks)
            {
                if (values > 90)
                {
                    grade.Add("A+");
                }
                else if (values <= 90 && values > 80)
                {
                    grade.Add("A");
                }
                else if (values <= 80 && values > 70)
                {
                    grade.Add("B+");
                }
                else if (values <= 70 && values > 60)
                {
                    grade.Add("B");
                }
                else if (values <= 60 && values > 50)
                {
                    grade.Add("C+");
                }
                else if (values <= 50 && values > 40)
                {
                    grade.Add("D");
                }
                else
                {
                    grade.Add("F");
                }
            }
            Console.WriteLine("Name: " + Student.Name);
            Console.WriteLine("School: " + Student.School);
            Console.WriteLine("Class: " + Student.Class);
            Console.WriteLine("Roll no: " + Student.Roll_no);
            Console.WriteLine("Marks for subject1: " + Student.Marks1 + " " + "Grade: " + grade[0]);
            Console.WriteLine("Marks for subject2: " + Student.Marks2 + " " + "Grade: " + grade[1]);
            Console.WriteLine("Marks for subject3: " + Student.Marks3 + " " + "Grade: " + grade[2]);
            Console.WriteLine("Marks for subject4: " + Student.Marks4 + " " + "Grade: " + grade[3]);
            Console.WriteLine("Marks for subject5: " + Student.Marks5 + " " + "Grade: " + grade[4]);

        }
        public void TotalScore(Student_detail Student)
        {
            var total = Student.Marks1 + Student.Marks2 + Student.Marks3 + Student.Marks4 + Student.Marks5;
            Console.WriteLine("Total Score: " + total + "/500");
            var percentage = (total / 500) * 100;
            if (percentage > 90)
            {
                grade = "A+";
            }
            else if (percentage <= 90 && percentage > 80)
            {
                grade = "A";
            }
            else if (percentage <= 80 && percentage > 70)
            {
                grade = "B+";
            }
            else if (percentage <= 70 && percentage > 60)
            {
                grade = "B";
            }
            else if (percentage <= 60 && percentage > 50)
            {
                grade = "C+";
            }
            else if (percentage <= 50 && percentage > 40)
            {
                grade = "C";
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine("Final Grade: " + grade);
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();
            string addMoreStudents = "";

            do
            {

                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();

                Console.WriteLine("What course are you taking?");
                string courses = Console.ReadLine();

                Console.WriteLine("What is your course score?");
                decimal score = decimal.Parse(Console.ReadLine());

                Console.WriteLine("How old are you?");
                int age = int.Parse(Console.ReadLine());


                studentList.Add(new Student { Name = name, Courses = courses, Score = score, Age = age });

                Console.Write("Enter 'y' to add more students?");
                addMoreStudents = Console.ReadLine().ToLower();
                Console.WriteLine(addMoreStudents);

            } while (addMoreStudents == "y");

            foreach (Student student in studentList)
            {
                string grade = student.CalculateLetterGrade();
                string gradeSchoolElgible = (student.CanTakeGradCourse()) ? "are" : "are not";
                Console.WriteLine("{0} {1} elgible for Grad School, letter grade is {2}.", student.Name, gradeSchoolElgible, grade);
          

                if (student.Score <= 60) {

                    Console.WriteLine("{0} letter grade is {1}.", student.Name, grade);
                }
            }

         

           
            Console.ReadLine();
        }
    }
}

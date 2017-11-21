using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudentGrade
{
    class Student
    {
        public string Name { get; set; }
        public string Courses { get; set; }
        public decimal Score { get; set; }
        public int Age { get; set; }


        public bool CanTakeGradCourse() {
            return Age > 21;
        }

        public string CalculateLetterGrade() {
            string grade;
            if (Score <= 60)
            {
                grade = "C";
            }
            else if (Score <= 80)
            {
                grade = "B";
            }
            else if (Score >= 95)
            {
                grade = "A+";
            }
            else {
                grade = "A";
            }

            return grade;
        }

    }

}

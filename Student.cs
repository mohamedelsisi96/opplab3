using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace oppAss3
{
    internal class Student
    {
        private string? name;
        public string Name {
            get {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private string? grade;
        public string Grade
        {
            get
            {
                return grade;
            }
           private set
            {
                grade = value;
            }
        }

        private string? studentID;
        public string StudentID
        {
            get
            {
                return studentID;
            }
           private set
            {
                studentID = value;
            }
        }

      

        public Student(string name="omar",int age = 10, string stdid="a1")
        {
            Name = name;
            Age = age;
            StudentID = stdid;
            Grade = "Not Assigned";

        }
       
       public void DisplayStudentInfo()
        {
            Console.WriteLine($"the name of student is {Name}\t age : {Age} \t id : {StudentID} \t Grade : {Grade}");
        }
       public void UpdateGrade(string newGrade)
        {

            if (newGrade != null && newGrade != string.Empty) {
            Grade = newGrade;
            Console.WriteLine($"Grade updated successfully to: {newGrade}");
            }
            else
            {
                Console.WriteLine("Error: Grade cannot be empty or null");
            }
        }

    }
}

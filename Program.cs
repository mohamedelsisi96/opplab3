using System;

namespace oppAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Create a student with default values
            Console.WriteLine("Test Case 1: Default Constructor");
            Student student1 = new Student();
            student1.DisplayStudentInfo();
            Console.WriteLine();

            // Test Case 2: Create a student with custom values
            Console.WriteLine("Test Case 2: Custom Constructor");
            Student student2 = new Student("Mohamed", 20, "S123");
            student2.DisplayStudentInfo();
            Console.WriteLine();

            // Test Case 3: Test property setters
            Console.WriteLine("Test Case 3: Modifying Properties");
            student2.Name = "amira ";
            student2.Age = 21;
            
            student2.DisplayStudentInfo();
            Console.WriteLine();

            // Test Case 4: Test grade updates
            Console.WriteLine("Test Case 4: Grade Updates");
            student2.UpdateGrade("A+");
            student2.DisplayStudentInfo();
            Console.WriteLine();

            // Test Case 5: Test invalid grade update
            Console.WriteLine("Test Case 5: Invalid Grade Update");
            student2.UpdateGrade("");
            student2.UpdateGrade(null);
            student2.DisplayStudentInfo();
            Console.WriteLine();
        }
    }
}
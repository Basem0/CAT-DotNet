using System;
using System.Collections.Generic;
namespace HWNS
{
    class HelloWorld
    {
        public static void Main()
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>
            {
                { "Atef", 80 },
                { "Beso", 81 },
                { "Basem", 82 },
                { "B3dsh", 83 },
                { "zkrallah", 84 }
            };
            Console.WriteLine("Student Grades:");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            Console.WriteLine($"Do You Want To Search On Any Student Grade If yes Enter Yes if No Enter no");
            string SearchingOrder = Console.ReadLine();
            bool SeachingState = (SearchingOrder.ToLower()).Equals("yes");
            if (SeachingState)
            {
                Console.Write("Enter student name: ");
                string searchName = Console.ReadLine();
                FindGradeByName(studentGrades, searchName);
            }
        }

        public static void FindGradeByName(Dictionary<string, int> students, string name)
        {
            if (students.TryGetValue(name, out int grade))
            {
                Console.WriteLine($"Student: {name} is Founded & Grade ==> {grade}");
            }
            else
            {
                Console.WriteLine($"Student {name} not found.");
            }
        }


    }
}

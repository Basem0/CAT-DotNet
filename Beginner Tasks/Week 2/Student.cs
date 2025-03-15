using System;
namespace HWNS
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: => {Name}, Age: => {Age}, Grade: => {Grade}");
        }
    }

    class PostGraduate : Student
    {
        public string ThesisTopic { get; set; }

        public void PrintPostGraduateDetails()
        {
            PrintDetails();
            Console.WriteLine($"Thesis Topic: =====> {ThesisTopic}");
        }
    }
    class HelloWorld
    {
        public static void Main()
        {
            PostGraduate pG = new PostGraduate()
            {
                Name = "Ahmed Basem",
                Age = 25,
                Grade = "A+",
                ThesisTopic = "C# in Embedded Systems"
            };

            pG.PrintPostGraduateDetails();
        }
        
    }
}

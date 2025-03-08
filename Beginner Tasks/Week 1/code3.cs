using System;
namespace HWNS
{    
    class HelloWorld
    {
        public static void Main()
        {
            Console.WriteLine($"Enter A Num");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
            }
        }

    }
}

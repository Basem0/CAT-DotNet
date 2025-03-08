using System;
namespace HWNS
{    
    class HelloWorld
    {
        public static void Main()
        {
            Console.WriteLine($"Enter A Num");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 12 == 0) Console.WriteLine("YES");
            else Console.WriteLine("no"); 
        }

    }
}

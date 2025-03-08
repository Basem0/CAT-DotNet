using System;
namespace HWNS
{    
    class HelloWorld
    {
        public static void Main()
        {
            Console.WriteLine($"Enter A Letter");

            char letter = Convert.ToChar(Console.ReadLine());
            
            if ( letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') 
            Console.WriteLine($"vowel");
            else Console.WriteLine($"constant");

        }

    }
}

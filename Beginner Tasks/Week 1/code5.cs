using System;
namespace HWNS
{    
    class HelloWorld
    {
        public static void Main()
        {
            Console.WriteLine($"Enter A Num");

            int num = Convert.ToInt32(Console.ReadLine());

            string binNum = "";
            int i = 0;
            int temp = num;
            while(temp > 0)
            {
                binNum = (temp % 2) + binNum;
                temp /= 2;
                i++;
            }
            Console.WriteLine($"Binary of {num} is {binNum}");
            
        }

    }
}

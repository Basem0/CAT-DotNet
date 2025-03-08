using System;
namespace HWNS
{    
    class HelloWorld
    {
        public static void Main()
        {
            Console.WriteLine($"Enter 10 Numbers");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxNum = arr[0];
            for (int i = 1; i < 10; i++)
            {
                if(arr[i] > maxNum) maxNum = arr[i];
            }
            Console.WriteLine($"Max Num In Array is {maxNum}");

        }

    }
}

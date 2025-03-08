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
            Console.WriteLine("Array In Reverse Order");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine (arr[i]);
            }

        }

    }
}

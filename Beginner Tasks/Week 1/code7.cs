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
            int maxNum = (arr[0] > arr[1]) ? arr[0] : arr[1];
            int maxNum2 = (arr[0] > arr[1]) ? arr[1] : arr[0];
            for (int i = 2; i < 10; i++)
            {
                if (arr[i] > maxNum)
                {
                    maxNum2 = maxNum;
                    maxNum = arr[i];
                }
            }
            Console.WriteLine($"2nd Largest Num In Array is {maxNum2}");

        }

    }
}

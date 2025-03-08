using System;
namespace HWNS
{
    class HelloWorld
    {
        public static void Main()
        {
            Console.WriteLine($"Enter size of Array");
            int sizeOfArray = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"Enter {sizeOfArray} Numbers of First Array");
            int[] arr1 = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Enter {sizeOfArray} Numbers of Second Array");
            int[] arr2 = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int [] mergeArray = new int [sizeOfArray * 2];

            for (int i = 0; i < sizeOfArray; i++)
            {
                mergeArray[i] = arr1[i];   
            }
            for (int i = 0; i < sizeOfArray; i++)
            {
                mergeArray[i+sizeOfArray] = arr2[i];
            }
            

            bool swapped;

            for (int i = 0; i < sizeOfArray*2 - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < sizeOfArray * 2 - i - 1; j++)
                {
                    if (mergeArray[j] > mergeArray[j + 1])
                    {
                        int temp = mergeArray[j];
                        mergeArray[j] = mergeArray[j + 1];
                        mergeArray[j + 1] = temp;

                        swapped = true;
                    }
                }
                
                if (!swapped)
                    break;
            }

            for (int i = 0; i < sizeOfArray * 2; i++)
                Console.Write(mergeArray[i]);

        }

    }
}

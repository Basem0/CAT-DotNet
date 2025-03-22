using System;
namespace HWNS
{
    class HelloWorld
    {
        public static void Main()
        {
            int x = 2023, y = 2024;
            Console.WriteLine($"Integer Before Swap: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"Integer After Swap: x = {x}, y = {y}");

            Console.WriteLine();

            string str1 = "CAT", str2 = "Reloaded";
            Console.WriteLine($"String Before Swap: str1 = {str1}, str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"String After Swap: str1 = {str1}, str2 = {str2}");
        }
        
        public static void Swap<T>(ref T var1, ref T var2)
        {
            if (var1 == null || var2 == null) return;
            T tempVar = var1;
            var1 = var2;
            var2 = tempVar; 
                    }
        
    }
}

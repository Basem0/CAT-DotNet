using System;
using System.Collections.Generic;
using System.Threading;
namespace HWNS
{
    class HelloWorld
    {
        public static void Main()
        {
            Queue<string> customers = new Queue<string>();

            customers.Enqueue("zkrallah");
            customers.Enqueue("beso");
            customers.Enqueue("basem");
            customers.Enqueue("b3dsh");
            customers.Enqueue("vanDijk");

            Console.WriteLine("Customers Names:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("\nProcessing Customers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.WriteLine(".");
            }

            Console.Write("\n");


            while (customers.Count > 0)
            {
                string servedCustomer = customers.Dequeue(); 
                Console.WriteLine($"Serving: {servedCustomer}");
            }

            Console.WriteLine("\nAll customers served.");
        }



        //public static void FindGradeByName(Dictionary<string, int> students, string name)
        //{
        //    if (students.TryGetValue(name, out int grade))
        //    {
        //        Console.WriteLine($"Student: {name} is Founded & Grade ==> {grade}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Student {name} not found.");
        //    }
        //}


    }
}

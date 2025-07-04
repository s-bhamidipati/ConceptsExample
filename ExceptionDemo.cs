using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsExample
{
    internal class ExceptionDemo
    {
        static int[] arr = { 5, 6, 8, 9 };

        public static void printarr()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            try
            {
                Console.WriteLine(arr[5]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an exception occur: {ex.Message}");
                Console.ReadKey();
            }
        }
        static void Main()
        {
            printarr();
        }

        public struct person
        {
            public string name;
            public int age;
        }

        class persondetails
        {
            public static void Main()
            {
                person p1;
                p1.name = "Karan";
                p1.age = 25;

                Console.WriteLine($"the person details are {p1.name}, {p1.age}");
                Console.ReadKey();

            }
        }

        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
    }

    class demo
    {
        public static void Main()
        {
            ExceptionDemo exdemo = new ExceptionDemo();
            exdemo.Name = "srinivas";
            exdemo.Age = 33;
        }
    }
}

using System;
using System.Collections;

namespace sortedList
{
    internal class Program
    {
        public static string ReadString(string str = "")
        {
            if (str.Length > 0) { Console.WriteLine(str); }
            string key = "";
            bool flag = false;
            while (!flag)
            {
                key = Console.ReadLine() ?? "";
                if (key.Length > 0)
                {
                    flag = true;
                }
            }
            return key;

        }
        public static int ReadInput(string str = "")
        {
            if (str.Length > 0) { Console.WriteLine(str); }
            string number = "";
            bool flag = false;
            while (!flag)
            {
                number = Console.ReadLine() ?? "";
                if (int.TryParse(number, out int n))
                {
                    flag = true;
                }
            }
            return Convert.ToInt32(number);
        }
        public static void ValueAndKeys(SortedList sortedList)
        {
            Console.WriteLine("\tKeys:\tValues:");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"\t{sortedList.GetKey(i)}:\t{sortedList.GetByIndex(i)}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("SortedList");
            int len = ReadInput("Enter Length of Array:");
            SortedList array = new SortedList();
            for (int i = 0; i < len; i++)
            {
                array.Add(ReadString("Enter key:"), ReadInput("Enter value:"));
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add");
                Console.WriteLine("2. IndexOf by key");
                Console.WriteLine("3. IndexOf by value");
                Console.WriteLine("4. Key by index");
                Console.WriteLine("5. Value by index");
                string menuInput = Console.ReadLine() ?? "";
                Console.Clear();

                if (menuInput == "1")
                {
                    array.Add(ReadString("Enter key"), ReadInput("Enter value:"));
                    ValueAndKeys(array);
                    Console.ReadKey();
                }
                else if (menuInput == "2")
                {
                    Console.WriteLine(array.IndexOfKey(ReadString("Enter key:")));
                    Console.ReadKey();
                }
                else if (menuInput == "3")
                {
                    Console.WriteLine(array.IndexOfValue(ReadInput("Enter value:")));
                    Console.ReadKey();
                }
                else if (menuInput == "4")
                {
                    Console.WriteLine(array.GetKey(ReadInput("Enter index of key:")));
                    Console.ReadKey();
                }
                else if (menuInput == "5")
                {
                    Console.WriteLine(array.GetByIndex(ReadInput("Enter index of value:")));
                    Console.ReadKey();
                }
            }
        }
    }
}

using System;
using System.Collections;

namespace arrayList
{
    internal class Program
    {
        public static int ReadInput()
        {
            string num = "";
            bool flag = false;
            while (!flag)
            {
                num = Console.ReadLine() ?? "";
                if (int.TryParse(num, out int n))
                {
                    flag = true;
                }
            }
            return Convert.ToInt32(num);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("2. ArrayList");
            Console.WriteLine("Enter Length of Array");
            int len = ReadInput();
            ArrayList array = new ArrayList();
            Console.WriteLine("Enter NUmbers");
            for (int i = 0; i < len; i++)
            {
                array.Add(ReadInput());
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Count");
                Console.WriteLine("2. BinSearch");
                Console.WriteLine("3. Copy");
                Console.WriteLine("4. IndexOf");
                Console.WriteLine("5. Insert");
                Console.WriteLine("6. Reverse");
                Console.WriteLine("7. Sort");
                Console.WriteLine("8. Add");

                string menuInput = Console.ReadLine() ?? "";

                Console.Clear();
                if (menuInput == "1")
                {
                    Console.Write(array.Count);
                    Console.ReadKey();
                }
                else if (menuInput == "2")
                {
                    Console.WriteLine("Enter needed number");
                    int number = ReadInput();
                    array.Sort();
                    Console.Write(array.BinarySearch(number));
                    Console.ReadKey();
                }
                else if (menuInput == "3")
                {
                    ArrayList newArray = new ArrayList();
                    newArray.AddRange(array);
                    foreach (object i in newArray) { Console.WriteLine((int)i); }
                    Console.ReadKey();
                }
                else if (menuInput == "4")
                {

                    Console.WriteLine("Enter needed number");
                    int number = ReadInput();
                    Console.WriteLine(array.IndexOf(number));
                    Console.ReadKey();
                }
                else if (menuInput == "5")
                {
                    Console.WriteLine("Enter number");
                    int number = ReadInput();
                    Console.WriteLine("Enter Index");
                    int index = ReadInput();
                    array.Insert(index, number);
                    foreach (object i in array) { Console.WriteLine((int)i); }
                    Console.ReadKey();
                }
                else if (menuInput == "6")
                {
                    ArrayList newArray = new ArrayList();
                    newArray.AddRange(array);
                    newArray.Reverse();
                    foreach (object i in newArray) { Console.WriteLine((int)i); }
                    Console.ReadKey(); ;
                }
                else if (menuInput == "7")
                {
                    ArrayList newArray = new ArrayList();
                    newArray.AddRange(array);
                    newArray.Sort();
                    foreach (object i in newArray) { Console.WriteLine((int)i); }
                    Console.ReadKey();
                }
                else if (menuInput == "8")
                {
                    int number = ReadInput();
                    array.Add(number);
                    foreach (object i in array) { Console.WriteLine((int)i); }
                    Console.ReadKey();
                }
            }
        }
}

using System;
using System.Linq;

namespace array
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
            return int.Parse(num);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Array");
            int len = ReadInput();
            int[] array = new int[len];
            Console.WriteLine("Enter Numbers");
            for (int i = 0; i < len; i++)
            {
                array[i] = ReadInput();
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Count");
                Console.WriteLine("2. BinSearch");
                Console.WriteLine("3. Copy");
                Console.WriteLine("4. Find");
                Console.WriteLine("5. FindLast");
                Console.WriteLine("6. IndexOf");
                Console.WriteLine("7. Reverse");
                Console.WriteLine("8. Resize");
                Console.WriteLine("9. Sort");

                string menuInput = Console.ReadLine() ?? "";

                Console.Clear();
                if (menuInput == "1")
                {
                    Console.Write(array.Count());
                    Console.ReadKey();
                }
                else if (menuInput == "2")
                {
                    Console.WriteLine("Enter needed number");
                    int number = ReadInput();
                    Array.Sort(array);
                    Console.Write(Array.BinarySearch(array, number));
                    Console.ReadKey();
                }
                else if (menuInput == "3")
                {
                    int[] newArray = new int[array.Length];
                    Array.Copy(array, newArray, array.Length);
                    foreach (int i in newArray) { Console.WriteLine(i); }
                    Console.ReadKey();
                }
                else if (menuInput == "4")
                {

                    Console.WriteLine("Enter needed number");
                    int number = ReadInput();
                    Console.WriteLine(Array.Find(array, element => element == number));
                    Console.ReadKey();
                }
                else if (menuInput == "5")
                {
                    Console.WriteLine("Enter needed number");
                    int number = ReadInput();
                    Console.WriteLine(Array.FindLast(array, element => element == number));
                    Console.ReadKey();
                }
                else if (menuInput == "6")
                {
                    Console.WriteLine("Enter needed number");
                    int number = ReadInput();
                    Console.WriteLine(Array.IndexOf(array, number));
                    Console.ReadKey();
                }
                else if (menuInput == "7")
                {
                    int[] newArray = new int[array.Length];
                    Array.Copy(array, newArray, array.Length);
                    Array.Reverse(newArray);
                    foreach (int i in newArray) { Console.WriteLine(i); }
                    Console.ReadKey();
                }
                else if (menuInput == "8")
                {
                    Console.WriteLine("Enter needed lenght of array");
                    int size = ReadInput();
                    int[] newArray = array;
                    Array.Resize(ref newArray, size);
                    foreach (int i in newArray) { Console.WriteLine(i); }
                    Console.ReadKey();
                }
                else if (menuInput == "9")
                {
                    Array.Sort(array);
                    foreach (int i in array) { Console.WriteLine(i); }
                    Console.ReadKey();
                }
            }
        }
    }
}

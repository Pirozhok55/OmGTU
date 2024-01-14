using System;
using System.Linq;
namespace _11._12
{
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            int count = 0;
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "") break;
                str = str.Replace(pattern, "&");
                count += str.Count(i => i == '&');
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

    }
}
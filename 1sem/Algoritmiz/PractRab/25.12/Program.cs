using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 106732567;
            int a2 = 152673837;
            for (int i = a1; i < a2; i++)
            {
                if (((int)Math.Sqrt(i) * (int)Math.Sqrt(i)) != i) continue;
                int count = 0;
                int max = 0;
                bool flag = true;
                for (int j = 2; j < (int)(Math.Sqrt(i) - 1); j++)
                {
                    if (i % j == 0)
                    {
                        count += 2;
                        max = i / j;
                    }
                    if (count > 2)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag && count == 2) Console.WriteLine(i + " " + max);
            }
            Console.ReadKey();
        }
    }
}

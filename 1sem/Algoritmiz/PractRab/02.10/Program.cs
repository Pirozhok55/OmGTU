using System;
namespace LabrRabClass28._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()),
            sum = 0;
            int[] min1 = { Int32.MaxValue, Int32.MaxValue }, min2 = { Int32.MaxValue, Int32.MaxValue };
            for (int i = 0; i < n; i++)
            {
                string[] nki = Console.ReadLine().Split(' ');
                int n1 = Convert.ToInt32(nki[0]),
                n2 = Convert.ToInt32(nki[1]),
                k = Math.Abs(n1 - n2);
                if (k % 3 == 1)
                {
                    if (k < min1[0])
                    {
                        min1[0] = k;
                    }
                    else if (k < min1[1])
                    {
                        min1[1] = k;
                    }
                }
                else if (k % 3 == 2)
                {
                    if (k < min2[0])
                    {
                        min2[0] = k;
                    }
                    else if (k < min2[1])
                    {
                        min2[1] = k;
                    }
                }
                sum += Math.Max(n1, n2);
            }
            bool b1 = (min1[0] < Int32.MaxValue || min1[1] < Int32.MaxValue) || (min2[0] < Int32.MaxValue && min2[1] < Int32.MaxValue),
                 b2 = (min2[0] < Int32.MaxValue || min2[1] < Int32.MaxValue) || (min1[0] < Int32.MaxValue && min1[1] < Int32.MaxValue);
            if (sum % 3 == 0)
            {
                Console.WriteLine($"Cумма кратная 3: {sum}");
            }
            else if (sum % 3 == 1 && b1)
            {
                int r1 = ((min1[0] < min1[1]) ? min1[0] : min1[1]);
                int min = r1;
                if (min2[0] < Int32.MaxValue && min2[1] < Int32.MaxValue)
                {
                    int r2 = min2[0] + min2[0];
                    min = (min < r2 ? min : r2);
                }
                if (min < Int32.MaxValue)
                {
                    sum = sum - min;
                }
                Console.WriteLine($"Cумма кратная 3: {sum}");
            }
            else if (sum % 3 == 2 && b2)
            {
                int r2 = ((min2[0] < min2[1]) ? min2[0] : min2[1]);
                int min = r2;
                if (min1[0] < Int32.MaxValue && min1[1] < Int32.MaxValue)
                {
                    int r1 = min1[0] + min1[0];
                    min = (min < r1 ? min : r1);
                }
                if (min < Int32.MaxValue)
                {
                    sum = sum - min;
                }
                Console.WriteLine($"Cумма кратная 3: {sum}");
            }
            else
            {
                Console.WriteLine("Невозможно");
            }
            Console.Read();
        }
    }
}
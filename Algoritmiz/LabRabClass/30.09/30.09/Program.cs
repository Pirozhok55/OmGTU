using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите количество чисел: ");

                byte n = byte.Parse(Console.ReadLine()), five = 0;
                short a, maxch = -32768, isch = 0;
                int sum = 0, minsum = 50;

                for (byte i = 0; i < n; i++)
                {
                    a = short.Parse(Console.ReadLine());

                    // 1
                    if (a % 2 == 0 && maxch < a) maxch = a;
                    if (a == -32768) isch++;

                    // 2
                    for (short b = a; b !=0 ; b /= 10)
                    {
                        if (b % 10 == 5) five++;
                    }

                    //3
                    if (a < 0) a *= -1;
                    for (short b = a; b != 0; b /= 10)
                    {
                        sum += b % 10;
                    }
                    if (sum < minsum) minsum = sum;
                    sum = 0;
                }

                if (isch == 0 && maxch == -32768) Console.WriteLine("1. Четные числа отсутствуют");
                else Console.WriteLine("1. Максимально четное: " + maxch);

                Console.WriteLine("2. Количество чисел с цифрой 5: " + five);

                Console.WriteLine("3. Минимальная сумма цифр: " + minsum);



                Console.Read();
            }
        }
    }
}

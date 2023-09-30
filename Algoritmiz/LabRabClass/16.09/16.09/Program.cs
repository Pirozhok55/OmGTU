using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Блок 1");

            int a, pol = 0, sar = 0, kol = 0, pn = 1, max = -2147483648;

            Console.WriteLine("Ввод значений: ");
            for (int i = 0; i != 10; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > 0) { pol++; }
                if (a < 0) { sar += a; kol++; }
                if (a % 2 > 0) { pn *= a; }
                if (a > max) { max = a; }
            }
            float sarm = (float)sar / kol;

            Console.WriteLine("Количество положиельных: " + pol);
            Console.WriteLine("Среднее арифметическое отрицательных: " + sarm);
            Console.WriteLine("Произведение нечетных: " + pn);
            Console.WriteLine("Максимальное: " + max);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Блок 2");

            byte n, kmp = 0;
            sbyte k = -1, par = 0;
            short b, pred = 32767, bp = -32768, min = 32767, minchet = 32767;
            Console.WriteLine("Введите количество чисел: ");
            n = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ввод чисел: ");
            for (byte i = 0; i != n; i++)
            {
                b = short.Parse(Console.ReadLine());

                if (b > bp) { k++; }
                bp = b;

                if (b < min) { min = b; kmp++; }

                if (pred != 32767) { if ((pred + b) % 3 == 0) { par++; } }
                pred = b;

                if (b % 2 == 0) { if (b < minchet) { minchet = b; } }
            }

            Console.WriteLine("Количество элементов со значением больше предыдущего: " + k);
            Console.WriteLine("Количество элементов со значением меньше всех предыдущих: " + kmp);
            if (par < 0) { par = 0; }
            Console.WriteLine("Количество пар, сумма которых кратна 3: " + par);
            if (minchet == 32767) { Console.WriteLine("Четные числа отсутствуют"); }
            else
            {
                Console.WriteLine("Минимальное четное: " + minchet);
            }
        }
    }
}

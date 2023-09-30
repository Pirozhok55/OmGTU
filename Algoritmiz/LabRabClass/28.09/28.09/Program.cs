using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabrRabClass28._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите количество элементов: ");
                byte chsign = 0, elmens = 0, poslod1 = 1, poslod2 = 1, mpo1 = 1, mpo2 = 127, s = 1;
                byte n = byte.Parse(Console.ReadLine());
                short a, b = 0, c = 0;
                for (int i = 0; i < n; i++)
                {
                    a = short.Parse(Console.ReadLine());

                    // 1
                    if (b < 0 && a >= 0)
                        chsign++;
                    if (b >= 0 && a < 0)
                        chsign++;

                    // 2
                    if (i > 1 && b < a && b < c)
                        elmens++;

                    // 3
                    if (b == a) poslod1++;
                    else if (poslod2 < poslod1)
                    {
                        poslod2 = poslod1;
                        poslod1 = 1;
                    }

                    // 4
                    if (a < 0)
                    {
                        s++;
                        if (b < 0) mpo1++;
                    }
                    else if (b < 0)
                    {
                        if (mpo2 > mpo1) mpo2 = mpo1;
                        mpo1 = 1;
                    }


                    c = b;
                    b = a;
                }
                if (mpo2 == 127) mpo2 = mpo1;
                if (poslod2 < poslod1)
                {
                    poslod2 = poslod1;
                    poslod1 = 1;
                }

                Console.WriteLine("1. Количесвто смены знака: " + chsign);
                Console.WriteLine("2. Количество элементов меньше соседних: " + elmens);
                Console.WriteLine("3. Максимальный размер последовательности одинаковых элементов: " + poslod2);
                if (s == 1) Console.WriteLine("4. Отрицательные числа отсутствуют");
                else Console.WriteLine("4. Минимальная последовательность отрицательных: " + mpo2);

                Console.ReadLine();
            }
        }
    }
}

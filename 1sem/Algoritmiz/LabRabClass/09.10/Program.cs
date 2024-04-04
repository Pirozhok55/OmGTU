using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов: ");
                byte n = byte.Parse(Console.ReadLine()), last0 = Convert.ToByte(n + 1), kratmin = 0, minindex = 0, maxindex = 0;
                short min = 32767, max = -32768;
                short[] mainmassive = new short[n], summassive = new short[n - 1];
                bool decreasing = true, kratnom = true;
                for (byte i = 0; i < n; i++)
                {
                    Console.Write("Введите " + (i + 1) + " элемент: ");
                    mainmassive[i] = short.Parse(Console.ReadLine());
/*2*/               last0 = mainmassive[i] == 0 ? i : last0;
                    if (mainmassive[i] < min)
                    {
                        min = mainmassive[i];
                        minindex = i;
                    }
                    if (mainmassive[i] > max)
                    {
                        max = mainmassive[i];
                        maxindex = i;
                    }
                }
/*1*/           for (byte i = 0; i < n; i++)
                {
                    if (mainmassive[i] % min == 0)
                    {
                        kratmin = ++i;
                        break;
                    }
                }
/*3*/           if (maxindex < minindex)
                {
                    maxindex += minindex;
                    minindex = Convert.ToByte(maxindex - minindex);
                    maxindex -= minindex;
                }
                for (byte i = Convert.ToByte(minindex + 2); i < maxindex; i++)
                {
                    if (mainmassive[i] > mainmassive[i - 1])
                    {
                        decreasing = false;
                        break;
                    }
                }
/*4*/           for(byte i = 0; i < n; i++)
                { 
                    if (mainmassive[i] % (i + 1) != 0)
                    {
                        kratnom = false;
                        break;
                    }
                }

/*1*/           Console.WriteLine("1. Первый элемент кратный минимальному: " + kratmin +"й");
/*2*/           if (last0 != n+1) Console.WriteLine("2. Последний элемент 0: " + ++last0 + "й");
                else Console.WriteLine("2. Элементов со значением 0 нет.");
/*3*/           if (maxindex - minindex <= 2) Console.WriteLine("2.(0) Между макс-м и мин-м элементами отсутствует последовательность.");
                else if (decreasing) Console.WriteLine("2.(+) Между макс-м и мин-м элементами убывающая последовательность.");
                else Console.WriteLine("2.(-) Между макс-м и мин-м элементами отсутствует убывающая последовательность.");
/*4*/           if (kratnom) Console.WriteLine("4. Все элементы кратны своему номеру");
                else Console.WriteLine("4. Не все элементы кратны своему номеру.");
/*5*/           Console.Write("Массив суммы пар элементов:");
                for (byte j = 0; j < (n-1); j++)
                {
                    summassive[j] = Convert.ToInt16(mainmassive[j] + mainmassive[j + 1]);
                    Console.Write(" " + summassive[j]);
                }









                Console.ReadLine();
            }
        }
    }
}

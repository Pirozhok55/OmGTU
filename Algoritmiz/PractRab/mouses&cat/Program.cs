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
            while(true)
            {
                Console.Clear();

                Console.Write("Введите количество мышек: ");
                byte kolmish = byte.Parse(Console.ReadLine());

                Console.Write("Введите номер белой мышки: ");
                sbyte nomwhite= sbyte.Parse(Console.ReadLine());

                Console.Write("Введите шаг съедания: ");
                byte shag = byte.Parse(Console.ReadLine());
                sbyte index = 0;
                sbyte checkindex = 0;

                bool[] mousmassiv = new bool[kolmish];
                for (byte i = 0; i < kolmish; i++) mousmassiv[i] = true;

                for (byte j = 0; j < (kolmish - 1); j++)
                {
                    for (byte i = 0; i < shag; i++)
                    {
                        index++;
                        index = Convert.ToSByte(index == kolmish ? 0 : index);
                        while (mousmassiv[index] == false)
                        {
                            index++;
                            index = Convert.ToSByte(index == kolmish ? 0 : index);
                        }
                    }
                    mousmassiv[index] = false;
                }
                index = 0;
                foreach (bool i in mousmassiv)
                {
                    if (i == true) checkindex = index;
                    index++;
                }
                checkindex -= nomwhite;
                checkindex = Convert.ToSByte(checkindex <= 0?-checkindex:kolmish-checkindex);
                Console.WriteLine("Нужно начать с мыши номер " + checkindex);

                Console.ReadLine();
            }
        }
    }
}

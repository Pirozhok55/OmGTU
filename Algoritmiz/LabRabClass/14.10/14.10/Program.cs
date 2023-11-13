using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();


                Console.Write("Введите количество строк: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int m = int.Parse(Console.ReadLine());
                int kratfive = 0, sumel = 0, proizel = 1, sumbol = 0, minel = 2147483647, proizchet = 1, kol4 = 0;

                int[,] massive = new int[n, m];
                Console.WriteLine("Ввод элементов массива: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        massive[i, j] = int.Parse(Console.ReadLine());
                        /*1*/
                        if (massive[i, j] % 5 == 0) kratfive++;
                        /*2*/
                        sumel += massive[i, j];
                        proizel *= massive[i, j];
                        /*4*/
                        if (massive[i, j] >= 0 && massive[i, j] % 2 == 0)
                        {
                            proizchet *= massive[i, j];
                            kol4++;
                        }
                    }
                    if (sumel > proizel) sumbol++;
                    sumel = 0;
                    proizel = 1;
                }
                


/*1*/           Console.WriteLine("1. Количество элементов кратных 5: " + kratfive);
/*2*/           Console.WriteLine("2. Количество строк с суммой эл-в больше произведения: " + sumbol);

/*3*/           Console.WriteLine("3. Минимальные элементы в каждом столбце: ");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (massive[j, i] < minel)minel = massive[j,i];
                    }
                    Console.WriteLine("В " + i + "м столбце: " + minel);
                    minel = 2147483647;
                }
/*4*/           if(kol4 > 0) Console.WriteLine("4. Произведение неотриц-х четных эл-в: " + proizchet);
                else Console.WriteLine("4. Неотриц-е четные отсутствуют.");

                int[,] mas = new int[n,3];
/*5*/           int proiz5 = 1, sum5 = 0, kol0 = 0, otvet5 = -n;
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        proiz5 *= massive[i, j];
                        sum5 += massive[i, j];
                        if (massive[i, j] == 0) kol0++;
                    }
                    mas[i, 0] = proiz5;
                    mas[i, 1] = sum5;
                    mas[i, 2] = kol0;
                    proiz5 = 1;
                    sum5 = 0;
                }
                for (int i = 0; i < n; i++)
                {
                    for(int k = i; k < n; k++)
                    {
                        if (mas[i, 0] == mas[k, 0] && mas[i, 1] == mas[k, 1] && mas[i, 2] == mas[k, 2]) otvet5++; 
                    }
                    
                }
                Console.WriteLine("5. Количество пар строк с одинаковыми элементами: " + otvet5);

                Console.ReadLine();
            }
        }
    }
}

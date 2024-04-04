using System;
namespace _1123
{
    internal class Program
    {
        static int[,] SwapAll(int[,] massiv)
        {
            int[,] swapMas = new int[massiv.GetLength(0), massiv.GetLength(1)];
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < (massiv.GetLength(1) / 2) * 2; j++)
                {
                    if (j % 2 == 0) swapMas[i, j] = massiv[i, (j + 1)];
                    else swapMas[i, j] = massiv[i, (j - 1)];
                }
            }
            if ((massiv.GetLength(1) / 2) * 2 != massiv.GetLength(1))
            {
                for (int i = 0; i < massiv.GetLength(0); i++) swapMas[i, massiv.GetLength(1) - 1] = massiv[i, massiv.GetLength(1) - 1];
            }
            return swapMas;
        }

        static int[] NotNullInString(int[,] massiv)
        {
            int[] notNullElems = new int[massiv.GetLength(1)];
            for (int i = 0; i < massiv.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < massiv.GetLength(0); j++)
                {
                    if (massiv[j, i] != 0) sum++;
                }
                notNullElems[i] = sum;
            }
            return notNullElems;
        }

        static string[] MaxInString(int[,] massiv)
        {
            int maxVal = int.MinValue;
            string[] maxMas = new string[massiv.GetLength(0)];
            for (int j = 0; j < massiv.GetLength(0); j++)
            {
                bool det = false;
                for (int i = 0; i < massiv.GetLength(1); i++)
                {
                    if (maxVal < massiv[j, i] && massiv[j, i] % 2 == 0)
                    {
                        maxMas[j] = massiv[j, i].ToString();
                        det = true;
                    }
                }
                if (det == false) maxMas[j] = "NoEl";
            }
            return maxMas;
        }
        static int[,] MassiveGenerate(string n, string m)
        {
            int[,] mainMassive = new int[int.Parse(n), int.Parse(m)];
            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.Write("Ввод " + (i + 1) + " строки: ");
                string[] strMas = Console.ReadLine().Split();
                for (int j = 0; j < int.Parse(m); j++)
                {
                    mainMassive[i, j] = int.Parse(strMas[j]);
                }
            }
            return mainMassive;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ввод размера массива: ");
            string[] nm = Console.ReadLine().Split();
            int[,] mainMassive = MassiveGenerate(nm[0], nm[1]);
            string[] maxMas = MaxInString(mainMassive);
            int[] notNull = NotNullInString(mainMassive);

            Console.Write("\n1. Массив максимальных четных по строкам: ");
            foreach (string i in maxMas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("2. Массив кол-ва ненулевых эл-в по столбцам: ");
            foreach (int i in notNull)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("3. ");
            int[,] Swap = SwapAll(mainMassive);
            for (int i = 0; i < Swap.GetLength(0); i++)
            {
                Console.Write("\t{");
                for (int j = 0; j < Swap.GetLength(1); j++) Console.Write('\t' + Swap[i, j].ToString() + " ");
                Console.WriteLine("\t}");
            }

            Console.Read();
        }
    }
}

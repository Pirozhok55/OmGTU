using System;
namespace _16._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] cities = new int[k];
            bool possible = false;
            for (int i = 0; i < k; i++)
                cities[i] = int.Parse(Console.ReadLine());
            int dist = k;
            int minDist = int.MaxValue;
            int minPerf = 0;
            for (int i = 1; i < k; i++)
                dist += cities[i];
            for (int i = 0; i < cities[cities.Length - 1]; i++)
            {
                var place = true;
                foreach (var city in cities)
                {
                    if (city >= i) dist--;
                    else dist++;
                    if (Math.Abs(city - i) < n) place = false;
                }
                Console.WriteLine(i + " " + dist);
                if (place)
                {
                    possible = true;
                    if (dist < minDist)
                    {
                        minDist = dist;
                        minPerf = i;
                    }
                }
            }
            if (possible)
                Console.WriteLine("Ответ: на километре " + minPerf + " минимальное расстояние будет " + minDist);
            else
                Console.WriteLine("Нельзя!");
            Console.ReadKey();
        }
    }
}

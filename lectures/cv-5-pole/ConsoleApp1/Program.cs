using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Months = new[] { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
            double[] UnemploymentRate = new double[12];
            for (int i = 0; i < 12; i++)
            {
                Console.Write("Zadejte nezamestnanost za mesic {0}: ", Months[i]);
                UnemploymentRate[i] = double.Parse(Console.ReadLine());
            }

            double max = UnemploymentRate.Max();
            int maxIndex = Array.IndexOf(UnemploymentRate, max);

            double min = UnemploymentRate.Min();
            int minIndex = Array.IndexOf(UnemploymentRate, min);

            Console.WriteLine("Největší nezaměstnanost byla za měsíc {0}: {1} %", Months[maxIndex], max);
            Console.WriteLine("Nejmenší nezaměstnanost byla za měsíc {0}: {1} %", Months[minIndex], min);
            Console.WriteLine("Průměrná nezaměstnanost byla: {0} %", UnemploymentRate.Average());
            Console.ReadKey();
        }
    }
}

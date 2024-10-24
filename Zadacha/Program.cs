using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи числа на един ред, с растояние между тях:");
            List<int> listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (listNumbers.Count == 0)
            {
                Console.WriteLine("Няма въведени числа!");
                return;
            }

            List<int> orderedNumbers = listNumbers.OrderBy(n => n).ToList();
            List<int> firstFiveNumbers = orderedNumbers.Take(5).ToList();
            double average = listNumbers.Average();

            Console.WriteLine($"Сортирани числа:{string.Join(" ", orderedNumbers)}");
            Console.WriteLine($"Първите 5 числа:{string.Join(" ", firstFiveNumbers)}");
            Console.WriteLine($"Средно аритметично: {average}");
        }
    }
}

using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingTime, humanNumber;
            waitingTime = 10;
            Console.WriteLine("Введите количество человек в очереди");
            humanNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Предполагаемое время нахождения в очереди - {humanNumber * waitingTime / 60} часов и {humanNumber * waitingTime % 60} минут");
        }
    }
}

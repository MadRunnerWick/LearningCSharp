using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystalCost, crystalNumber, playerMoney, playerCrystal;
            crystalCost = 8;
            crystalNumber = 13;
            Console.WriteLine("Введи количество вашего золота");
            playerMoney = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы можете купить до {crystalNumber} кристаллов по цене {crystalCost}. Сколько кристаллов вы хотите купить?");
            playerCrystal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество купленных кристаллов - {playerCrystal}. Потраченное золото - {playerCrystal * crystalCost}. Оставшееся золото - {playerMoney -= playerCrystal * crystalCost}. Оставшиеся кристаллы {crystalNumber - playerCrystal}");
        }
    }
}

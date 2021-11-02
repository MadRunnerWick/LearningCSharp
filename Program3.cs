using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystalCost, crystalNumber, playerMoney, playerCrystal;string playerMoneyString, playerCrystalString;
            crystalCost = 8;
            crystalNumber = 13;
            playerMoneyString = Console.ReadLine();
            playerMoney = Convert.ToInt32(playerMoneyString);
            Console.WriteLine($"Вы можете купить {crystalNumber} кристаллов по цене {crystalCost}");
            playerCrystalString = Console.ReadLine();
            playerCrystal = Convert.ToInt32(playerCrystalString);
            playerMoney -= playerCrystal * crystalCost;
            Console.WriteLine($"Количество купленных кристаллов - {playerCrystal}. Потраченное золото - {playerCrystal * crystalCost}. Оставшееся золото - {playerMoney}");
        }
    }
}

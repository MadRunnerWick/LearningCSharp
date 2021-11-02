using System;


namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures, picturesOutputNumber, picturesRows, picturesRemainder; 
            pictures = 52;
            picturesOutputNumber = 3;
            picturesRows = 52 / 3;
            picturesRemainder = 52 % 3;
            Console.WriteLine("Полностью заполненных рядов - " + picturesRows + ", остаток - " + picturesRemainder);
        }
    }
}

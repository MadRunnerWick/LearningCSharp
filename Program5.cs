using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender, name, familia, club, country, age;
            Console.WriteLine("Какое у вас имя?");
            name = Console.ReadLine();
            Console.WriteLine("Какая у вас фамилия?");
            familia = Console.ReadLine();
            Console.WriteLine("Вы мужчина или женщина?");
            gender = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Console.ReadLine();
            Console.WriteLine("За какой футбольный клуб вы болеете?");
            club = Console.ReadLine();
            Console.WriteLine("В какой стране вы живёте?");
            country = Console.ReadLine();
            Console.WriteLine($"Вы {gender} по имени и фамилии {name} {familia}, вам {age} лет. Вы живёте в стране {country} и болеете за футбольный клуб - {club}");
        }
    }
}

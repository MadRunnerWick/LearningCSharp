using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender, name, age, cinemaGo, politics;
            Console.WriteLine("Какое у вас имя?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Console.ReadLine();
            Console.WriteLine("Вы мужчина или женщина?");
            gender = Console.ReadLine();
            Console.WriteLine("Как часто вы ходите в кино?");
            cinemaGo = Console.ReadLine();
            Console.WriteLine("Какие у вас политические взгляды?");
            politics = Console.ReadLine();
            Console.WriteLine($"Вы {gender} по имени {name}, вам {age} лет, ходите в кино {cinemaGo}, ваши политические взгляды {politics}");
        }
    }
}

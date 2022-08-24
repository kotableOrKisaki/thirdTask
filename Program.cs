using System;

namespace thirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? \t");
            string name = Console.ReadLine();

            Console.Write("Сколько лет? \t");
            string age = Console.ReadLine();

            Console.Write("Где живешь? \t");
            string city = Console.ReadLine();

            Console.WriteLine($"Твое имя {name}, сейчас тебе {age}, и ты живешь в городе {city}");
        }
    }
}

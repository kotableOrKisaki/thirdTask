using System;

namespace thirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? \t");
            string Name = Console.ReadLine();

            Console.Write("Сколько лет? \t");
            string Age = Console.ReadLine();

            Console.Write("Где живешь? \t");
            string City = Console.ReadLine();

            Console.WriteLine($"Твое имя {Name}, сейчас тебе {Age}, и ты живешь в городе {City}");
        }
    }
}

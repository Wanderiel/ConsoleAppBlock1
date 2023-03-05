using System;

namespace ConsoleAppP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystalPrice = 50;
            int crystals;

            Console.Write($"Добро пожаловать в нашу лавку!\n" +
                $"Только сегодня и тоько у нас магические кристаллы по цене {crystalPrice} золотых!" +
                $"\nСколько у вас золота: ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Сколько кристаллов вы хотите приобести? Всего {crystalPrice} золотых за штуку: ");
            crystals = Convert.ToInt32(Console.ReadLine());

            gold -= crystalPrice * crystals;
            Console.WriteLine($"\nОтлично! Вы приобрели {crystals} шт. У вас осталость {gold} золота.");

            Console.ReadKey();
        }
    }
}
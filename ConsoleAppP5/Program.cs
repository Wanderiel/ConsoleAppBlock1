using System;

namespace ConsoleApp_Practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Дымов";
            string surname = "Павел";

            Console.WriteLine(name + " " + surname);

            (name, surname) = (surname, name);

            Console.WriteLine(name + " " + surname);

            Console.ReadKey();
        }
    }
}

using System;
using System.IO;

namespace StreamExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string [] array;
            Example example = new Example(); // Инициализация жкхемпляра класса
            FileStream file = new FileStream("test.txt", FileMode.Create); // Инициализируем FileStream и создаем и указываем имя файла
            StreamWriter write = new StreamWriter(file); // Инициализируем StreamWritter https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-5.0
            write.WriteLine(example.GetSomeValue(20, 1, 30, 40)); // Передаем массив на запись
            write.Close(); // Закрываем StreamWritter !!!
            file.Close(); // Закрываем FileStream !!
            Console.WriteLine("Все ОК!");
            Console.ReadKey();
        }
        }
}
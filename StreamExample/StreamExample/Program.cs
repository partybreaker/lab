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
            FileStream file = new FileStream("test.txt", FileMode.Create); // Создаем и указываем имя файла
            StreamWriter write = new StreamWriter(file); // Инициализируем StreamWritter https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-5.0
            write.WriteLine(example.GetSomeValue(20, 1,30,40));
            write.Close();
            file.Close();
            Console.WriteLine("Все ОК!");
            Console.ReadKey();

        }
        }
}
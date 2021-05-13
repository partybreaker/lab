using System;
using System.IO;

namespace StreamExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string [] array;
            Example example = new Example(); // Инициализация экземпляра класса Example (см. файл в проекте Example.cs)
            FileStream file = new FileStream("test.txt", FileMode.Create); // Инициализируем FileStream и создаем и указываем имя файла
            /*
             * Подобное действие производим над бинарными файлами используя BinaryWritter
             * BinaryWritter binaryW = new BinaryWritter(file);
             * binaryW(exmaple.GetSomeValue(20, 1, 30, 50);
             */
            StreamWriter write = new StreamWriter(file); // Инициализируем StreamWritter https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-5.0
            write.WriteLine(example.GetSomeValue(20, 1, 30, 40)); // Передаем значения
            /*
             * Если у нас речь о PatientList
             * foreach(PatientList patient in patients)
             * {
             *      write.WriteLine(patient);
             *      write.Close();
             * }
             */
            write.Close(); // Закрываем StreamWritter !!!
            file.Close(); // Закрываем FileStream !!
            Console.WriteLine("Все ОК!");
            Console.ReadKey();
        }
        }
}

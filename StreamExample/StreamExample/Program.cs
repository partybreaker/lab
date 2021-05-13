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
            /*
            * Документация FileStream - https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-5.0
            */
            FileStream file = new FileStream("test.txt", FileMode.Create); // Инициализируем FileStream и создаем и указываем имя файла
            /*
             * Документация BinaryWriter - https://docs.microsoft.com/en-us/dotnet/api/system.io.binarywriter?view=net-5.0
             * Подобное действие производим над бинарными файлами используя BinaryWriter
             * BinaryWriter binaryW = new BinaryWriter(file);
             * binaryW(example.GetSomeValue(20, 1, 30, 50);
             */
            StreamWriter write = new StreamWriter(file); // Инициализируем StreamWriter https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-5.0
            write.WriteLine(example.GetSomeValue(20, 1, 30, 40)); // Передаем значения
            /*
             * Если у нас речь о PatientList
             * foreach(PatientList patient in patients)
             * {
             *      write.WriteLine(patient);
             *      write.Close();
             * }
             */
            write.Close(); // Закрываем StreamWriter !!!
            file.Close(); // Закрываем FileStream !!
            Console.WriteLine("Все ОК!");
            Console.ReadKey();
        }
        }
}

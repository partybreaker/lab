using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program {
        static void Main(string[] args)
        {
            int[] array = {15, 21, 3, 42, 55};
            Console.WriteLine(Min(array));
        }
        private static int Min(params int[] array){
            int min = array[0]; // temp переменная
            for (int i = 1; i < array.Length; i++){ // проход по массиву
                min = Math.Min(min, array[i]); // нахождение минимального элемента используя класс Math
            }
            return min; // возвращает минимальный элемент
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// метод сортировки 
// https://ru.wikipedia.org/wiki/%D0%A1%D0%BE%D1%80%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%BA%D0%B0_%D0%BF%D1%83%D0%B7%D1%8B%D1%80%D1%8C%D0%BA%D0%BE%D0%BC
// алгоритмы сортировки https://www.youtube.com/watch?v=lyZQPjUT5B4
namespace ConsoleApp
{
    class Program {
        static void BubbleSort(int[] array)
        {
                //  Выводит элементы массива
            Console.WriteLine(array);
                // Основной цикл
            for (int i = 0; i< array.Length; i++){
                // Вложенный цыкл
                // Колв-о повторений в массиве минус 1 
                for (int j = 0; j < array.Length; j++)
                {
                    // Если элемент массива с индексом j больше следующего за ним элемента
                    if (array[j] > array[j + 1])
                    {
                        //Меняем местами элемент массива с индексом j и следуюзий за ним
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        public static void Swap(ref int array1, ref int array2)
        {
            // Сохраняем  значение первого элемента
            int tmpArr = array1;
            // Первый аргумент получил значение второго
            array1 = array2;
            // Второй аргумент, получает сохраненого ранее значение первого
            array2 = tmpArr;
        }
        public static void PrintArray(int[] array)
        {
            // Перебор всех элементов массива
            for (int i= 0; i < array.Length; i++){
                //Вывод значения текущего элемента
                Console.WriteLine(array[i] + " ");
                {
                    //Перевод строки
                    Console.WriteLine("\n");
                }

            }
        }
        // Создаем главный метод программы
        public void Main(string[] args){
            // Осздаем некий массив
            int[] array = new int[] {23, 12, 52, 0, 1, 6, 90};
            // Вызываем метод сортировки
            BubbleSort(array);

        }
    }
}
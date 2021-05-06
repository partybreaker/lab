using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Patient
    {
        public Patient(string name, string lastName, string middleName)
        {
            Name = name;
            LastName = lastName;
            MiddleName = middleName;
        }
        // https://metanit.com/sharp/tutorial/3.4.php
        public string Name
        {
            get;
            private set;
        }
        public string LastName
        {
            get;
            private set;
        }
        public string MiddleName
        {
            get;
            private set;
        }
        public string CardNumber
        {
            get;
            set;
        }
        public string Diagnosis
        {
            get;
            set;
        }
        public override string ToString()
        {
            // Форматированеи строки: По факту строка является массивом данных для вывода каких либо значений мы используем ссылку на элемент - {}
            return string.Format("{0} {1} {2}, мед. карта {3}, диагноз {4}", Name, LastName, MiddleName, CardNumber, Diagnosis);
            // return base.ToString();
        }
        // Создадим больного с негативной группой крови
        public static Patient operator -(Patient neg)
        {
            // Создаем экземпляр класса
            Patient result = new Patient(neg.Name, neg.MiddleName, neg.LastName);
            result.CardNumber = neg.CardNumber;
            result.Diagnosis = neg.Diagnosis;

            return result;
        }
        public static Patient operator *(Patient f, Patient s)
        {
            Patient result = new Patient(s.Name, f.MiddleName, s.LastName);
            result.CardNumber = f.CardNumber;
            result.Diagnosis = f.Diagnosis; 
            
            return result;
        }
        // Тут можно создавать свои методы добавления пользователей etc.
    }
    class Program
    {
        static void Main(string[] agrs){
            Patient[] patients = new Patient[6]; // Создаем массив из 6-ти пациентов
            patients[0] = new Patient("Иванов", "Василий", "Пупкин") // Пациент который будет в нащем списке первым (об этом свидетельствует индекс 0)
            {
                Diagnosis = "Язва", CardNumber = 1
            };
            patients[1] = new Patient("Иванов", "Василий", "Пупкин") // Пациент который будет в нащем списке первым (об этом свидетельствует индекс 0)
            {
                Diagnosis = "Язва", CardNumber = 2
            };
            patients[2] = new Patient("Иванов", "Василий", "Пупкин") // Пациент который будет в нащем списке первым (об этом свидетельствует индекс 0)
            {
                Diagnosis = "Язва", CardNumber = 3
            };
            patients[3] = new Patient("Иванов", "Василий", "Пупкин") // Пациент который будет в нащем списке первым (об этом свидетельствует индекс 0)
            {
                Diagnosis = "Язва", CardNumber = 4
            };
            patients[4] = new Patient("Иванов", "Василий", "Пупкин") // Пациент который будет в нащем списке первым (об этом свидетельствует индекс 0)
            {
                Diagnosis = "Язва", CardNumber = 5
            };
            patients[6] = new Patient("Иванов", "Василий", "Пупкин") // Пациент который будет в нащем списке первым (об этом свидетельствует индекс 0)
            {
                Diagnosis = "Язва", CardNumber = 6
            };
            Console.WriteLine("Список пациентов: ");
            foreach (Patient patient in patients) // Перебор нашего списка пациентов
            {
                Console.WriteLine(patient.ToString()); // ToString() конвертирует наш обьект в string
            }
            Console.WriteLine();
            Console.WriteLine("Пациенты с диагнозом язва: ");
            var diagnosisPatients = patients.Where(x => x.Diagnosis == "Язва"); // Поиск всех пациентов со значение язва
            foreach (Patient patient in diagnosisPatients){
                Console.WriteLine(patient.ToString());
            }
            Console.ReadKey(); // Ожидает нажатие пользователем клавиши для выхода из программы
        }
    }
}
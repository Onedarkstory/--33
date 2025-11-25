using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            {"компьютер", "Электронно-вычислительная машина для обработки информации"},
            {"программа", "Последовательность инструкций для выполнения компьютером"},
            {"алгоритм", "Конечная последовательность шагов для решения задачи"},
            {"код", "Набор символов и правил для представления информации"},
            {"разработка", "Процесс создания программного обеспечения"},
            {"база данных", "Организованная совокупность структурированной информации"},
            {"интерфейс", "Средство взаимодействия между пользователем и программой"},
            {"функция", "Блок кода, выполняющий определенную задачу"},
            {"переменная", "Именованная область памяти для хранения данных"},
            {"массив", "Структура данных для хранения набора элементов"}
        };

        bool isRunning = true;

        Console.WriteLine("=== ПРОГРАММА-СЛОВАРЬ ===");
        Console.WriteLine("Доступные команды:");
        Console.WriteLine("- Введите слово для поиска его значения");
        Console.WriteLine("- Введите 'выход' для завершения программы");
        Console.WriteLine();

        while (isRunning)
        {
            Console.Write("Введите слово: ");
            string userInput = Console.ReadLine()?.ToLower().Trim();

            if (userInput == "выход")
            {
                isRunning = false;
                Console.WriteLine("Программа завершена. До свидания!");
                continue;
            }

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Ошибка: Вы не ввели слово!\n");
                continue;
            }

            if (dictionary.ContainsKey(userInput))
            {
                string meaning = dictionary[userInput];
                Console.WriteLine($"\n {userInput.ToUpper()} - {meaning}\n");
            }
            else
            {
                Console.WriteLine($"\n Слово '{userInput}' не найдено в словаре.\n");
                Console.WriteLine("Доступные слова:");

                int counter = 1;
                foreach (var word in dictionary.Keys)
                {
                    Console.WriteLine($"{counter}. {word}");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}


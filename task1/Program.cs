﻿// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
using System;
class Program
{
    static void Main()
    {
        while (true) // Бесконечный цикл
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine(); // Чтение строки ввода пользователя
            if (input == "q") // Проверка на ввод 'q' для выхода
            {
                break;
            }
            int number;
            if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
            {
                int sum = 0;
                while (number > 0) // Вычисление суммы цифр числа
                {
                    sum += number % 10; // Добавление последней цифры к сумме
                    number /= 10; // Удаление последней цифры из числа
                }
                if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
            else // Если ввод не является числом и не символ 'q', повторяем запрос
            {
                Console.WriteLine("Некорректный ввод. Число должно быть целым или введите символ 'q' для окончания.");
            }
        }
    }
}
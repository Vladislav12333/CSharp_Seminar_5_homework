﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = new double[] { 3.22, 4.2, 1.15, 77.15, 65.2 };
double max = numbers[0];
double min = numbers[0];

foreach (double number in numbers)
{
    if (number > max)
    {
        max = number;
    }

    if (number < min)
    {
        min = number;
    }
}

double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random random = new Random();

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100);
}

int sum = 0;

for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}

Console.WriteLine("Исходный массив: {0}", string.Join(", ", array));
Console.WriteLine("Сумма элементов на нечётных позициях: {0}", sum);
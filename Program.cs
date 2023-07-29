// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSumElements(int[,] massive)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        minRow += massive[0, i];
    }
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
            sumRow += massive[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minSumRow + 1} строка");
}

void Print2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassiv(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}
int[,] massive = Create2DMassiv(4, 4, 1, 10);
Console.WriteLine("Например, задан массив:");
Print2DMassive(massive);
MinSumElements(massive);

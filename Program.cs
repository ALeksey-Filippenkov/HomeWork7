// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Create2dArray (int rows, int cols, double minValue, double maxValue)
{
    double[,] array = new double [rows, cols];
    for (int i = 0; i < rows; i++)
    {
     for (int j = 0; j < cols; j++)
     {
        array[i,j] = Math.Round(new Random().NextDouble()*(maxValue - minValue) + minValue, 2);
     }   
    }

    return array;
}
void ShowArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Создайте двумерный массив размером m на n");
System.Console.Write("Введите количество строчек (m): ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите минимальное значение : ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите масимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double [,] array = Create2dArray(m, n, minValue, maxValue);
ShowArray (array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//  возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(0,10);
//     }
//     return array;
// }
// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j]} ");
//         System.Console.WriteLine();
//     }
// }

// void ShowEllement(int[,] array, int firstIndex, int secondIndex)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == firstIndex && j == secondIndex)
//                 System.Console.WriteLine($"Эллемент под индексом {(firstIndex, secondIndex)} равен {array[i, j]}");
//         }
//     }
// }

// System.Console.WriteLine("Создайте двумерный массив размером m на n");
// System.Console.Write("Введите количество строчек (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты(индексы) для поиска числа.");
// System.Console.Write("Введите первый индекс: ");
// int firstIndex = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второй индекс: ");
// int secondIndex = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(m, n);
// ShowArray(array);
// if (firstIndex > m || secondIndex > n)
// {
//     System.Console.WriteLine($"Эллемента с индексом {(firstIndex, secondIndex)} не существует");
// }
// ShowEllement(array, firstIndex, secondIndex);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(0, 10);
//     }
//     return array;
// }
// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j]} ");
//         System.Console.WriteLine();
//     }
// }

// void ArithmeticMean(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.Write($"{sum / array.GetLength(0)} ");
//     }
// }

// System.Console.WriteLine("Создайте двумерный массив размером m на n");
// System.Console.Write("Введите количество строчек (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(m, n);
// ShowArray(array);
// System.Console.WriteLine();
// ArithmeticMean(array);

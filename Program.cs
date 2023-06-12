// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[m,n];

// void FillMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix [i,j] = Convert.ToDouble(new Random().Next(-10,10))/10;
//         }
//     }
// }

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+" ");
//         }
//     Console.WriteLine();
//     }
// }

// FillMatrix();
// PrintMatrix();


// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите номер строки");
// int rowPosition = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int columnPosition = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [5,5];

// void FillMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//             Console.Write(matrix[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }


// FillMatrix();

// if ((rowPosition < matrix.GetLength(0))
// &&(columnPosition < matrix.GetLength(1)))
// {
//     Console.WriteLine(matrix[rowPosition,columnPosition]);
// }
// else {Console.WriteLine("Такого элемента нет");}


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows,columns];

void FillMatrix()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void FindAverageInColumns()
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
        }
        Console.WriteLine($"{sum/matrix.GetLength(0)}");
    }
    Console.WriteLine();
}

FillMatrix();
FindAverageInColumns();
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[m,n];
// Random rand = new Random();
// for (int i = 0; i<m; i++)
// {
//     for (int j = 0; j<n; j++)
//     {
//         matrix[i,j]=rand.NextDouble()*100;
//     }
// }
// for (int i = 0; i<m; i++)
// {
//     for (int j = 0; j<n; j++)
//     {
//        Console.Write($"{matrix[i,j]}\t");
//     }
//     Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// int m = 3;
// int n = 4;
// int[,] matrix = new int[m,n];
// Random rand = new Random();
// for (int i = 0; i<m; i++)
// {
//     for (int j = 0; j<n; j++)
//     {
//         matrix[i,j]=rand.Next(0,101);
//     }
// }
// for (int i = 0; i<m; i++)
// {
//     for (int j = 0; j<n; j++)
//     {
//        Console.Write($"{matrix[i,j]}\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите строку");
// int k = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите столбец");
// int l = Convert.ToInt32(Console.ReadLine());

// if(k>=m || l>=n)
// {
//     Console.WriteLine("такого числа нет");
// }
// else
// {
//     Console.WriteLine(matrix[k,l]);
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//  int m = 3;
// int n = 4;
// int[,] matrix = new int[m,n];
// Random rand = new Random();
// for (int i = 0; i<m; i++)
// {
//     for (int j = 0; j<n; j++)
//     {
//         matrix[i,j]=rand.Next(0,10);
//     }
// }
// for (int i = 0; i<m; i++)
// {
//     for (int j = 0; j<n; j++)
//     {
//        Console.Write($"{matrix[i,j]}\t");
//     }
//     Console.WriteLine();
// }
// int sm = 0;
// for (int j = 0; j<n; j++)
// {
//     sm = 0;
//     for (int i = 0; i<m; i++)
//     {
//        sm = sm + matrix[i,j];
//     }
//     double avg = (double)sm/m;
//     Console.WriteLine(avg);
// }
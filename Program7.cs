/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 

double [,] array = new double [3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(100)/(double)10;
        Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
}*/

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
int [,] array = new int [3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
}

int x, y;
Console.Write($"Введите номер строки: ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write($"Введите номер столбца: ");
int.TryParse(Console.ReadLine()!, out y);

if (x < array.GetLength(0) && y < array.GetLength(1))
Console.Write($"На позиции ({x}, {y}) число {array[x, y]}");
else
Console.Write($"Такого числа в массиве нет"); */


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int [,] array = new int [3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
}
Console.Write($"Среднее арифметическое каждого столбца: ");
for (int j = 0; j < array.GetLength(1); j++)
{
   double sum =0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{Math.Round(sum / 3 ,1)}; ");
}


/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int M;
Console.Write($"Сколько чисел Вы хотите ввести? ");
int.TryParse(Console.ReadLine()!, out M);

int count = 0;

Console.WriteLine($"Введите {M} чисел");

for (int i = 0; i < M; i++)
{
    int a;
    int.TryParse(Console.ReadLine()!, out a);
    if (a > 0)
    count++;
}

Console.WriteLine($"Вы ввели {count} чисел больше нуля.");

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int b1;
Console.Write($"Введите b1: ");
int.TryParse(Console.ReadLine()!, out b1);

int k1;
Console.Write($"Введите k1: ");
int.TryParse(Console.ReadLine()!, out k1);

int b2;
Console.Write($"Введите b2: ");
int.TryParse(Console.ReadLine()!, out b2);

int k2;
Console.Write($"Введите k2: ");
int.TryParse(Console.ReadLine()!, out k2);

double x = (double) (b2-b1)/ (k1 -k2);
double y = k1*x + b1;

Console.Write($"{x}, {y}");

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("Введите 1 число");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите 2 число");
int y = int.Parse(Console.ReadLine()!);

if(x <= y)
{
    Console.WriteLine($"max = {y}.");
}
else
{    
    Console.WriteLine($"max = {x}");
}

// Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите 1 число");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите 2 число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите 3 число");
int c = int.Parse(Console.ReadLine()!);

int max1 = a;

if (a > max1) max1 = a;
if (b > max1) max1 = b;
if (c > max1) max1 = c;

Console.WriteLine($"max = {max1}");

// Напишите программу, которая на вход принимает 
//число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
Console.WriteLine ("Введите число");
int p = int.Parse(Console.ReadLine()!);

if (p % 2 != 0)
{
    Console.WriteLine($"{p} - нечетное число");
}
else
{
    Console.WriteLine($"{p} - четное число");
}

// Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные 
//числа от 1 до N

Console.WriteLine ("Введите число");
int N = int.Parse(Console.ReadLine()!);

int i = 2;

while (i <= N)
{
    Console.Write($"{i}, ");
    i += 2;
}
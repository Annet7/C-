/* **Задача 63:** Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"                    */

int N;

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

Output(N);
Console.Write(OutputStr(N));

string OutputStr(int _N, int i = 1)
{
    if (i == _N)
        return i.ToString() + "\n";
    return $"{i} {OutputStr(_N, i + 1)}";
}

void Output(int _N, int i = 1)
{
    if (i == _N)
    {
        Console.WriteLine(i);
        return;
    }
    Console.Write($"{i} ");
    Output(_N, i + 1);
}


/* **Задача 65:** Задайте значение M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"                    */

int N, M;

Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out M);

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

Output(M, N);
Console.Write(OutputStr(M, N));

string OutputStr(int i, int _N)
{
    if (i == _N)
        return i.ToString() + "\n";
    return $"{i} {OutputStr(i + 1, _N)}";
}

void Output(int i, int _N)
{
    if (i == _N)
    {
        Console.WriteLine(i);
        return;
    }
    Console.Write($"{i} ");
    Output(i + 1, _N);
}


/*       **Задача 67:** Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9               */

int N;

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

Console.Write($"{DigitSum(N)}");



int DigitSum(int _N)
{
    if (_N <= 0)
        return 0;
    return _N % 10 + DigitSum(_N / 10);
}


/*67 возвести А в степень В*/

int A, B;

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out A);

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out B); 

Console.Write($"{magic(A)}");

int magic(int _A)
{
    if (B == 0)
        return _A;
    return _A * magic( _A, B-1);
}


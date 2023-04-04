// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void Count (int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    Count(n-1);
}

Console.Clear();
int N = Numb("Введите число: ");
Console.WriteLine();
Count(N);

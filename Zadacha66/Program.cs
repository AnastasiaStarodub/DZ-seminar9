// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int SumInterval (int n, int m)
{
    if (n == m ) return n;
    else return n + SumInterval(n + 1, m);
}

Console.Clear();
int N = Numb("Введите число 1: ");
int M = Numb("Введите число 2: ");
Console.WriteLine();
Console.WriteLine($"{SumInterval(N, M)}");

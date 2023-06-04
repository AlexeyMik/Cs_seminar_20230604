// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//
void Task64()
{
    int n =ReadInt("Введите значение N");
    PrintNumbersIncreasing(n);
    System.Console.WriteLine();
    PrintNumbersDecreasing(n);
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbersIncreasing(int N)
{
    if (N < 1) return;
    PrintNumbersIncreasing(N - 1);
    System.Console.Write(N + " ");
}

void PrintNumbersDecreasing(int N)
{
    if (N < 1) return;
    System.Console.Write(N + " ");
    PrintNumbersDecreasing(N - 1);
}
Task64();

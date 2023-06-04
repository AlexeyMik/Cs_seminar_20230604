// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//
// 
void Task66()
{
    System.Console.WriteLine("Задача 66");
    int m = ReadInt("Введите натуральное число");
    int n = ReadInt("Введите натуральное число");
    if (m <= n)
        System.Console.WriteLine($"Сумма чисел= {SumOfAllBetween(m, n)}");
    else
        System.Console.WriteLine($"Сумма чисел= {SumOfAllBetween(n, m)}"); 
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfAllBetween(int m, int n)
{
    if (n < m) return 0; // нейтральное по отношению к сложению
    return n + SumOfAllBetween(m, n - 1);
}

Task66();
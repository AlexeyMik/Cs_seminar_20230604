// Задача 65м. Напишите рекурсивные функции, которые
// первая вычисляет сумму цифр числа
// вторая вычисляет произведение цифр числа
//
void Task65m()
{
    int n = ReadInt("Введите натуральное число");

    System.Console.WriteLine($"Сумма цифр числа= {SumOfFigures(n)}");
    System.Console.WriteLine($"Произведение цифр числа= {ProductOfFigures(n)}");
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfFigures(int n)
{
    if (n < 1) return 0; // нейтральное по отношению к сложению
    return n % 10 + SumOfFigures(n / 10);
}

int ProductOfFigures(int n)
{
    if (n < 1) return 1; // нейтральное по отношению к умножению
    return (n % 10) * ProductOfFigures(n / 10);
}
Task65m();
//66. Показать натуральные числа от 1 до N, N задано
void PrintN1(int n)
{
    if (n != 0)
    {
        PrintN1(n - 1);
        Console.WriteLine(n);
    }
}

//PrintN1(6);

//67. Показать натуральные числа от N до 1, N задано

void Print1N(int n)
{
    if (n != 0)
    {
        Console.WriteLine(n);
        Print1N(n - 1);
    }
}
//Print1N(6);

//68. Показать натуральные числа от M до N, N и M заданы
void PrintMN(int m, int n)
{
    if (m != n + 1)
    {
        PrintMN(m, n - 1);
        Console.WriteLine(n);
    }
}
//PrintMN(1, 8);

// 69. Найти сумму элементов от M до N, N и M заданы

int SumElements(int m, int n)
{
    if (m == n) return m;
    return m + SumElements(m + 1, n);
}
//Console.WriteLine(SumElements(1, 6));

// 70. Найти сумму цифр числа

int SumDigitsNumber(int n)
{
    if (n == 0) return n;
    return n % 10 + SumDigitsNumber(n / 10);
}
//Console.WriteLine(SumDigitsNumber(2332));

// 71. Написать программу вычисления функции Аккермана

int FunkAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else
    {
        if ((n != 0) && (m == 0)) return FunkAkkerman(n - 1, 1);
        else return FunkAkkerman(n - 1, FunkAkkerman(n, m - 1));
    }
}
//Console.WriteLine(FunkAkkerman(2, 1));

// 72. Написать программу возведения числа А в целую стень B

int Exponentiation(int a, int b)
{
    if (b == 1) return a;
    return a * Exponentiation(a, b - 1);
}
//Console.WriteLine(Exponentiation(2,10));

// 73.Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме
// двух предыдущих. Первые два элемента последовательности задаются пользователем



// 74. В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". Покажите все слова,
// состоящие из n букв, которые можно построить из букв этого алфавита.


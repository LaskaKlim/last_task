Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}  

void SumFromMToN(int m, int n)
{
    Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равна {SumMN(m - 1, n)}");
}



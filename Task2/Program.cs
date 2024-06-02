Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Оба числа должны быть неотрицательными.");
    return;
}

int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");


int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }

    return Ackermann(m - 1, Ackermann(m, n - 1));
}

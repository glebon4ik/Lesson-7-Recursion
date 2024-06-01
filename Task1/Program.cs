Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M <= 0 || N <= 0)
{
    Console.WriteLine("Оба числа должны быть натуральными (больше 0).");
    return;
}

Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}:");
PrintNumbers(M, N);


void PrintNumbers(int current, int end)
{

    if (current == end)
    {
        Console.Write(current + " ");
        return;
    }


    Console.Write(current + " ");


    if (current < end)
    {
        PrintNumbers(current + 1, end);
    }
    else
    {
        PrintNumbers(current - 1, end);
    }
}
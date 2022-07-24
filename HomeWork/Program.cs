// ДЗ к 6 семинару
void Task41()
{
    Console.WriteLine("Введите количество чисел, которые необходимо проверить на положительность?");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];
    int count = 0;
    Console.WriteLine("Введите числа для проверки на положительность.");
    for (int i = 0; i < m; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count = count + 1;
    }
    Console.WriteLine($"Из {m} введенных чисел {count} положительных.");
}

Task41();

void Task43()
{
    Console.WriteLine("Введите коэффициент k1 в уравнении y = k1*x + b1.");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b1 в уравнении y = k1*x + b1.");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2 в уравнении y = k2*x + b2.");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2 в уравнении y = k2*x + b2.");
    double b2 = Convert.ToDouble(Console.ReadLine());
    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine($"Прямые, заданные функциями y = {k1}*x + {b1} и y = {k2}*x + {b2} параллельны.");
    }
    else
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Прямые, заданные функциями y = {k1}*x + {b1} и y = {k2}*x + {b2} совпадают.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = Math.Round(k1 * x + b1, 2);
        Console.WriteLine($"Точка пересечения прямых, заданных функциями y = {k1}*x + {b1} и y = {k2}*x + {b2} :");
        Console.WriteLine($"x = {Math.Round(x, 2)}, y = {y}.");
    }
}

Task43();
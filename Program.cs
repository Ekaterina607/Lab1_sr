//Задание-1
Console.WriteLine("Введите число для которого нужно найти факториал: ");
string qqq = Console.ReadLine();
if (int.TryParse(qqq, out int result))
{
    Console.WriteLine("Результат: " + Factorial(result));
    static int Factorial(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * Factorial(n - 1);

    }
}
else
{
    Console.WriteLine("Введите число!!!");
}


//Задание-2

Console.WriteLine("Введите число для которого нужно расчитать функцию: ");
string res = Console.ReadLine();
if (int.TryParse(res, out int result2))
{
    if (result2 < 0 || result2 == 0)
    {
        Console.WriteLine("Ошибка");
    }
    else
    {
        double result22 = Func(result2);
        Console.WriteLine("Результат: " + result22);
    }
}
else
{
    Console.WriteLine("Введите число!!!");
}



static double Func(int n)
{
    double b = Math.Pow(double.E, Math.Sin(n));
    double a = Math.Sqrt(Math.Log(4.0 / n));
    double c = 1.0 / n;
    return a-c-b;
    
}

//Задание-3
Console.WriteLine("Введите число n: ");
string r3 = Console.ReadLine();
int result3;
if (int.TryParse(r3, out result3))
{
    int a = 0;
    int b = 1;
    int next;
    while (result3 > 0)
    {
        Console.WriteLine(a);
        next = a + b;
        a = b;
        b = next;
        result3--;

    }
}
else
{
    Console.WriteLine("Введите число!");
}



//Задание-4

Console.Write("Введите значение x: ");
if (!double.TryParse(Console.ReadLine(), out double x) && !int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Ошибка: введите корректное число.");
    return;
}
Console.WriteLine("Введите количество знаков после запятой: ");
int n11;
if (!int.TryParse(Console.ReadLine(), out n11))
{
    Console.WriteLine("Ошибка: введите корректное число.");
    return;
}
double p1 = 1e-6;
double result1 = TruncateDouble(ExpSeries(x, p1, n11), n11);
Console.WriteLine($"e^{x} = {result1}");
static double TruncateDouble(double value, int znaki)
{
    if (znaki< 0) throw new ArgumentException("Количество знаков не может быть отрицательным.");

    double factor = Math.Pow(10, znaki);
    return Math.Truncate(value * factor) / factor;
}

static double ExpSeries(double x, double precision, int n11)
{
    double total = 0.0;
    double term = 1.0; 
    int n = 0;

    while (Math.Abs(term) >= precision)
    {
        total += term;
        n++;
        term = term * x / n; 
    }

    return Math.Round(total, n11+1);
}




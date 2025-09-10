//Задание-1
Console.WriteLine("Введите число для которого нужно найти факториал: ");
int result = Factorial(int.Parse(Console.ReadLine()));
Console.WriteLine("Результат: " +result);
static int Factorial(int n)
{
    if (n == 0 || n==1) return 1;
    return n * Factorial(n - 1);

}

//Задание-2

Console.WriteLine("Введите число для которого нужно расчитать функцию: ");
int result2 = int.Parse(Console.ReadLine());
if (result2 < 0 || result2 == 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    double result22 = Func(result2);
    Console.WriteLine("Результат: " + result22);
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

class Teilor
{

}

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

class Func
{

}

//Задание-3

class Fibo
{

}

//Задание-4

class Teilor
{

}

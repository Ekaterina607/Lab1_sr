//Задание-1
Console.WriteLine("Введите число для которого нужно найти факториал: ");
int result = Factorial(int.Parse(Console.ReadLine()));
Console.WriteLine("Результат: " +result);
static int Factorial(int n)
{
    if (n==1) return 1;
    return n * Factorial(n - 1);

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

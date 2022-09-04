// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumNumbers(int n, int m)
{
    if (n != m)
    {
        if (n > m)
        {
            return SumNumbers(n - 1, m) + n;
            
        }
        else return SumNumbers(m - 1, n) + m;
    }
    else return m;
}

Console.Write("Input number n: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number m: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of numbers between {a} and {b} is: {SumNumbers(a, b)}");
*/
//-----------------------------------------------------------------------------------------------------------------------------


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
/*
int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return FunctionAkkerman(m - 1, 1);
    }
    if ((m > 0) && (n > 0))
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
    else
        return n + 1;
}

Console.Write("Input number m: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number n: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The value of the Ackermann function for m = {a} and n = {b} is {FunctionAkkerman(a, b)}");
*/


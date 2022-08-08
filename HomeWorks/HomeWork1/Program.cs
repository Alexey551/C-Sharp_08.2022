// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.Clear();

Console.Write("Input one number: ");
int number_one = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number_two = Convert.ToInt32(Console.ReadLine());

Console.Write("Max number: ");

if (number_one > number_two)
{
    Console.Write(number_one);
}

else
{
    Console.Write(number_two);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.Write("Input one number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max)
{
    max = number2;
}

if(number3 > max)
{
    max = number3;
}

Console.Write("max = ");
Console.Write(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.Write("This number is even");
}

else 
{
    Console.Write("This number is odd");
}  
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

Console.Write("Even numbers: ");

while(current <= number)
{
    if(current % 2 == 0)
    {
        Console.Write(current + "; ");
    }
    current ++;
}
*/
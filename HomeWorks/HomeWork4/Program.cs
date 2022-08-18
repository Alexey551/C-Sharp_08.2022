// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int Exponentiation(int numberA, int numberB)
{
int count = numberA;
    for (int current = 1; current < numberB; current++)
    {
        count = count * numberA;
    }
    return count;
}
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input power: ");
int b = Convert.ToInt32(Console.ReadLine());
int num = Exponentiation(a, b);
Console.Write($"Number {a} to the power of {b} = {num}");
*/
//-------------------------------------------------------------------------------------------------------------------------------


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumDigit(int number)
{
    int sum = 0;
    int digit = 0;
    int lenght = Convert.ToString(number).Length;
    for (int i = 0; i<lenght; i++)
    {
        digit = number % 10;
        sum += digit;
        number = number / 10;
    }
    return sum;
}
Console.Write("Input any number: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = SumDigit(a);
Console.Write($"The sum of the digits in a number {a} = {n}");
*/
//-------------------------------------------------------------------------------------------------------------------------------


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] Create(int size)
{
    int[] arrayNum = new int[size];
    for (int i=0; i<size; i++)
    {
        Console.Write($"Input number {i+1}: ");
        arrayNum[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayNum;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console. WriteLine();
}

Console.Write("Input size for array: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = Create(b);
ShowArray(myArray);
*/
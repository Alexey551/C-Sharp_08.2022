
//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSumm(int number)
{
    int sum = 0;

    for (int current = 1; current <= number; current++)
    {
        sum = sum + current;    //sum += current;
    }
    return sum;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

//int result = FindSumm(a);
//Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");

Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");
*/
//--------------------------------------------------------------------------------------------------------------------------

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Count(int number)
{
    char[] arr = number.ToString().ToCharArray();
    int count = arr.Length;
    if (arr[0] == '-') count--;
    return count;
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Count(a);
Console.WriteLine($"Tere are {result} digit in number {a}");
*/
//--------------------------------------------------------------------------------------------------------------------------

// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int FindComposition(int number)
{
    int comp = 1;

    for (int current = 1; current <= number; current++)
    {
        comp *= current; 
    }
    return comp;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindComposition(a);
Console.WriteLine($"Composition of numbers from 1 to {a} is {result}");

//Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");

*/
//--------------------------------------------------------------------------------------------------------------------------

// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < 8; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console. WriteLine();
}


Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
*/
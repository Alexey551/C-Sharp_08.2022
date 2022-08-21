//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] positiveNumber(int Size)
{
    int[] NEWArray = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        NEWArray[i] = new Random().Next(100, 1000);
    }
    return NEWArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console. WriteLine();
}

int evenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] NEWarray = positiveNumber(a);
ShowArray(NEWarray);
int result = evenNumber(NEWarray);
Console.WriteLine($"Even numbers in an array = {result}");
*/
//------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] RandomNumber(int Size, int min, int max)
{
    int[] NEWArray = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        NEWArray[i] = new Random().Next(min, max+1);
    }
    return NEWArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console. WriteLine();
}

int sumOddNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 > 0) sum += array[i];
    }
    return sum;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int c = Convert.ToInt32(Console.ReadLine());

int[] NEWarray = RandomNumber(a, b, c);
ShowArray(NEWarray);
int result = sumOddNumber(NEWarray);
Console.WriteLine($"Sum of odd numbers in an array = {result}");
*/
//------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
double[] NumberArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input number {i + 1}:  ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
double DifferenceMaxMinNumber(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double Ras = max - min;
    return Ras;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

double[] newArray = NumberArray(a);
ShowArray(newArray);
double result = DifferenceMaxMinNumber(newArray);
Console.WriteLine($"Difference between maximum and minimum array value = {result}");
*/
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Clear();
double[,] RandomDoubleArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
        Console.WriteLine();
    }
    return array;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t{Math.Round(array[i, j], 1)}");
        }
        Console.WriteLine();
    }
}

Console.Write("Input the number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());

double[,] newArray = RandomDoubleArray(a, b);
ShowArray(newArray);
*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
/*
Console.Clear();
int[,] RandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
        Console.WriteLine();
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t{array[i, j]}");
        }
        Console.WriteLine();
    }
}

bool PositionArray(int[,] array, int numberRows, int numberColumns)
{
   if (numberRows <= array.GetLength(0) && numberColumns <= array.GetLength(1)) return true; 
   else return false;
}

Console.Write("Input the number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int d = Convert.ToInt32(Console.ReadLine());
int[,] newArray = RandomArray(a, b, c, d);
ShowArray(newArray);

Console.Write("Input required rows: ");
int e = Convert.ToInt32(Console.ReadLine());
Console.Write("Input required columns: ");
int f = Convert.ToInt32(Console.ReadLine());

bool result = PositionArray(newArray, e, f);
if (result == true) Console.WriteLine($"Число в строке {e} и столбце {f} = {newArray[e, f]}");
else Console.WriteLine($"Данная позиция не существует");
*/
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
Console.Clear();
int[,] NumberArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"Input number {j + 1} for rows {i + 1}: ");
            int number = Convert.ToInt32(Console.ReadLine());
            array[i, j] = number;
        }
        Console.WriteLine();
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t{array[i, j]}");
        }
        Console.WriteLine();
    }
}

void MeanValue(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int n = 0;
        double sum = 0, result;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            n = n + 1;   
        }
        result = sum / n;
        Console.WriteLine($"Arithmetic mean of numbers in {j + 1} column = {Math.Round(result, 2)}");
    }
}

Console.Write("Input the number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] newArray = NumberArray(a, b);
ShowArray(newArray);

MeanValue(newArray);
*/

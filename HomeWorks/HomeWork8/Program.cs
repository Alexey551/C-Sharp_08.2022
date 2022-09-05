// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
            Console.Write($"\t{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void OrderArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)

            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i, j - 1])
                {
                    int temporary = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temporary;
                }
            }
    }
    Console.WriteLine();
}

Console.Write("Input the number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = NumberArray(a, b);
ShowArray(myArray);

OrderArray(myArray);
ShowArray(myArray);
*/
//----------------------------------------------------------------------------------------------------------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int MinSumRowsArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;

        Console.WriteLine($"The sum of the numbers in rows {i + 1} is {sumArray[i]}");
    }
    Console.WriteLine();
    int ResultRows = 0;
    for (int k = 0; k < array.GetLength(0) - 1; k++)
    {
        if (sumArray[k + 1] < ResultRows) ResultRows = k + 1;
    }
    return ResultRows;            
}

Console.Write("Input the number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = NumberArray(a, b);
Show2DArray(myArray);

int res = MinSumRowsArray(myArray);
Console.WriteLine($"Minimum sum of numbers in rows {res + 1}");
*/
//----------------------------------------------------------------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
Console.Clear();
int[,] Matrix1Array(int rows1, int columns1)
{
    int[,] newArray1 = new int[rows1, columns1];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            Console.Write($"Input number {j + 1} for rows {i + 1}: ");
            newArray1[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return newArray1;
}

int[,] Matrix2Array(int rows2, int columns2)
{
    int[,] newArray2 = new int[rows2, columns2];
    for (int i = 0; i < rows2; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            Console.Write($"Input number {j + 1} for rows {i + 1}: ");
            newArray2[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return newArray2;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" \t {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixProduct(int[,] matrix1Array, int[,] matrix2Array)
{
    if (matrix1Array.GetLength(0) == matrix2Array.GetLength(0) && matrix1Array.GetLength(1) == matrix2Array.GetLength(1))
    {
        int[,] productArray = new int[matrix1Array.GetLength(0), matrix1Array.GetLength(1)];
        for (int i = 0; i < matrix1Array.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1Array.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1Array.GetLength(1); k++)
                {
                    sum += matrix1Array[i, k] * matrix2Array[k, j];
                }
                productArray[i, j] = sum;
            }
        }
        return productArray;
    }
    else return matrix1Array;
}

Console.Write("Input rows1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns1: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = Matrix1Array(a, b);
ShowArray(myArray1);

Console.Write("Input rows2: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns2: ");
int d = Convert.ToInt32(Console.ReadLine());

int[,] myArray2 = Matrix2Array(c, d);
ShowArray(myArray2);

int[,] MatrixArray = MatrixProduct(myArray1, myArray2);
ShowArray(MatrixArray);
*/
//----------------------------------------------------------------------------------------------------------------------------------------------

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
Console.Clear();
int[,,] Create3DArray(int rows, int columns, int depth)
{
    int[,,] newArray = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                newArray[i, j, k] = new Random().Next(10, 20);
            }
        }
    }
    return newArray;
}

void Show3DArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"     {array[i, j, k]}");
                Console.Write($"({i}, {j}, {k})");                
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] DeleteRepeatArray(int[,,] array)
{
    int count = 0;
    int Length = (array.GetLength(0) * array.GetLength(1) * array.GetLength(2));
    int[] currentArray = new int[Length];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                currentArray[count] = array[i, j, k];
                count++;
            }

    for (int f = 0; f < Length - 1; f++)
    {
        int temp = currentArray[f];
        for (int d = f + 1; d < currentArray.Length; d++)
            if (currentArray[d] == temp) 
                currentArray[d] = new Random().Next(20, 100);
    }  

    int c = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = currentArray[c];
                c++;
            }
    return array;
}

Console.Write("Input rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input depth: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3DArray(a, b, c);
Console.WriteLine($"This is how the original matrix with repeating digits looks like: ");
Show3DArray(myArray);

int[,,] resultArray = DeleteRepeatArray(myArray);
Console.WriteLine($"This is how the matrix looks like with replaced, non-repeating digits: ");
Show3DArray(resultArray);
*/
//--------------------------------------------------------------------------------------------------------------------------------

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
Console.Clear();
int[,] SpiralArray(int size)
{
    int[,] newArray = new int[size, size];

    int current = 1;
    int i = 0;
    int j = 0;

    while (current <= newArray.GetLength(0) * newArray.GetLength(1))
    {
        newArray[i, j] = current;
        current++;
        if (i <= j + 1 && i + j < newArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= newArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > newArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t{array[i,j]}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input n: ");
int a = Convert.ToInt32(Console.ReadLine());

int[,] myArray = SpiralArray(a);
ShowArray(myArray);
*/
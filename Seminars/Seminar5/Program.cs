//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console. WriteLine();
}
/*
void FindMinMaxSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }

    Console.WriteLine("sum of negative elements is " + sumNegative);
    Console.WriteLine("sum of positive elements is " + sumPositive);
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/
//------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] replacementArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {    
        array[i] = array[i] * (-1);
    }
    return array;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(replacementArray(myArray));
*/
//------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool digitArray(int[] array, int number)
{
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input digit: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
bool digit = digitArray(myArray, num);
if (digit == true) Console.WriteLine("Данное число в массиве найдено");
else Console.WriteLine("Данное число в массиве отсутствует");
*/


//------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int Element(int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && array[i] <= b) count++;
    }
    return count;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
int result = (Element(myArray, minNum, maxNum));
Console.WriteLine(result);
*/
//------------------------------------------------------------------------------------------------------------------------------------------------------------


// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*
int[] productNumber(int[] array)
{
    int[] newArray = new int [array.Length/2];
    for(int i = 0; i < array.Length/2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newArray;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(productNumber(myArray));
*/
//------------------------------------------------------------------------------------------------------------------------------------------------------------




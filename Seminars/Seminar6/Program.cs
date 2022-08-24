// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
// 2 варианта исполнения метода ReverseArray:
// 1-й:

int[] ReverseArary(int[] array)
{
    for (int i = 0; i < array.Langht / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Lenght - 1 - i] = temp;
    }
    return array;
}
*/
// 2-й:
/*
int[] ReverseArary(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ShowArray(ReverseArary(myArray));
*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*

bool CheckTriangle(int a, int b, int c)
{
    if ((a+b>c) && (a+c>b) && (b+c>a)) return true;
    else return false;
}
Console.Write("Input fist length: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second length: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third length: ");
int z = Convert.ToInt32(Console.ReadLine());
bool result = CheckTriangle(x, y, z);
if (result == true) Console.WriteLine($"Triangle with sides: {x}, {y}, {z} exists");
else Console.WriteLine($"Triangle with sides: {x}, {y}, {z} does not exist");

*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibbonachi(int firstNumber, int secondNumber, int size)
{
    int[] array = new int [size];
    array[0] = firstNumber;
    array[1] = secondNumber;
    for(int i = 2; i < size; i++)
    {
        array[i] = array[i-2] + array[i - 1];
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input fist number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array size: ");
int z = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibbonachi(x, y, z));
*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void DecimalToBinary(int Num)
{
    string result = string.Empty;
    while (Num > 0)
    {
        result = Num % 2 + result;
        Num /= 2;
    }
    Console.WriteLine(result);
}

Console.Write("Input decimal number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Number {num} to binaty is ");
DecimalToBinary(num);

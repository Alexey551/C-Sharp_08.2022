
//Задача 1. Найти максимальное число из девяти.
/*
int a1 = 15, b1 = 21, c1 = 39,
    a2 = 12, b2 = 23, c2 = 33,
    a3 = 13, b3 = 25, c3 = 36;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;
if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
*/
//******************************************************************************************************************


//Задача 2. Найти максимальное число из девяти с использованием метода.
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 15, b1 = 21, c1 = 39,
    a2 = 12, b2 = 23, c2 = 33,
    a3 = 13, b3 = 25, c3 = 36;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);   
int max3 = Max(a3, b3, c3);   
int max = Max(max1, max2, max3);

Console.WriteLine(max);
*/
//******************************************************************************************************************


//Задача 3. Найти максимальное число из девяти с использованием массива.
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array = {11, 15, 18, 10, 8, 15, 30, 17, 5};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );
Console.WriteLine(result);
*/
//******************************************************************************************************************


//Задача 4. Найти элемент массива под номером find.
/*
int[] array = {1, 5, 8, 7, 6, 10, 18};
int n = array.Length;
int find = 10;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/
//******************************************************************************************************************


//Задача 5. Найти индекс заданного числа (find) из случайно заданного массива.
/*
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/
//******************************************************************************************************************
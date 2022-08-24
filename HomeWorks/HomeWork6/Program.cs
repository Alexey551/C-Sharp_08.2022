// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int PositivNumbers(int M)
{
    int current = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Input digit {i}: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        if (Number > 0) current++;
    }
    return current;
}

Console.WriteLine("Input col digit: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = PositivNumbers(a);
Console.WriteLine($"Positive numbers in the given list = {result}");
*/
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void IntersectionCoordinates(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Coordinates of the point of intersection of two given lines: ({x}; {y})");
}

Console.Write("Input b1: ");
double c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double c3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double c4 = Convert.ToInt32(Console.ReadLine());

IntersectionCoordinates(c1, c2, c3, c4);
*/

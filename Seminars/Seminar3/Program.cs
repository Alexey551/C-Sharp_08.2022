//Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuard(double x, double Y)
{
    if(x>0 && Y>0) return 1;
    if(x<0 && Y>0) return 2;
    if(x<0 && Y<0) return 3;
    if(x>0 && Y<0) return 1;

    return 0;
}

Console.Write("Inout first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Inout second number: ");
double xA = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuard(xA, yA);

if(quartNum == 0)
{
    Console.Write("Point on the axes!");
}
else
    Console.Write($"Point is located on {quartNum} quart");
*/


//Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void DiapCoordin(int x)
{
    if(x == 1) Console.Write("x>0 && Y>0");
    if(x == 2) Console.Write("x<0 && Y>0");
    if(x == 3) Console.Write("x<0 && Y<0");
    if(x == 4) Console.Write("x>0 && Y<0");
    if(x<1 || x>4) Console.Write("Диапазон не существует");

}

Console.Write("Введите четверть: ");
int q = Convert.ToInt32(Console.ReadLine());
DiapCoordin(q);
*/



//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double Length(double x1, double y1, double x2, double y2)
{
    //double sqr = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    double sqr = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2));
    return sqr;
}

Console.Write("Введите координаты первой точки по оси Х: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Х: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Х: ");
double yB = Convert.ToDouble(Console.ReadLine());

double len = Length(xA, yA, xB, yB);
Console.Write("Длина отрезка равна " + len);
*/



//Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.
/*
void QuardN(int n)
{
    for(int i=1; i<=n; i++)
    {
        Console.Write(i*i + " ");
    }
}

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Квадраты чисел от 1 до {num} равны ");
QuardN(num);
*/
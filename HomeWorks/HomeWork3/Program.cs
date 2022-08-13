
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
void Palind(int number)
{
    int first = number / 10000;
    int second = number / 1000 % 10;
    int fourth = number % 100 / 10;
    int fifth = number % 10;

    if(first == fifth)
    {
        if(second == fourth)
        {
            Console.WriteLine("Данное число является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}
Console.WriteLine("Введите любое пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Palind(n);
*/
//------------------------------------------------------------------------------------------------------------------------------



//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Lenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double sqr = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return sqr;
}

Console.WriteLine("Введите координаты двух точек в трехмерном пространстве: ");
Console.Write("Введите координату x1: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2: ");
double zB = Convert.ToDouble(Console.ReadLine());

double n = Lenght(xA, yA, zA, xB, yB, zB);
Console.Write("Длина отрезка равна: " + n);
*/
//------------------------------------------------------------------------------------------------------------------------------



//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*
void cubeNumber(int number)
{
    int count =1;
    while(count <= number)
    {
        Console.Write(Math.Pow(count, 3) + "; ");
        count++;
    }
}
Console.Write("Введите любое целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов чисел от 1 до {n} выглядит так: " );
cubeNumber(n);
*/
//------------------------------------------------------------------------------------------------------------------------------

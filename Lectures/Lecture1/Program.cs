//Задача 1.
/*
Console.WriteLine("Hello, World!");
*/
//*******************************************************************************************************

//Задача 2. Приветствие.
/*
Console.Write("Введите ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);
*/
//*******************************************************************************************************

//Задача 3. Сумма случайных чисел.
/*
int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/
//*******************************************************************************************************

//Задача 4. Деление вещественных чисел.
/*
double numberA = 12;
double numberB = 5;
Console.WriteLine(numberA/numberB);
*/
//*******************************************************************************************************

//Задача 5. Приветствие с Машей.
/*
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")                         // username.ToLower() - команда позволит не обращать внимание на то, каким регистром вводится имя.
{
    Console.WriteLine("Ура, это же Маша!!!");
}
else
{
    Console.Write("Привет,  ");
    Console.WriteLine(username);
}
*/
//*******************************************************************************************************

//Задача 6. Задача с гирями, найти максимальную.
/*
int A = 1;
int B = 2;
int C = 6;
int D = 8;
int E = 4;

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;
if (D > max) max = D;
if (E > max) max = E;

Console.Write("max = ");
Console.WriteLine(max);
*/
//*******************************************************************************************************

//Задача 7. Треугольник.
/*
Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("*");

// int xa = 1;
// int ya = 1;
// int xb = 1;
// int yb = 30;
// int xc = 40;
// int yc = 30;

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);     // [0;3)  0  1  2
    if(what == 0)
    {
        x = (x + xa)/2;  
        y = (y + ya)/2;
    }

    if(what == 1)
    {
        x = (x + xb)/2;  
        y = (y + yb)/2;
    }

    if(what == 2)
    {
        x = (x + xc)/2;  
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1;                // можно заменить    count +=1  или    count++
}
*/
//*******************************************************************************************************
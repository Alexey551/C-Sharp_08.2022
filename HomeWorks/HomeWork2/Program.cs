// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int SecondDigit(int number)
{
    int LastTwoDigit = number % 100;
    int secondDigit = LastTwoDigit / 10;

    return secondDigit;
}

Console.Write("Input any three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
int secondNumber = SecondDigit(n);

Console.Write($"Second digit of {n} is {secondNumber}");
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
void ThirdNumber(int number)
{
    int num;
    if(number < 100) Console.Write("No third number");
    
    if(number >= 100 && number <1000)
    {
        num = number % 10;
        Console.Write($"The third number is:  {num}");
    }
    
    if(number > 1000)
    {
        while(number > 1000)
        {
            number = number / 10;
        }
        num = number % 10;
        Console.Write($"The third number is:  {num}");
    }
}
Console.Write("Enter any positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
ThirdNumber(n);
*/


// А МОЖНО И ТАК:
/*
string thirdDigit(string number)
{
    string numberDigit = Convert.ToString(number);
    if (numberDigit.Length > 2)
    {
        Console.Write($"The third number is: {numberDigit[2]}");
    }
    else
    {
        Console.Write("No third number"); 
    }
    return numberDigit;
}
Console.Write("Enter any positive number: ");
string num = Convert.ToString(Console.ReadLine());
thirdDigit(num);
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
int WeekDay(int number)
{
    if(number == 6 || number == 7)
    {
        Console.Write("It is a day off");
    }
    else
    {
        Console.Write("It is a work day");
    }
    return number;

}

Console.Write("Enter the day of the week (1 to 7): ");
int n = Convert.ToInt32(Console.ReadLine());
int day = WeekDay(n);
*/
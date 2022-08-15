// Первые две группы — так называемые void методы, которые ничего не возвращают
// Первая группа методов — не принимает никаких аргументов и ничего не возвращают.
/*
void Metod1()
{
Console.WriteLine("Автор …");
}
Metod1();
*/
//---------------------------------------------------------------------------------------

// Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают.
/*
void Metod2(string msg)     //- где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{ 
    Console.WriteLine(msg); //— оператор, в скобках указан принятый аргумент.
} 
Metod2("Текст сообщения");
*/

// Именованные аргументы

/*
void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); //- где переменная count отображает на экране определённое количество сообщений msg.
        i++;
    }
}
//Metod21("Текст", 4);            //- метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4.
Metod21(count: 4, msg: "Текст");
*/
//---------------------------------------------------------------------------------------

// Третья группа методов — может что-то возвращать, но не принимает никаких аргументов. Например, может служить для генерации случайных данных.
/*
int Metod3()                       //- не принимает никакие аргументы
{
    return DateTime.Now.Year;          //- обязательное использование оператора return,
}
int year = Metod3();                //- вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);
*/
//---------------------------------------------------------------------------------------

// Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то возвращает для дальнейшей работы.
/*
string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  // Изначально можно и нужно в неё положит какое-то значение. Этим значением является пустая строка, чтобы не только вы понимали написанный код, более правильно, будет написать string.Empty.
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "V ");
Console.WriteLine(res);
*/
//---------------------------------------------------------------------------------------

// ЦИКЛ FOR
/*
string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i<count; i++)     //- вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "V ");
Console.WriteLine(res);
*/
//---------------------------------------------------------------------------------------

//ЦИКЛ В ЦИКЛЕ
// Таблица умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

// Тренировочная задача
// Использование методов и цикла for
// Задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с».

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)  // char указывает конкретныый символ
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ' , '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
*/
//---------------------------------------------------------------------------------------


// Задача. Упорядочить массивы.
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    } 
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/


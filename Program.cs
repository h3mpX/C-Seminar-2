//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


/*
int MidNum(int num)
{
    int number = (num % 100) / 10;
    return number;
}

Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 || number < 100)
{
    Console.Write("You entered incorrect number");
}
else
{
    Console.Write(MidNum(number));
}

*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int ThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Вы ввели неподходящее число");
}
else
{
    if (number / 100 != 0)
    {
        Console.WriteLine($"Третьей цифрой в числе {number} является {ThirdDigit(number)}");
    }
    else
    {
        Console.WriteLine("Третья цифра в введенном числе отсутствует");
    }
}







//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*

bool Weekend(int number)
{
    if(number == 7 || number == 6)
    {
    return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите цифру, обозначающую день недели: "); 
int number = Convert.ToInt32(Console.ReadLine());

if(number > 7 || number < 1)
{
    Console.Write("Вы ввели неподходящую цифру");
}
else
{
    if((Weekend(number)))
    {
    Console.Write("Зачилься, это выходной");
    }
    else
    {
        Console.Write("Работай, негр, солнце еще высоко");
    }
}

*/
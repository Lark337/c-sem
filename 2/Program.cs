// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Sec(int num)
{
    int res = num / 10;
    res = res % 10;
    return res;
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Вторым числом является: {Sec(num)}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Sec(int num)
{
    int count = 0;
    int res1 = num;
    while (res1 > 0)
    {
        res1 = res1 / 10;
        count++;
    }
    if (count < 3)
    {
        res1 = -1;
        return res1;
    }
    while (count != 3)
    {
        num = num / 10;
        count--;
    }
    res1 = num % 10;
    return res1;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Sec(num);
if (result < 0 )
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write($"Третьей цифрей является {result}");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Check(int num)
{
    if(num == 6 || num ==7)
        return true;
    else
        return false;
}

Console.Write("Введите какой по счету нужный день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if(Check(num) == false)
    Console.Write("Этот день не является выходным");
else
   Console.Write("Этот день является выходным"); 
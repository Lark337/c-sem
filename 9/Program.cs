// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    Console.Write($"{n} "); 
    if(n>1) ShowNumbers(n-1);
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum(int m, int n)
{
    if(m<n) return FindSum(m+1,n) + m;
    else if (m>n) return FindSum(m-1,n) + m;
    else return m;
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSum(m,n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunktion(int m,int n)
{
    if (m==0) return n+1;
    else if (m>0 && n==0) return AkkermanFunktion(m-1,1);
    else if (m>0 && n>0) return AkkermanFunktion(m-1,AkkermanFunktion(m,n-1));
    return 0;
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m>=0 && n>=0) Console.WriteLine(AkkermanFunktion(m,n));
else Console.WriteLine("Введенные числа не являются положительными");

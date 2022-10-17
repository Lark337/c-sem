// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1==n2)
{
    Console.Write("Числа равны");
}
else
{
   if (n1 > n2)
   {
    Console.WriteLine($"{n1} больше {n2}");
   }
   else
   {
    Console.WriteLine($"{n2} больше {n1}");
   }
} 
*/

// Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if (n2 > max)
{
    max = n2;
}
if (n3 > max)
{
    max = n3;
}
Console.Write($"Максимальным числом является: {max}"); 
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if ( n % 2 == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число нечётное");
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int cnumber = 2;
Console.Write("Чётные числа:");
while (cnumber <= n )
{
    Console.Write(" " + cnumber);
    cnumber = cnumber + 2;
} 
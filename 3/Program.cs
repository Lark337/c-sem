// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Check (int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
    Console.Write($"Число {num} является палиндромом");
    else
    Console.Write($"Число {num} не является палиндромом");     
}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Check(num);
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Lenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    res = Math.Round(res,2);
    return res;
}

Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Расстояние между точками равно: {Lenght(x1,y1,z1,x2,y2,z2)}");
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(double num)
{
    double current = 1;
    double res = 0;
    while (current <= num)
    {
        res = Math.Pow(current,3);
        Console.Write(res + " ");
        current++;
    }
}

Console.Write("Введите натуральное число: ");
double num = Convert.ToDouble(Console.ReadLine());
Cube(num);

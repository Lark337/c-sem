// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int [] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}

int CountNaturalNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

Console.WriteLine("Введите колличество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine($"Колличество цифр больше нуля: {CountNaturalNumbers(array)}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] PointOfIntersection(double k1, double b1, double k2, double b2)
{
    double[] point = new double[2];
    double x = (b2-b1) / (k1-k2);
    x = Math.Round(x,2);
    double y = k1 * x +b1;
    y = Math.Round(y,2);
    point [0] = x;
    point [1] = y;
    return point;
}

void ShowPoint(double[] array)
{
    Console.Write ($"({array[0]},{array[1]})");
    Console.WriteLine();
}

Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)  Console.WriteLine("Точек пересечения нет, так как прямые параллельны");
        else
        {
            double[] point = PointOfIntersection(k1,b1,k2,b2);
            Console.WriteLine($"Точка пересечения:");
            ShowPoint(point);
        }
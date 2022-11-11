// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Expon(int a, int b)
{   
    int res = a;
    for(int i = 1; i < b; i++)
    {
        res *= a;
    }
    return res;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат равен: {Expon(a,b)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    int res = 0;
    int count = 0;
    int tempNum = num;
    while (tempNum != 0)
    {
        tempNum /= 10;
        count++;
    }
    for (int i = count - 1; num != 0; i--)
    {
        int j = i;
        tempNum = 1;
        while(j != 0)
        {
            tempNum *= 10;
            j--;
        }
        res += num / tempNum;
        num %= tempNum;
    }
    return res;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел равна: {Sum(num)}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} компонент массива");
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
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);

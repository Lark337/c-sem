//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue+1);
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
/*
int ShowEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,100,1000);
ShowArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {ShowEven(array)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int Sum(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,-99,99);
ShowArray(array);
Console.WriteLine($"Сумма эелементов, стоящих на нечётных позициях равна: {Sum(array)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomDoubleArray (int size,int minValue, int maxValue)
{
    int[] array1 = new int[size];
    double[] array = new double[size];
    for (int i = 0; i<size; i++)
    {
        array1[i] = new Random().Next(minValue,maxValue);
    }
    for (int i = 0; i<size; i++)
    {
        array[i] = Convert.ToDouble(array1[i]);
    }
    double[] array2 = new double[size];
    for (int i = 0; i<size; i++)
    {
        array2[i] = Math.Round(new Random().NextDouble(),2);
    }
    for (int i = 0; i<size; i++)
    {
        array[i] += array2[i];
    }
    return array;
}
void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}

double Diff (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
        min = array[i];
        if (array[i]>max)
        max = array[i];
    }
    double res = Math.Round(max - min,2);
    return res;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[] array = CreateRandomDoubleArray(size,minValue,maxValue); 
ShowDoubleArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {Diff(array)}");


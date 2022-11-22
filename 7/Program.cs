// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandomDouble2dArray (int rows,int columns,int minValue, int maxValue)
{
    int[,] array1 = new int[rows,columns];
    double[,] array = new double[rows,columns];
    for (int i = 0; i<rows; i++)
        for ( int j = 0; j<columns; j++)
            array1[i,j] = new Random().Next(minValue,maxValue);
    for (int i = 0; i<rows; i++)
        for ( int j = 0; j<columns; j++)
            array[i,j] = Convert.ToDouble(array1[i,j]);
    double[,] array2 = new double[rows,columns];
    for (int i = 0; i<rows; i++)
        for ( int j = 0; j<columns; j++)
            array2[i,j] = Math.Round(new Random().NextDouble(),2);
    for (int i = 0; i<rows; i++)
        for ( int j = 0; j<columns; j++)
            array[i,j] += array2[i,j];
    return array;
}
void ShowDouble2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write (array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальноек значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandomDouble2dArray(rows,columns,minValue,maxValue);
ShowDouble2dArray(array);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i<rows; i++)
        for ( int j = 0; j<columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0 ; i<array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool CheckElement(int[,] array, int row, int column)
{
    if(row < array.GetLength(0) && column < array.GetLength(1))
        return true;
    else
        return false;
}


Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальноек значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,columns,minValue,maxValue);
Show2dArray(array);

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine())-1;
if (CheckElement(array,row,column))
{
    int element = array[row,column];
    Console.WriteLine(element);
}
else
    Console.WriteLine("Такого элемента в массиве нет");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i<rows; i++)
        for ( int j = 0; j<columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0 ; i<array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ArithmeticalMean(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    for (int j = 0; j<array.GetLength(1); j++)
    {
        {
            for ( int i = 0; i<array.GetLength(0); i++)
        
                sum[j] += array[i,j];
        }
    }
    for ( int i = 0; i<array.GetLength(1); i++)
    {
        sum[i] /= array.GetLength(0);
        sum[i] = Math.Round(sum[i],2);
    }
    return sum;
}

void ShowArithmeticalMean(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + "; ");
    }
    Console.WriteLine();
}

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальноек значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows,columns,minValue,maxValue);
Show2dArray(array);
double[] arithMean = ArithmeticalMean(array);
ShowArithmeticalMean(arithMean);


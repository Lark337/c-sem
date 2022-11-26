// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
/*
int[,] DescendingRow(int[,] array)
{
    int temp = 0;
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for ( int j = 0; j<array.GetLength(1); j++)
            for ( int t = j+1; t<array.GetLength(1); t++)
            {
                if (array[i,t]>array[i,j])
                {
                    temp = array[i,t];
                    array[i,t] = array[i,j];
                    array[i,j] = temp;
                }
            }
            
        
    }
    return array;
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
int [,] descRowArray = DescendingRow(array);
Show2dArray(descRowArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int FindMinSum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minSumIndex = 0;
    for (int j = 0; j<array.GetLength(1); j++)
        minSum += array[0,j];
    if (array.GetLength(0) > 1)
    {
        for (int i = 1; i<array.GetLength(0); i++)
        {
            for ( int j = 0; j<array.GetLength(1); j++)
            {
                sum += array[i,j];
            }
            if (sum < minSum) 
            {    
                minSum = sum;
                minSumIndex = i;
            }
            sum = 0;
        }
    }
    return minSumIndex;
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
Console.WriteLine($"Наименьшая сумма в {FindMinSum(array)+1} строке");
*/

//

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] res = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for(int k = 0 ; k<matrix1.GetLength(0); k++)
        for(int i = 0; i<matrix2.GetLength(1); i++)
            for(int j = 0; j < matrix1.GetLength(1); j++)
            {
                res[k,i] += matrix1[k,j] * matrix2[j,i];
            }
    return res;
}

Console.Write("Введите колличество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальноек значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandom2dArray(rows1,columns1,minValue,maxValue);
int[,] matrix2 = CreateRandom2dArray(rows2,columns2,minValue,maxValue);
Show2dArray(matrix1);
Show2dArray(matrix2);
if(matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] res = MultMatrix(matrix1,matrix2);
    Show2dArray(res);
}
else 
{
    int[,] res = MultMatrix(matrix1,matrix2);
    Console.Write("Произведение матриц: ");
    Console.WriteLine(res);
}
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray (int first, int second, int third)
{
    int[,,] array = new int[first,second,third];
    bool same = false;
    for (int i = 0; i<first; i++)
        for ( int j = 0; j<second; j++)
            for ( int k = 0; k<third; k++)
            {
                do
                {
                    same = false;
                    array[i,j,k] = new Random().Next(10,100);
                    {
                        for (int l = 0; l < first; l++)
                            for (int m = 0; m < second; m++)
                                for (int n = 0; n < third; n++)
                                {
                                    if(i == l && j ==m && k == n) break;
                                        if(array[i,j,k] == array[l,m,n]) same = true;
                                }
                    }
                } while (same);
            }
    return array;
}
void Show3dArray(int[,,] array)
{
    for(int i = 0 ; i<array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for ( int k = 0; k<array.GetLength(2); k++)
                Console.Write ($"{array[i,j,k]} ({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Write("Введите колличество элементов первой грани: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество элементов второй грани: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество элементов третьей грани: ");
int third = Convert.ToInt32(Console.ReadLine());
if(first*second*third < 89)
{
    int[,,] array = CreateRandom3dArray(first,second,third);
    Show3dArray(array);
}
else Console.WriteLine("Превышено максимальное колличество элементов");
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateSpiral2dArray (int rows, int columns)
{
    int[,] array = new int[rows,columns];
    int count = 0;
    int current = 1;
    int numbers = rows * columns;
    int currentRow = 0;
    int currentColumn = 0;
    do
    {
        currentRow = rows - count - 1;
        currentColumn = columns - count - 1;
        for (int k = count; k <= currentColumn; k++)
        {
            array[count,k] = current;
            current++;
        }
        if (current > numbers) break;
        for (int k = count+1; k <= currentRow; k++)
        {
            array[k,currentColumn] = current;
            current++;
        }
        if (current > numbers) break;
        for(int k = currentColumn-1; k >= count; k--)
        {
        array[currentRow,k] = current;
        current++;
        }
        if (current > numbers) break;
        for (int k = currentRow-1; k > count; k--)
        {
            array[k,count] = current;
            current++;
        }
        count++;
        Console.WriteLine($"psss{current}");
    }
    while (current < numbers);
    if(rows == columns && rows%2 != 0) array[rows-1-rows/2,columns - 1 - columns/2] = current;
    return array;
}

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateSpiral2dArray(rows,columns);
Show2dArray(array);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность массива?");
Console.WriteLine("Введите колличество строк?");
int rowsCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов?");
int colsCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальный размер элемента?");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальный размер элемента?");
int maxValue = int.Parse(Console.ReadLine());
int[,] array = GetArray(rowsCount, colsCount, minValue, maxValue);
PrintArray(array);

int[,] GetArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindAverageOfCols(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average = (average + array[i, j]);
        }
        average = average / rowsCount;
        Console.Write(average + "; ");
    }
}

System.Console.WriteLine("Среднее арифметическое столбцов: ");
FindAverageOfCols(array);
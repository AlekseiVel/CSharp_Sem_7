// Задача 51: Задайте двумерный массив, заполните его случайными числами. 
// Найдите сумму элементов на главной диагонали (главная диагональ – 
// это те элементы, которые имеют индекс (0, 0), (1, 1)…).
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int[,] array = GetArrayRandom(5,5, -5, 5);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Сумма элементов на главной диагонали: " + ArraySumOfMain(array));

int[,] GetArrayRandom(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];

    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int ArraySumOfMain(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            count = count + array[i, j];
        }
    }
    return count;    
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

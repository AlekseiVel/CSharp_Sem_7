// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// нечётные, и замените эти элементы на их квадраты.


Console.Clear();

// Console.WriteLine("Введите размерность массива?");
// Console.WriteLine("Введите колличество строк?");
// int rowsCount = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов?");
// int colsCount = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rowsCount, colsCount);
// PrintArray(array);

int[,] array = GetArrayRandom(3,4, -10, 10);
PrintArray(array);
System.Console.WriteLine();
ArraySort(array);
PrintArray(array);

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

void ArraySort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i %2 > 0 && j %2 > 0)
            array[i, j] = array[i, j] * array[i, j];
        }
    }    
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
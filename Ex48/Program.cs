// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

Console.WriteLine("Введите размерность массива?");
Console.WriteLine("Введите колличество строк?");
int rowsCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов?");
int colsCount = int.Parse(Console.ReadLine());
int[,] array = GetArray(rowsCount, colsCount);
PrintArray(array);

int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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
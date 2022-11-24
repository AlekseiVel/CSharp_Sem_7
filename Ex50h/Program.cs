//Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            array[i, j] = new Random().Next(0, 10);
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

void FindElementByIndex(int[,] array, int rowNumber, int colNubmer)
{
    if(rowNumber > array.GetLength(0) && colNubmer > array.GetLength(1))
    {
        System.Console.WriteLine("Вы вышли за пределы массива. ОШИБКА! ОШИБКА! ОШИБКА!");
    }
    System.Console.Write("Искомый элемент: ");
    System.Console.WriteLine(array[rowNumber, colNubmer]);
}

Console.WriteLine("Введите индекс строки искомого элемента?");
int rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца искомого элемента?");
int colNumber = int.Parse(Console.ReadLine());
FindElementByIndex(array, rowNumber, colNumber);

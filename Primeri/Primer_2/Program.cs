// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] GenerateArray(int r, int c)
{
    int[,] array = new int[r, c]; 
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
    }
    Console.WriteLine();
}

int [,] MinSumElemints(int[,] array)
{
    int mRow = 0;
    int mSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        mRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < mRow)
        {
            mRow = sumRow;
            mSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{mSumRow + 1} строка");
    Console.WriteLine();
    return array;
}

int [,] MyArray = GenerateArray(5,5);
PrintArray(MyArray);
System.Console.WriteLine();
PrintArray(MinSumElemints(MyArray));
// Напишите программу, которая заполнит спирально квадратный массив.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];

int [,] FillArraySpiral(int[,] array)
{   
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size * size)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
        ++j;
        else if (i < j && i + j >= size - 1)
        ++i;
        else if (i >= j && i + j > size - 1)
        --j;
         else
        --i;
        ++num;
    }
return array;
}

PrintArray(FillArraySpiral(array));



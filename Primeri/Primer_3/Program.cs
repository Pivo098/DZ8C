// Задача 3 * : Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[,] GenerateArray(int n, int m)
{
    int[,] array = new int[n, m]; 
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

int [,] Multiply(int [,] array1, int [,] array2, int[,] resultM)
{
    for (int i = 0; i < resultM.GetLength(0); i++)
    {
        for (int j = 0; j < resultM.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)          // у меня выдает ошибку с подсчётами
            {
                sum += array1[i, k] * array2[k ,j];
            }
            resultM[i, j] = sum;
        }
    }
    return resultM;
}

int k = InputNumbers("Введите число строк 1-й матрицы: ");
int l = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int[,] array1 = GenerateArray(k,l);
PrintArray(array1);
System.Console.WriteLine();
int[,] array2 = GenerateArray(k,p);
PrintArray(array2);
int[,] result = new int[l,p];
result = Multiply(array1, array2, result);
PrintArray(result);
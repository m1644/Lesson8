// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max) // Задать двумерный массив
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr) // Печать двумерного массива
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

void Ordering(int[,] arr) // Замена строк на столбцы
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        int[,] nums = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                nums[m, n] = arr[m, n];
            }
        }
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                arr[m, n] = nums[n, m];
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}
int[,] matrix = CreateMatrix(3, 3, 0, 99);
PrintMatrix(matrix);

Console.WriteLine();
Ordering(matrix);
PrintMatrix(matrix);

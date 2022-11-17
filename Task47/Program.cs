
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] arr = GetArray(rows, columns, 0,10);
PrintArray(arr);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
        //Console.Write($"{numbers[i]} ");
    }
    return result;
}

void PrintArray(double[,] doubArray)
{
    for(int i=0; i<doubArray.GetLength(0); i++)
    {
        for(int j=0; j<doubArray.GetLength(1); j++)
        {
            Console.Write($"{doubArray[i,j] } ");
        }
        Console.WriteLine();
    }
}


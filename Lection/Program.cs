// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
//местами первую и последнюю строку массива.

// Console.Clear();
// Console.Write("Введите количество строк массива: ");    // Строки.
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: "); // Столбцы. 
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);          // Метод № 1 - формирование массива.
// PrintArray(array);                                      // Метод № 2 - печать. 
// Console.WriteLine();
// int[,] newArray = ChangeRows(array);                    // Метод № 3 - изменение массива. 
//  PrintArray(newArray);                                  // Метод № 3 - печать.
//  // МЕТОДЫ
// int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод № 1 - формирование массива. 
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)                 // Метод № 2 - печать массива.                  
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ChangeRows(int[,] array)
// {
//     int[,] result = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == 0) result[i, j] = array[array.GetLength(0) - 1, j];
//             else if (i == array.GetLength(0)-1) result[i, j] = array[0, j];
//             else result[i, j] = array[i, j];
//         }
//     }
//     return result;
//}










//Задача 55: Задайте двумерный массив. Напишите программу, которая 
//заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.


// Console.Clear();
// Console.Write("Введите количество строк массива: ");    // Строки.
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: "); // Столбцы. 
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);          // Метод № 1 - формирование массива.
// PrintArray(array);                                      // Метод № 2 - печать. 
// Console.WriteLine();

// if(rows == columns)
// {
//     int[,] newArray = ChangeArray(array);                    // Метод № 3 - изменение массива. 
//     PrintArray(newArray);
// }
// else
// {
//     Console.WriteLine("Количество строк не равно количеству столбцов. Невозможно перевернуть массив.");
// }
// // МЕТОДЫ
// int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод № 1 - формирование массива. 
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)                 // Метод № 2 - печать массива.                  
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ChangeArray(int[,] array)
// {
//     int[,] result = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[i, j] = array[j, i];
//         }
//     }
//     return result;
// }



//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

Console.Clear();
Console.Write("Введите количество строк массива: ");    // Строки.
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: "); // Столбцы. 
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное минимальное значение в массиве: "); //  
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное максимальное значение в массиве: "); //  
int maxValue = int.Parse(Console.ReadLine()!);
// int size = maxValue - minValue;                             
int[,] array = GetArray(rows, columns, minValue, maxValue);          // Метод № 1 - формирование массива.
PrintArray(array);                                                   // Метод № 2 - печать. 
Console.WriteLine();
int[] newArray = NumsElements(array, maxValue);                          // Метод № 3 - изменение массива. 
for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] != 0) Console.WriteLine($"Элемент {i} встречается {newArray[i]} раз(а).");
}
    // МЕТОДЫ
int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод № 1 - формирование массива. 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)                 // Метод № 2 - печать массива.                  
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] NumsElements(int[,] array, int maxValue)
{
    int[] result = new int[maxValue];

    for (int index = 0; index < maxValue; index++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == index) count = count + 1;
            }
        }
        result[index] = count; 
    }
    return result;
}


// int[] GetRowArray(int[,] inArray)
// {
//     int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
//     int index=0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[index] = inArray[i,j];
//             index++;
//         }
//     }
//     return result;
// }
// void PrintData(int[] inArray)
// {
//     int el=inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if(inArray[i]!=el)
//         {
//             Console.WriteLine($"{el} встречается {count}");
//             el=inArray[i];
//             count=1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"{el} встречается {count}");
// }
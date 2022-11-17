// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Write("Введите позицию эемента в строке (от ноля): ");
int RowPos = int.Parse(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце (от ноля): ");
int ColPos = int.Parse(Console.ReadLine());

int[,] numbers = new int[4, 6];
FillArray(numbers);
PrintArray(numbers);

if (RowPos < numbers.GetLength(0) && ColPos < numbers.GetLength(1)) Console.WriteLine(numbers[RowPos, ColPos]);
else Console.WriteLine($"{RowPos}, {ColPos} -> такого числа в массиве нет");


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
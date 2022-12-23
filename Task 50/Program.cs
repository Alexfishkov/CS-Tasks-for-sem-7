// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(10,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int lines = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);

int[,] ourArray = new int[lines, columns];

FillArray(ourArray);

Console.Clear();
PrintArray(ourArray);
Console.WriteLine("Определяем есть ли в заданном массиве элемент с указаными вами позициями");
Console.Write("Введите номер строки (от 0 до 10)=> ");
int nLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца (от 0 до 10)=> ");
int nColumn = Convert.ToInt32(Console.ReadLine());

if (nColumn < columns && nLine < lines)
{
    Console.WriteLine($"Такой элемент есть в массиве, его значение: {ourArray[nLine, nColumn]}");
}
else Console.WriteLine("Элемента с такими координатами нет");
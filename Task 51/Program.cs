// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11,100);
            
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
}

int MainDiagonalSum (int [,] array)
{
    int sum = 0;
    int border = 0;
    if (array.GetLength(0)>array.GetLength(1)) border = array.GetLength(1);
    else border = array.GetLength(0);

    for (int i = 0; i < border; i++)
    {
        sum +=array[i,i];        
    }

    return sum;
}

Console.Clear();
Console.WriteLine("Задайте двумерный массив из целых чисел, а комп посчитает сумму его элементов на главной диагонали");
Console.Write("Введите число строк в массиве=> ");
int nLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве=> ");
int nColumns = Convert.ToInt32(Console.ReadLine());

int[,] ArrayInt = new int[nLines, nColumns];

FillArray(ArrayInt);
Console.Clear();
Console.WriteLine("Вы задали такой массив:");
PrintArray(ArrayInt);
Console.WriteLine($"Сумма элементов главной диагонали = {MainDiagonalSum(ArrayInt)}");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​m = 3, n = 4.
// ​0,5 7 -2 -0,2
// ​1 -3,3 8 -9,9
// ​8 7,8 -7,1 9

void FillArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().NextDouble()*198-99;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Задаём двумерный массив размером [mxn] и заполняем его случайными вещественными чмслами в диапазоне [-99,99]");
Console.Write("Введите число строк в массиве=> ");
int nLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве=> ");
int nColumns = Convert.ToInt32(Console.ReadLine());

double[,] ArrayDouble = new double[nLines, nColumns];

FillArray(ArrayDouble);
Console.WriteLine("Вот такой массив получился:");
PrintArray(ArrayDouble);



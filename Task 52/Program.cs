// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    Console.WriteLine($"Вам необходимо указать {array.Length} элементов массива (целые числа)");
    int nElement = 1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите {nElement}-й элемент массива => ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
            nElement++;
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

void AritmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double arithMean = 0.00;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arithMean = sum / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое в {j + 1} столбце = {arithMean:f2}");
    }
}

Console.Clear();
Console.WriteLine("Задайте двумерный массив из целых чисел и укажите его элементы, а комп посчитает среднее арифметическое в каждом столбце");
Console.Write("Введите число строк в массиве=> ");
int nLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве=> ");
int nColumns = Convert.ToInt32(Console.ReadLine());

int[,] ArrayInt = new int[nLines, nColumns];

FillArray(ArrayInt);
Console.Clear();
Console.WriteLine("Вы задали такой массив:");
PrintArray(ArrayInt);
AritmeticMean(ArrayInt);





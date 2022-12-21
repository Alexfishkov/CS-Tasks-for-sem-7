// Доп. задача: Вывести первые N строк треугольника Паскаля
// Вывод строк без приведения к центрированному формату

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Выводим N строк (начиная с 0) в треугольнике Паскаля");
Console.Write("Введите целое N(>1)=> ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] triangle = new int[N, N];
triangle[0, 0] = 1; triangle[1, 0] = 1; triangle[1, 1] = 1;

for (int i = 2; i < N; i++)
{
    triangle[i, 0] = 1; triangle[i, i] = 1;
    for (int j = 1; j < N - 1; j++)
    {
        triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
    }
}

PrintArray(triangle);


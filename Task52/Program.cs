/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/

int m = 0;
int n = 0;
Console.WriteLine("Enter M");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Enter N");
int.TryParse(Console.ReadLine(), out n);

int[,] CreateMatrixRnd(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j], 2} ");
        }
        Console.WriteLine();
    }
}

void SumCount(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
            if (j == n - 1) 
            {
                Console.Write($"Sum {i} = ");
                Console.Write(string.Format("{0:0.##}  ", sum / n));
            }
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMatrixRnd(m, n, 0, 9);
PrintArray(array);
Console.WriteLine();
SumCount(array);
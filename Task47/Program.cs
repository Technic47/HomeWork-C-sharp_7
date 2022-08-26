/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

int m = 0;
int n = 0;
Console.WriteLine("Enter M");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Enter N");
int.TryParse(Console.ReadLine(), out n);

double[,] CreateMatrixRndDouble (int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 200 - 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) Console.Write(string.Format("{0,6:0.##}  ", array[i, j]));
        Console.WriteLine();
    }
}

double[,] array = CreateMatrixRndDouble (m, n);
PrintArray(array);
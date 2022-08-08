/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

int m = 0;
int n = 0;
Console.WriteLine("Enter M");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Enter N");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine();

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++) array[i, j] = new Random().NextDouble() * 200 - 100;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) Console.Write(string.Format("{0:0.##}  ", array[i, j]));
        Console.WriteLine();
    }
}

PrintArray(array);
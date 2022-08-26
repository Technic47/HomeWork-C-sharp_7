/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/

int m = 10;
int n = 10;

Console.WriteLine("Enter M1 index: ");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter N1 index: ");
int n1 = int.Parse(Console.ReadLine()!);

int[,] CreateMatrixRnd (int m, int n, int min, int max)
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

void CheckArray(int[,] array, int m1, int n1)
{
    if (m1 > m || n1 > n)
    {
        Console.WriteLine("You index is out of the array");
    }
    else Console.WriteLine($"You number {array[m1, n1]}");
}

int[,] array = CreateMatrixRnd(m, n, 0, 9);
PrintArray(array);
Console.WriteLine();
CheckArray(array, m1, n1);


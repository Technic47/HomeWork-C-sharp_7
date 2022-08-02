/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/

int m = 10;
int n = 10;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
    }
}

Console.WriteLine("Enter M1 index: ");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter N1 index: ");
int n1 = int.Parse(Console.ReadLine()!);

/*void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/


void CheckArray(int[,] array, int m1, int n1)
{
    if (m1 > m || n1 > n)
    {
        Console.WriteLine("You index is out of the array");
        return;
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == m1 - 1 && j == n1 - 1)
            {
                Console.WriteLine($"You number {array[i, j]}");
            }
        }
    }
}

//PrintArray(array);
Console.WriteLine();
CheckArray(array, m1, n1);


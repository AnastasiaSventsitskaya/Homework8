// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int maxrow = 3;
int maxcolumn = 4;
int [,] matrix = new int [maxrow, maxcolumn];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,12);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}


for (int c = 0; c < maxrow; c++)
{
    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
    {
        int max = matrix[c,i];
        int maxIndex = i;
        for (int k = i+1; k < matrix.GetLength(1); k++)
        {
            if(matrix[c,k] > max)
            {
             max = matrix[c,k];
             maxIndex = k;
            }
        }
        int temp = matrix[c,i];
        matrix[c,i] = matrix[c,maxIndex];
        matrix[c,maxIndex] = temp;
    }
}
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
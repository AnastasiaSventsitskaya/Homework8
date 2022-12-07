// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int maxrow1 = 3;
int maxcolumn1 = 4;
int [,] matrix1 = new int [maxrow1, maxcolumn1];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i,j] = new Random().Next(0,10);
        Console.Write(matrix1[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("--------------");

int maxrow2 = 4;
int maxcolumn2 = 3;
int [,] matrix2 = new int [maxrow2, maxcolumn2];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j] = new Random().Next(0,10);
        Console.Write(matrix2[i,j]+" ");
    }
    Console.WriteLine();
}

if (maxrow1 != maxcolumn2)
{
    Console.WriteLine("Умножение невозможно.");
}

int [,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
{

    for ( int i = 0; i < matrix1.GetLength(0); i++)
        {
            for ( int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix3[i, j] = 0;

                for (int k = 0; k < matrix1.GetLength(1); k++) //
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
}

Console.WriteLine();

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        Console.Write(matrix3[i,j]+" ");
    }
    Console.WriteLine();
}
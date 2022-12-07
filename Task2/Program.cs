// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой
//  строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка int maxrow = 3;




int maxrow = 5;
int maxcolumn = 3;
int [,] matrix = new int [maxrow, maxcolumn];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}

int maxSum = Int32.MinValue;
int indexMaxSum = -1;
for (int i = 0; i < maxrow; i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i,j];
    }
    if (sum > maxSum)
    {
        maxSum = sum;
        indexMaxSum = i;
    }
}
Console.Write("Row:" + (indexMaxSum + 1));


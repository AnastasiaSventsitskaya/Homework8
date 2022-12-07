// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int x = 3;
int y = 3;
int z = 3;

int num = x * y * z;
int [] digits = new int [num];

int count = 0;
int element = 0;
while(count < num)
{
    element = new Random().Next(10,100);
    if (digits.Contains(element))
        continue;
    digits[count] = element;
    count++;
}

int [,,] matrix = new int [x, y, z];
int counter = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k] = digits[counter];
            counter++;
          Console.Write(matrix[i,j,k]+"("+ i+","+j+","+k + ")");   
        }
        Console.WriteLine();
    }
    
}
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int m = InputNumbers("Input m: ");
int n = InputNumbers("Input n: ");
int range = InputNumbers("Input numbers from 1 to ");
int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);
Console.WriteLine($"\nSorted array: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)

{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
            {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
            }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)

{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
    {
     for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
        }
    }

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine($"\nInput the size of the array k x n and the range of random values:");
int k = InputNumbers("Input k: ");
int n = InputNumbers("Input n: ");
int range = InputNumbers("Input numbers from 1 to ");
int[,] array = new int[k, n];
CreateArray(array);
WriteArray(array);
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n{minSumLine+1} is the line with the smallest sum of elements ({sumLine})");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int a = 1; a < array.GetLength(1); a++)
  {
    sumLine += array[i,a];
  }
  return sumLine;
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int a = 0; a < array.GetLength(1); a++)
    {
      array[i, a] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int a = 0; a < array.GetLength(1); a++)
    {
      Console.Write(array[i,a] + " ");
    }
    Console.WriteLine();
  }
}
*/ 
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Enter the number of rows of array 1: ");
    int rowsA = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns of array 1: ");
    int columnsA = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of rows of array 2: ");
    int rowsB = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns of array 2: ");
    int columnsB = int.Parse(Console.ReadLine());
if (columnsA != rowsB)
{
  Console.WriteLine("Such matrices cannot be multiplied!");
  return;
}
    int[,] A = GetArray(rowsA, columnsA, 0, 10);
    int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
    Console.WriteLine();
PrintArray(B);
    Console.WriteLine();
 PrintArray(GetMultiplicationMatrix(A,B));

    int[,] GetArray(int m, int n, int min, int max)
    {
    int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
    }
      return result;
    }

    void PrintArray(int[,] inArray)
    {
     for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j]} ");
            }
       Console.WriteLine();
        }
    }

    int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
    {
      int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      for (int i = 0; i < arrayA.GetLength(0); i++)
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
      }
      return arrayC;
    }

 


/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int n = 4;
int[,] sqareMatrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
WriteArray(sqareMatrix);
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
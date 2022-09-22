/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateRandomArray (int size)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++) 
    newArray [i]= new Random().Next (100, 1000);
    return newArray;
}

void ShowArray (int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
{
    Console.Write (array [i] + ", ");
}
Console.Write("] ");
}
Console.WriteLine("Input size of array");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray (size);
ShowArray (newArray);

int count = 0;
for (int n = 0; n < newArray.Length; n++) 
if (newArray [n] % 2 == 0)
count++;
Console.WriteLine($"There are {newArray.Length} numbers, {count} are even.");


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArrayRandomNumbers(int[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1,100);
}
}

void ShowArray (int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
{
    Console.Write (array [i] + ", ");
}
Console.Write("] ");
}

Console.WriteLine("Input size of array");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Masive is: ");
ShowArray(numbers);
int sum = 0;

for (int k = 0; k < numbers.Length; k+=2)
    sum = sum + numbers[k];
Console.WriteLine($"There are {numbers.Length} numbers, sum of elements at odd positions = {sum}");



/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Input size of array");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Massive is: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] > max)
{
    max = numbers[x];
}
if (numbers[x] < min)
{
    min = numbers[x];
}
}

Console.WriteLine($"There are {numbers.Length} numbers. Maximum is = {max}, minimum is = {min}");
Console.WriteLine($"Interval between them = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
 for(int i = 0; i < numbers.Length; i++)
    {
    numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 1;
    }
}
void PrintArray(double[] numbers)
{
Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + ", ");
}
Console.Write("]");
Console.WriteLine();
}


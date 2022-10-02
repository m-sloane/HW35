/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

/*
Console.WriteLine("Enter N: ");
int numStart = 1;
int numFinish = Convert.ToInt32(Console.ReadLine());
int NumbersToN(int number1, int number2)
{
    if(number1>number2) return number2;
    else
    {
        Console.Write(number1+ ", ");
        number1++;
    }
    return NumbersToN(number1++, number2);
}
NumbersToN(numStart,numFinish);
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int InputNumber(string input)
{
     Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
 }
 void PrintSum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintSum(m, n - 1, sum);
 }
 int m = InputNumber("Input m: ");
 int n = InputNumber("Input n: ");
 int temp = m;
 if (m > n)
 {
     m = n;
     n = temp;
 }
 Console.Write($"{m}, {n} ->");
 PrintSum(m, n, temp = 0); 
 


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

/*
int m = InputNumber("Input m: ");
int n = InputNumber("Input n: ");
int akkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Akkerman(int m, int n)
{
if (m == 0)
    {
    return n + 1;
    }
else if (n == 0 && m > 0)
    {
    return Akkerman(m - 1, 1);
    }
else
    {
    return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
*/

// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

int Prompt (string message)
{
System.Console.Write(message);
string ReadInput = Console.ReadLine();
int result = int.Parse(ReadInput);
return result;
}
int[] GenerateArrey(int Length, int minValue, int maxValue)
{
int[] arrey = new int[Length];
Random random = new Random();
for (int i = 0; i < Length; i++)
{
    arrey [i] = random.Next(minValue, maxValue + 1);
}
return arrey;
}
void PrintArrey(int[] arrey)
{

    System.Console.Write("[");
    for (int i = 0; i < arrey.Length -1; i++)
{
Console.Write($"{arrey[i]}, ");
}
Console.Write($"{arrey[arrey.Length - 1]}");
Console.WriteLine("]");
}
int Length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] arrey = GenerateArrey(Length, min, max);

PrintArrey(arrey);

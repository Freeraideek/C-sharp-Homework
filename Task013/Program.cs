﻿// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число A: ");
double a = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите натуральную степень в которо хотите возвести число A: ");
int b = Convert.ToInt32(Console.ReadLine());
while (b <= 0)
{
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральную степень в которо хотите возвести число A: ");
}

double result = Math.Pow(a, b);
Console.WriteLine($"{a} ^ {b} = {result}");
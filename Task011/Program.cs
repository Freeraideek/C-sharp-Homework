﻿// Найти кубы чисел от 1 до N.

Console.WriteLine("Введите число: ");
int sum = int.Parse(Console.ReadLine());
Console.WriteLine("");

int x = 1;
int y = 1;

while (x <= sum)
{
    Console.Write(x + "\t");
    x++;
}
Console.WriteLine();

while (y <= sum)
{
    Console.Write(y*y*y + "\t");
    y++;
}
Console.WriteLine();
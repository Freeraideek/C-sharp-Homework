// Подсчитать сумму цифр в числе

Console.Write("Введите любое целое число число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a <= 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите любое целое число число: ");
}

int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a / 10;
}

Console.WriteLine($"Сумма цифр числа = {sum}");



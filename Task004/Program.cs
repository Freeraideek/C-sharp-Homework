// Показать все четные числа от 1 до N.
Console.WriteLine("Введите значение N: ");
string numN = Console.ReadLine();
int number = int.Parse(numN);
int min = 2;
while (min <= number)
{
    if (min % 2 == 0) Console.Write(min + " ");
    min++;
}

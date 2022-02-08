// Найти третью цифру числа или сообщить, что её нет.
int GetRandom()
{
    int number = new Random().Next(0, 200);
    return number;
}
int randomaizer = GetRandom();
Console.WriteLine($"Случайное число: {randomaizer}");

int result = randomaizer % 10;
if(randomaizer > 99)
{
    Console.WriteLine($"{result}");
}
else
{
    Console.WriteLine("Третьей цифры в числе нет.");
}
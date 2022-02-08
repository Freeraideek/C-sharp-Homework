// Удалить вторую цифру трехзначного числа
int GetRandom()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int randomaizer = GetRandom();
Console.WriteLine($"Случайное число: {randomaizer}");

int resultOne = randomaizer / 100;
int resultTwo = randomaizer % 10;
Console.WriteLine($"{resultOne} {resultTwo}");


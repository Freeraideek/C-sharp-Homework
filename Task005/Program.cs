// Показать второе цифру трехзначного числа
int GetRandom()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int randomaizer = GetRandom();
Console.WriteLine($"Случайное число: {randomaizer}");
int result = randomaizer % 100 / 10;
Console.WriteLine($"вторая цифра трехначного числаа {result}");
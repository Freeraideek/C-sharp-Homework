// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
int GetRandom()
{
    int number = new Random().Next(1, 7);
    return number;
}
int randomaizer = GetRandom();
Console.WriteLine($"Случайное число: {randomaizer}");

if (randomaizer >= 6)
    Console.WriteLine($"{randomaizer} выходной день.");

else
    Console.WriteLine($"{randomaizer} не является выходным.");

//Пн,Вт,Ср,Чт,Пт,Сб,Вс
// 1  2  3  4  5  6  7
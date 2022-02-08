//Найти максимальное из трех чисел.
int numA = new Random().Next(1, 99);
Console.WriteLine("Первое число: " + numA);
int numB = new Random().Next(1, 99);
Console.WriteLine("Второе число:" + numB);
int numC = new Random().Next(1, 99);
Console.WriteLine("Третье число:" + numC);

int max = numA;
if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;

Console.Write("max = ");
Console.WriteLine(max);

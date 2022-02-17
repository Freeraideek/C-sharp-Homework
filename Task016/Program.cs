// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

int[] array = new int[8];
void Fillarray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 2);//[0,2)
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Fillarray(array);
PrintArray(array);
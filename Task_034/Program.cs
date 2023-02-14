// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int size, int LeftRange, int RightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(LeftRange, RightRange + 1);
    }
    return array;
}

void PrintArray(int[] ArrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", ArrayForPrint) + "]");
}

int CountEvenNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] MyArray = GenerateArray(10, 100, 999);
PrintArray(MyArray);
System.Console.WriteLine($"Количество четных чисел в массиве: {CountEvenNumber(MyArray)}");
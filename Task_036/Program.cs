// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOddPositions(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int[] MyArray = GenerateArray(8, -10, 10);
PrintArray(MyArray);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве, равна {SumOddPositions(MyArray)}");

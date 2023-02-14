// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

double[] GenerateArray(int size, double RightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * RightRange, 2);
    }
    return array;
}

void PrintArray(double[] ArrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", ArrayForPrint) + "]");
}

double DifferenceMinMax(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else
        {
            if (array[i] < min)
                min = array[i];
        }
    }
    result = max - min;
    return result;
}

double[] MyArray = GenerateArray(8, 10);
PrintArray(MyArray);
System.Console.WriteLine($"Разница между max и min: {DifferenceMinMax(MyArray)}");

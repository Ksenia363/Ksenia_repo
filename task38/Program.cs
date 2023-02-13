// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }
    return array;
}

double Difference(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        else if (array[i] > max)
        {
            max = array[i];
        }
        
    }
    result = max - min;
    return Math.Round(result, 3);
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] arr = GenerateArray(5, 0, 20);
PrintArray(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами = {Difference(arr)}");
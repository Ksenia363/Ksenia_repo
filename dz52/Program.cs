// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Random random = new Random();
int[,] myArray = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = random.Next(1, 10);
        Console.Write(myArray[i, j] + "\t ");
    }

    Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < myArray.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        sum += myArray[i, j];
    }
    Console.Write($"{Math.Round( sum / myArray.GetLength(0),2)} \t");
}
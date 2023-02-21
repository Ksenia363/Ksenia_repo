// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message) // Задаем метод считывания числа с косоли
{
    Console.Write(message); // Выводим сообщение
    string value = Console.ReadLine(); // Считываем с консоли строку
    int result = Convert.ToInt32(value); // Преобразование строки в целое число
    return result; // Вовращаем результат
}

int[] InputArray(int lenght) // Задаем метод вывода массива
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($" Введите {i + 1} - й элемент ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a [{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int lenght = Prompt(" Введите количество элемнтов > ");
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 = {CountPositiveNumbers(array)}");

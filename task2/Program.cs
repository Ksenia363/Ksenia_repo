// // Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine ("Введите чило А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите чило В: ");
int numberВ = Convert.ToInt32(Console.ReadLine());

if (numberA>numberВ)
{
    Console.WriteLine("Max значение: " + numberA );
}

else {
    Console.WriteLine("Max значение: " + numberВ );
}
// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

Console.WriteLine ("Введите чило А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите чило B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите чило C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine("Максимальное число: " + numberA);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + numberC);
    }
}

else if (numberB > numberC)
{
    Console.WriteLine("Максимальное число: " + numberB);
}
else
{
    Console.WriteLine("Максимальное число: " + numberC);
}

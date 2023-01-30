// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Введите чило N: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number>1)
{
    for (int i = 2; i <= Number; i = i +2)
    Console.WriteLine (i + "");
}
else
{
    Console.WriteLine ("введите положительное четное");
}

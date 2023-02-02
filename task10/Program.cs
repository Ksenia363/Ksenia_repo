//  Напишите программу, которая принимает на вход 
//  трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1
Console.WriteLine ("Введите чило N: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 100 && Number <= 999) 
{
    Console.WriteLine($"{Number / 10 % 10}");
    }
else
{
 Console.WriteLine("Введите трехзначное число");
}
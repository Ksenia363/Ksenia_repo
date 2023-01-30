// Напишите программу, которая на вход принимает 
// число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine ("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Число являетя четным: " + N);
}
else
{
    Console.WriteLine("Число являетя нечетным: " + N );
}
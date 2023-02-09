// Напишите программу которая принимает на вход число N и выдает таблицу кубов числа от 1 до N

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count <= N; count ++)
{
    System.Console.Write(Math.Pow(count, 3) + ", ");

}

// // Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine ("Введите чило N: ");
int Number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (Number < 100)
{
System.Console.WriteLine(" Третьей цифры нет");
}
else
{
for (; Number >= 1000; Number /= 10);
System.Console.WriteLine( Number % 10);
}

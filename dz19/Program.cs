// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine("Палиндром");
//     }
//     else
//     {
//         Console.WriteLine("не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine("число не является пятизначным, введите пятизначное число");
// }

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 10000 == num % 10 && num / 1000 % 10 == num % 10000 / 1000)
{
System.Console.WriteLine("Число является палиндромом");
}
else
{
System.Console.WriteLine("Число не является палиндромом");
}

// int convertedNum = Convert.ToInt32(Convert.ToString(num[2])); конвертация числа в строку
// string? num = Console.ReadLine(); 
// if(num!.Length == 5) восклицательный знак нужен чтобы не обращать внимание на значение Null
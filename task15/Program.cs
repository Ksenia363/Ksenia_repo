// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите чило N: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 6 && Number <=7) 
{
    Console.WriteLine("День является выходным");
    }
else if (Number >=0 && Number <=5)
{
 Console.WriteLine("День не является выходным");
}
else{
    Console.WriteLine("Ввести число соответствующее номеру дня недели");
}
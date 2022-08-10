//15. Напишите программу, которая 
//принимает на вход цифру, обозначающую день недели, и 
//проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Сегодня понедельник - рабочий");
}
else if (a == 2)
{
    Console.WriteLine("Сегодня вторник - рабочий");
}
else if (a == 3)
{
    Console.WriteLine("Сегодня среда - рабочий");
}
else if (a == 4)
{
    Console.WriteLine("Сегодня четверг - рабочий");
}
else if (a == 5)
{
    Console.WriteLine("Сегодня пятница - рабочий");
}
else if (a == 6)
{
    Console.WriteLine("Сегодня суббота - выходной");
}
else if (a == 7)
{
    Console.WriteLine("Сегодня воскресенье - выходной");
}

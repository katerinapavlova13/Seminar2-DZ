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
    Console.WriteLine("Понедельник");
    Console.Write("Сегодня рабочий день");
}
else if (a == 2)
{
    Console.WriteLine("Вторник");
    Console.Write("Сегодня рабочий день");
}
else if (a == 3)
{
    Console.WriteLine("Среда");
    Console.Write("Сегодня рабочий день");
}
else if (a == 4)
{
    Console.WriteLine("Четверг");
    Console.Write("Сегодня рабочий день");
}
else if (a == 5)
{
    Console.WriteLine("Пятница");
    Console.Write("Сегодня рабочий день");
}
else if (a == 6)
{
    Console.WriteLine("Суббота");
    Console.Write("Сегодня выходной");
}
else if (a == 7)
{
    Console.WriteLine("Воскресенье");
    Console.Write("Сегодня выходной");
}
else
{
    Console.Write("Некоректный ввод");   
}


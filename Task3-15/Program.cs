//15. Напишите программу, которая 
//принимает на вход цифру, обозначающую день недели, и 
//проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Сегодня понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Сегодня вторник");
}
else if (day == 3)
{
    Console.WriteLine("Сегодня среда");
}
else if (day == 4)
{
    Console.WriteLine("Сегодня четверг");
}
else if (day == 5)
{
    Console.WriteLine("Сегодня пятница");
}
else if (day == 6)
{
    Console.WriteLine("Сегодня суббота");
}
else if (day == 7)
{
    Console.WriteLine("Сегодня воскресенье");
}

int Weekend(int num)
{
    if(num <= 7 && num >= 1)
    {
        return num > 5 ? 1 : 2;
    }
    else return -1;
}
int res = Weekend(day);
string result;
if (res > 0)
{
    result = res == 1 ? "Выходной" : "Рабочий";
    Console.Write($"{day} -> {result}");
}
else
{
    Console.Write($"{day}  Неверное ввод!");
}
// 13. Напишите программу, которая
// выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int FuncThird(int number)
{
    if (number > 99)
    {
        while (number > 1000 && number < -1000)
    {
    number = number / 10;
    }
    return number % 10;
    }
    else return -1;
}
int res = FuncThird(num);

if(res != -1)
{
    Console.Write($"Третья цифра числа {res}");
}
else
{
    Console.Write("Третьей цифры нет!");
}




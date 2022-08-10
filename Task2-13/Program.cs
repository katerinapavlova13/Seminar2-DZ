// 13. Напишите программу, которая
// выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Ведите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10;
int num2 = number % 10;

Console.Write($"{num1}, {num2}");


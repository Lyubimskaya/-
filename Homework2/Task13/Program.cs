// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string numberA = Convert.ToString(number);
if (numberA.Length > 2)
{
  Console.WriteLine($"Третья цифра: {numberA[2]}");
}
else
{
  Console.WriteLine("Третьей цифры нет");
}

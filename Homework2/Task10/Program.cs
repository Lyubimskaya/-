// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int digit1 = number % 100;
int digit = digit1 / 10;

if (number > 99 && number < 1000)
{
Console.WriteLine (number); 
Console.WriteLine (digit);
}
else
{
   Console.WriteLine ("Неверный ввод");
}
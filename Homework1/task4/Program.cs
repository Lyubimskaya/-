// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3:");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
Console.WriteLine($"Max = {numberA}");
}
else if (numberB > numberA && numberB > numberC)
{
Console.WriteLine($"Max = {numberB}");
}
else if (numberC > numberA && numberC > numberB)
{
Console.WriteLine($"Max = {numberC}");
}

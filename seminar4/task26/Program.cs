// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0;
if (number > 1)
{
    for (int i = 1; number > 0; i++)
    {
        number = number / 10;
        x++;
    }
    Console.Write($"Количество цифр в числе составляет {x}");
}
else
{
    Console.Write("Неверный ввод");
}
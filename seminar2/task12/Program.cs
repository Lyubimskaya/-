// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число 1:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberA % numberB;
if (result == 0)
{
Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Остаток = {result}");
}
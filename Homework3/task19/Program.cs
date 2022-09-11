// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int digit1 = number / 10000;
int digit5 = number % 10;
int digit4 = number % 100 / 10;
int digit2 = number % 10000 /1000;

if (digit1 == digit5 && digit2 == digit4 && number > 9999 && number <100000)
{
    Console.WriteLine("Число является палиндромом");
}
else 
{
    Console.WriteLine("Число не является палиндромом и/или пятизначным");
}





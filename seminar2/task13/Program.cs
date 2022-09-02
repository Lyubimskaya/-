// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 7;
int result23 = number % 23;  
if (result == 0 && result23 == 0)
{   
   Console.WriteLine("Кратно"); 
}
else
{
    Console.WriteLine("НЕ кратно");
}
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100,1000);
int digit3 = number % 10;
int digit1 = number / 100;
int digit = digit1 * 10 + digit3;
Console.WriteLine (number); 
Console.WriteLine (digit);
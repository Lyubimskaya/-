// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] array = new int[8];
for(int i = 0; i <=7; i++)
{
Console.Write("Введите элемент " + (i+1) + ": ");
array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i <=7; i++)
{
    Console.Write(array[i] + " ");
}
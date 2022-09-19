// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = new int[123];
GetArray(arr);
PrintArray(arr);
int numbers = 0;

for (int i = 0; i < arr.Length; i++)
if (arr[i] > 9 && arr[i] < 100)
numbers++;

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {numbers}");

void GetArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,151);
    }
}
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
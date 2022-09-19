// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
GetArray(arr);
PrintArray(arr);
int min = arr[0];
int max = arr[0];

for (int i = 0; i < arr.Length; i++)
    if(arr[i] < min)
        {
            min = arr [i];
        }
Console.WriteLine($"Минимальный элемент: {min}");

for (int i = 0; i < arr.Length; i++)
    if(arr[i] > max)
        {
            max = arr [i];
        }
Console.WriteLine($"Максимальный элемент: {max}");

void GetArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0,100);
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

int difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {difference}");

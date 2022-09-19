// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
GetArray(arr);
PrintArray(arr);
int sum = 0;

for (int i = 1; i < arr.Length; i+=2)
    sum = sum + arr[i];

    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sum}");

void GetArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(-100,100);
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
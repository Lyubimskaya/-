// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число (что бы получить ответ введите Stop): ");

int countPositiveNumbers = 0;

while (true)
{
    string reply = Console.ReadLine();
    if (reply == "Stop")
    {
        break;
    }
    else
    {
        int replyNumber = Convert.ToInt32(reply);
        if (replyNumber > 0)
    {
        countPositiveNumbers++;
    }
    }
}
Console.WriteLine($"Количество чисел больше 0: {countPositiveNumbers}");
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine("Введите любое целое число без лидирующих нулей: ");
int number = Convert.ToInt32(Console.ReadLine());
int absol = Math.Abs(number);

int counter = 0;
while (absol > 0)
{
    counter++;
    absol = absol / 10;
}

absol = Math.Abs(number);
int temp = 0;
int step = Convert.ToInt32(Math.Pow(10, counter - 1));
if (counter > 2)
{
    if (counter == 3)
    {
        temp = absol % 10;
        Console.WriteLine("Третья цифра в данном числе: " + temp);
    }
    else
    {
        temp = absol / (step / 100);
        temp = temp % 10;
        Console.WriteLine("Третья цифра в данном числе: " + temp);
    }
}
else
    Console.WriteLine("Третьей цифры нет");


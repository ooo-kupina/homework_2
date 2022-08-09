// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000 || number < -99 && number > -1000)
{
    int absol = Math.Abs(number);
    int temp1 = absol % 100;
    int temp2 = temp1 / 10;
    Console.Write($"Вторая цифра введённого числа равна {temp2}");
}
else
    Console.Write($"Число {number} не является трёхзначным числом. Повторите ввод правильно.");


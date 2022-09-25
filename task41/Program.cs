// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
using System;

int CatchNums(string[] nums)
{
    int sum = 0;
    foreach (var a in nums)
    {
        if (int.Parse(a) >= 0)
        {
            sum++;
        }
    }

    return sum;
}

string[] SplitString()
{
    Console.Write("Введите числа через пробел, запятую или / : ");
    return Console.ReadLine()!.Split(' ', ',', '/');
}

Console.WriteLine($"Из вашего набора чисел всего {CatchNums(SplitString())} положительных.");
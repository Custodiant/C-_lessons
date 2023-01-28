// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трёх значное число: ");

int num = int.Parse(Console.ReadLine());

if (num > 999 || num < 100)
{
    Console.WriteLine("Введите число от 100 до 999 включительно");
}
else
{
    int val = num / 10;
    int res = num - val * 10;
    Console.WriteLine("Последняя цифра вашего числа: " + res);
}

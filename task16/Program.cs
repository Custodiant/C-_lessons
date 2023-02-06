// Напишите программу, которая принимает на вход число и выдает количество цифр в числе 

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество символов = {LenghtNum(num)}");

int LenghtNum(int GetNumber)
{
    int count = 0;
    while (GetNumber>0)
    {
        GetNumber = GetNumber/10;
        count++;
    }
    return count;
}
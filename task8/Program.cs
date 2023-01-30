// 

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Ваше число кратно 7 и 23 одновременно");
}


else
{
    Console.WriteLine("Ваше число не кратно 7 и 23 одновременно");
}
Console.Clear();
Console.WriteLine("Введите первое чило: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 == Math.Sqrt(num))
{
    Console.WriteLine($"Число {num} ,это {num2} в квадрате");
}
else
{
    Console.WriteLine($"Число {num} НЕ является квадратным корнем {num2}");
}

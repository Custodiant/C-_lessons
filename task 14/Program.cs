// Програму на входе Н и выдает таблицу квадратов чисел от 1 до Н
//5 - 1/4/9/16/25/
//2 - 1/4

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
if (num < -1)
{
    while (count > num)
    {
        Console.Write(count*count*-1 +", ");
        count--;
    }
    Console.WriteLine( count * count*-1 + ". ");
    return;
}

while (count < num)
{
        Console.Write(count * count + ", ");
        count++;
}
Console.WriteLine( count * count + ". ");


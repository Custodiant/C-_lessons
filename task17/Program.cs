// Принимает на вход число Н и выдает произведение чисел от 1 до Н

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {num} = {MultNumb(num)}");

int MultNumb (int oneNum)
{
    int count = 1;
    int mult = 1;
    while (count <= oneNum)
    {
        mult *= count;
        count++;
    }
    return mult;
}

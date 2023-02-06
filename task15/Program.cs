// 

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр = {GetSumNums(num)}"); // запуск метода
Console.WriteLine($"Сумма цифр = {GetSumNums(num1)}"); // запуск метода
Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}"); // запуск метода


int GetSumNums(int number) //Метод
{
    int sum = 0;
    while(number>0)
    {
        sum += number;
        number--;
    }
    return sum;
}
// Напишите программу, которая выводит на экран числа от 1 до 100 при этом 
//вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел , 
//кратных пяти - слово Buzz, 
//если число кратно и 3 и 5 то программа выводит слово FizzBuzz

Console.Clear();

int n = 1;
while (n <= 100)
{
    if (n % 3 == 0 && n % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FizzBuzz: ");
    }
    else if (n % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Fizz: ");
    }
    else if (n % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Buzz: ");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(n + ": ");
    }
    n++;
}

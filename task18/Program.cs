// Выводит массив из 8 элементов, хаполненый нулями и единицами в случайном порядке

Console.Clear();
Console.WriteLine("Посмотрим массив 1");
PrintArray(GenerateArray());

Console.WriteLine("Посмотрим массив 2");
PrintArray2(GenerateArray2());



int [] GenerateArray()
{
    int[] someArray = new int[8];
    for (int count = 0; count <= 7; count++) someArray[count] = new Random().Next(0, 2);
    return someArray;
}

void PrintArray(int[] number)
{
    Console.Write("[");
    for (int count = 0; count <= (number.Length - 2); count++) Console.Write($"{number[count]},");
    Console.WriteLine($"{number[number.Length - 1]}]");
}

int [] GenerateArray2()
{
    int[] someArray = new int[8];
    for (int count = 0; count <= 7; count++) someArray[count] = new Random().Next(0, 2);
    return someArray;
}

void PrintArray2(int[] number)
{
    Console.Write("[");
    for (int count = 0; count <= (number.Length - 2); count++) Console.Write($"{number[count]},");
    Console.WriteLine($"{number[number.Length - 1]}]");
}


// Написать программу, которая выводит случайное число из отрезка [10,99]
// показать наибольшую ветку

Console.Clear();
int num = new Random().Next(10,100); //первое значение и второе +1
int a1 = num/10;
int a2 = num%10;
int max = a1;
if (max < a2)
{
    max = a2;
}
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}"); //если ставим бакс- будут сначения а не текст ($- интерполяция)
Console.WriteLine("Максимальная цифра в числе " + num + " -> " + max); // так без доллара выглядит 


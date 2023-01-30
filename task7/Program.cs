//напишите программу которая будет принимать на вход два числа и выводить 
//является ли второе число кратным первому. Если второе не кратно, то программа выводит остаток от деления

Console.Clear();
Console.WriteLine("Давайте введем 2 числа и проверим, кратно ли 2 число первому. Если не кратно покажем остаток от деления");

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

int result = num1 / num2;
if (result == 0);
{
    Console.WriteLine($"Второе число {num2} является кратным первому {num1}");
    int num = num1%num2;
    Console.WriteLine($" Остаток {num}");
}
// по заданому номеру четверти показывает диапазон возможных координат нв четверти
//программу на вход координаты 2 точек и находит расстояние между ними в 2д пространстве

Console.Clear();

Console.WriteLine("Введите номер четверти, для определения координат от 1 до 4:");
int num = int.Parse(Console.ReadLine());
int x = 0;
int y = 0;

if (num == 1);
{
    Console.WriteLine("X > 0 : Y > 0");
}
if (num == 2);
{
    Console.WriteLine("X < 0 : Y > 0");
}
if (num == 3);
{
    Console.WriteLine("X < 0 : Y < 0");
}
if (num == 4);
{
    Console.WriteLine("X > 0 : Y < 0");
}
if (num >4 || num <1) //else
{
    Console.WriteLine("Такой четверти нет!");
}
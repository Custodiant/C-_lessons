// На фход координаты Х и У причем Х не равно 0 и иУ не равно 0 и выдает четверть плоскости в которой находится эта точка

Console.Clear();

Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("I");
}

if (x<0 && y>0)
{
    Console.WriteLine("II");
}

if (x<0 && y<0)
{
    Console.WriteLine("III");
}

if (x>0 && y<0)
{
    Console.WriteLine("IV");
}


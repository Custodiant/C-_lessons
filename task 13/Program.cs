//программу на вход координаты 2 точек и находит расстояние между ними в 2д пространстве

Console.Clear();
Console.WriteLine("Введите координаты Х первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты У первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Х второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты У второй точки: ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 3);

Console.WriteLine(result);

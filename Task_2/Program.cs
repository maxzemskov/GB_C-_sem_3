Console.Clear();

Console.WriteLine("Введите координату X первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());




double result = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

Console.WriteLine($"Расстояние между точками: {result}");

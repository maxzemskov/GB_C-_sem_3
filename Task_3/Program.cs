Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
	Console.WriteLine(Math.Pow(i, 3));
Console.Clear();

Console.WriteLine("Введите количество кустов");
int bush = int.Parse(Console.ReadLine());
int berry = 0;
int maxberry = 0;
int n = 0;
int a = 0;
int[] garden = new int[bush+2];

while (n < bush)
{
	Console.WriteLine($"Введите количество ягод на кусте номер {n+1}");
	berry = int.Parse(Console.ReadLine());
	garden[n] = berry;

	n++;
}

garden[n] = garden[0];
garden[n+1] = garden[1];

n = 1;

while (n < bush + 1)
{
a = garden[n] + garden[n-1] + garden[n+1];
	if (a > maxberry)
	maxberry = a;
n++;
}

Console.WriteLine(maxberry);


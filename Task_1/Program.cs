Console.Clear();

Console.WriteLine("Введите 5ти значное число");
int a = int.Parse(Console.ReadLine());
if (a >= 1000 && a < 100000)
{
	if (a / 10000 == a % 10 && (a / 1000) % 10 == (a / 10) % 10)
	Console.WriteLine("Да");
	else
	Console.WriteLine("Нет");
}
else
Console.WriteLine("Вы ввели не 5ти значное число");


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int FindSumNum(int a)
{
	if (a == 0)
	{
		return 0;
	}
	return FindSumNum(a / 10) + a % 10;
}

Console.Write(FindSumNum(a));
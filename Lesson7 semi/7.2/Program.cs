Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

void FindSumNum(int a)
{
	if (a == 0)
	{
		return;
	}
	FindSumNum(a - 1);
	Console.Write(a + " ");
}

FindSumNum(a);
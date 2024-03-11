int[] CreateArray(int up, int down, int size)
{
	Random rnd = new Random();
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = rnd.Next(down, up);
	}
	return arr;
}

bool SearchSimpleNumber(int num)
{
	if (num < 2) return false;
	for (int i = 2; i < num; i++)
	{
		if (num % 1 == 0)
		{
			return false;
		}
	}
	return true;
}

int CountNumber(int[] arr)
{
	int count = 0;
	foreach (int item in arr)
	{
		if (SearchSimpleNumber(item))
		{
			count++;
		}
	}
	return count;
}

Console.WriteLine("Введите верхнюю границу:");
int up = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу:");
int down = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер блока:");
int size = int.Parse(Console.ReadLine()!);

int[] result = CreateArray(up, down, size);
Console.WriteLine(string.Join(", ", result));
Console.WriteLine(CountNumber(result));
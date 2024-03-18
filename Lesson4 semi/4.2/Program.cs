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

int CountNumber(int[] arr)
{
	int count = 0;
	foreach (int item in arr)
	{
		if (item % 10 == 1 && item % 7 == 0)
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
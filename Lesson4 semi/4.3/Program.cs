int[] CreateArray(int size)
{
	Random rnd = new Random();
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = rnd.Next(0, 9);
	}
	return arr;
}

int CreateNumber(int[] arr)
{
	string FinalNumber = "";
	foreach (int item in arr)
	{
		FinalNumber = FinalNumber + item;
	}
	return int.Parse(FinalNumber);
}

Console.WriteLine("Введите размер блока:");
int size = int.Parse(Console.ReadLine()!);

if (size > 8)
{
	Console.Write("Не правильный размер массива!");
}
else
{
	int[] result = CreateArray(size);
	Console.WriteLine(string.Join(", ", result));
	Console.WriteLine(CreateNumber(result));
}
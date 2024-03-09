int[] arr = { 2, 5, 4, 7, 8, 9, 6, 3, 4, 8 };
int i = 0;

while (i < arr.Length)
{
	if (arr[i] % 2 == 0)
	{
		Console.Write($"{arr[i]} ");
	}
	i++;
}
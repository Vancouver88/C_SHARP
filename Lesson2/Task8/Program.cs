int[] arr = { 2, 3, 4, 5, 6 };
int i = 0;
int max = arr[0];
while (i < arr.Length)
{
	if (arr[i] > max)
	{
		max = arr[i];
	}
	i++;
}
Console.Write(max);
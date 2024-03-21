int[] arr = { 1, 2, 5, 0, 10, 34 };

void PrintArrayRevers(int[] arr, int i)
{
	if (i < 0) return;
	Console.Write(arr[i] + " ");
	PrintArrayRevers(arr, i - 1);
}

PrintArrayRevers(arr, arr.Length - 1);
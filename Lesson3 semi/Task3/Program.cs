int[] arr = new int[] { 2, 3, 4, 5, 6 };
int size = arr.Length;
int[] answ = new int[size / 2 + size % 2];

for (int i = 0; i < size / 2; i++)
{
	answ[i] = arr[i] * arr[size - 1 - i];
}
if (size % 2 == 1)
{
	answ[answ.Length - 1] = arr[size / 2];
}
foreach (var item in answ)
{
	Console.Write(item + " ");
}
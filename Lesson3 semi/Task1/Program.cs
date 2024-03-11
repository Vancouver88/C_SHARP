int[] arr = { 2, 6, 9, 12, 16 };
int num = int.Parse(Console.ReadLine()!);
string answ = "False";
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] == num)
		answ = "True";
}
Console.Write(answ);
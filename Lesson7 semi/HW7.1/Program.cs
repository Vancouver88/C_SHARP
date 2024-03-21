Console.WriteLine("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);

void PrintChars(int M, int N)
{
	if (N == M - 1)
	{
		return;
	}
	PrintChars(M, N - 1);
	Console.Write(N + " ");
}

PrintChars(M, N);
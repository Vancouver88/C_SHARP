﻿Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

int Ackermann(int m, int n)
{
	if (m == 0) return n + 1;
	else if (n == 0) return Ackermann(m - 1, 1);
	else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine(Ackermann(m, n));
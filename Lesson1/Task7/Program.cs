Console.Write("num: ");
string var = Console.ReadLine()!;
int var_num = int.Parse(var);
int N = -var_num;
while (N <= var_num)
{
	Console.Write(N + " ");
	N++;
}
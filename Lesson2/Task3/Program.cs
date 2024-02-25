int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

if (num1 % num2 == 0)
{
	Console.WriteLine("да");
}
else
{
	Console.WriteLine("нет, остаток " + num1 % num2);
}
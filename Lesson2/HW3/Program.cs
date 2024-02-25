int num = int.Parse(Console.ReadLine()!);
int first_num = num / 10;
int second_num = num % 10;

if (num < 10 || num > 99)
{
	Console.WriteLine("Некорректное число");
}
else if (first_num > second_num)
{
	Console.WriteLine(first_num);
}
else
{
	Console.WriteLine(second_num);
}
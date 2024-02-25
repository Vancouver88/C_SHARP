int num = int.Parse(Console.ReadLine()!);

//string digits = String.Join(", ", num.ToString().ToCharArray());

//Console.WriteLine(digits);

string digits = "";

while (num > 0)
{
	int digit = num % 10;
	digits = digit + ", " + digits;
	num = num / 10;
}

Console.WriteLine(digits.TrimEnd(',', ' '));
int num = int.Parse(Console.ReadLine()!);
int third_num = num % 10;
int second_num = num / 10 % 10;
Console.WriteLine(Math.Pow(second_num, third_num));
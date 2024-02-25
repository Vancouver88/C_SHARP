int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);

if (X == 0 || Y == 0)
{
	Console.WriteLine("Вы находитесь на оси координат");
}
else if (X > 0 && Y > 0)
{
	Console.WriteLine("Вы находитесь в 1 четверти");
}
else if (X < 0 && Y > 0)
{
	Console.WriteLine("Вы находитесь во 2 четверти");
}
else if (X < 0 && Y < 0)
{
	Console.WriteLine("Вы находитесь в 3 четверти");
}
else if (X > 0 && Y < 0)
{
	Console.WriteLine("Вы находитесь в 4 четверти");
}
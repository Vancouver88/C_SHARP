double CalculateFormula(int a, int b, int c, int d)
{
	double numenator = a * b;
	int denumenator = c * d;
	double result = numenator / denumenator;
	return result;
}

double result = CalculateFormula(5, 6, 8, 9);
Console.Write(result);
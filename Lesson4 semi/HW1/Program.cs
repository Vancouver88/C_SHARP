using System;

class Program
{
	static void Main()
	{
		while (true)
		{
			Console.WriteLine("Введите целое число или 'q' для выхода:");
			string input = Console.ReadLine();

			if (input.ToLower() == "q")
			{
				break;
			}

			int number;
			if (int.TryParse(input, out number))
			{
				if (SumOfDigitsIsEven(number))
				{
					Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
					break;
				}
			}
			else
			{
				Console.WriteLine("Некорректный ввод. Попробуйте снова.");
			}
		}
	}

	static bool SumOfDigitsIsEven(int number)
	{
		int sum = 0;

		foreach (char digit in Math.Abs(number).ToString())
		{
			sum += int.Parse(digit.ToString());
		}

		return sum % 2 == 0;
	}
}
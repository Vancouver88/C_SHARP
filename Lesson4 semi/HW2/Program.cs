﻿using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
	// Подсчет количества четных элементов массива
	// numbers - массив, в котором ведется подсчет
	public static int CountEvenItems(int[] numbers)
	{
		int count = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] % 2 == 0)
			{
				count++;
			}
		}
		return count;
		//Напишите свое решение здесь
	}

	public static void PrintResult(int[] array)
	{
		int result = CountEvenItems(array);
		Console.Write(result);
		//Напишите свое решение здесь
	}
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
	public static void Main(string[] args)
	{
		int[] array;


		if (args.Length >= 1)
		{
			// Объединяем все аргументы командной строки в одну строку
			string joinedArgs = string.Join(" ", args);

			// Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
			array = joinedArgs.Split(", ")
										 .Select(int.Parse)
										 .ToArray();

			// Теперь arr содержит преобразованные в целые числа из командной строки

		}
		else
		{
			// Если аргументов на входе нет
			array = new int[] { 252, 531, 256, 353, 698, 376, 753, 867, 289, 444 }; // Создание массива
		}
		UserInputToCompileForTest.PrintResult(array);
	}
}
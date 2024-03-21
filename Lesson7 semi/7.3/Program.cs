string vowle = "aeyuio";
Console.WriteLine("Введите слово: ");
string word = Console.ReadLine()!;

void PrintChars(string firstWord, int i = 0)
{
	if (i == firstWord.Length) return;
	if (vowle.Contains(firstWord[i]) == false)
	{
		Console.Write(firstWord[i] + " ");
	}
	PrintChars(firstWord, i + 1);
}

PrintChars(word);
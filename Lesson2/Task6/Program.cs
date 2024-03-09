int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
	arr[i] = i + 1;
	//Console.Write(arr[i]);
	//Console.Write(' ');
	Console.Write($"{arr[i]} ");
	i = i + 1;
}

//Solution 3
//Try to check if the Omnisharp extension for C# has the correct settings, once you have downloaded this extension.

//Click 'Ctrl + Shift + P'.
//Write "OmniSharp: Select Project" and press Enter.
//Choose the solution workspace entry.
//Then enable the C# extension for "OmniSharp: Project".
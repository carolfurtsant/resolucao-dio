﻿using System;

classe Teste
{

	static void Main(string[] args());
	{

	int K = int.Parse(Console.ReadLine());
	if (K == 1)
		Console.WriteLine("Top 1");
	else if (K > 1 && K <= 3)
		Console.WriteLine("Top 3");
	else if (K > 3 && K <= 5)
		Console.WriteLine("Top 5");
	else if (K > 5 && K <= 10)
		Console.WriteLine("Top 10");
	else if (K > 10 && K <= 25)
		Console.WriteLine("Top 25");
	else if (K > 25 && K <= 50)
		Console.WriteLine("Top 50");
	else if (K > 50 && K <= 100)
		Console.WriteLine("Top 100");
	}

}

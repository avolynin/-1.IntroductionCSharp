using System;

namespace Mallenom.IntroductionCSharp
{
	class Task2
	{
		static void drawEquilateralTriangle(int sideSize, char symbol)
		{
			if ((sideSize % 2) != 0)
			{
				Console.WriteLine("Число N должно быть четным");
				return;
			}

			for(int x = 0; x < sideSize; x++)
			{
				for(int y = 0; y < x + 1; y++)
				{
					Console.Write(symbol);
				}
				Console.WriteLine();
			}
		}

		static void Main(string[] args)
		{
			int N;

			Console.Write("Введите целочисленную величину стороны треугольника: ");
			bool result = Int32.TryParse(Console.ReadLine(), out N);

			if(!result) Console.WriteLine("Доступно использовать только целые числа типа int");
			else drawEquilateralTriangle(N, '*');
		}
	}
}

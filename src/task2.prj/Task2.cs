using System;

namespace Mallenom.IntroductionCSharp
{
	/// <summary>
	/// Консольное приложение, при запуске которого на экран командной строки
	/// выводится равносторонний треугольник, составленный из указанных символов.
	/// </summary>
	class Task2
	{
		/// <summary>Рисование равностороннего треугольника из переданного символа.</summary>
		/// <param name="sideSize">Длина сторон треугольника</param>
		/// <param name="symbol">Тип символа для рисования</param>
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
			int N; //Величина стороны равностороннего треугольника
			Console.Write("Введите целочисленную величину стороны треугольника: ");
			bool result = Int32.TryParse(Console.ReadLine(), out N);

			if(!result) Console.WriteLine("Доступно использовать только целые числа типа int");
			else drawEquilateralTriangle(N, '*');
		}
	}
}

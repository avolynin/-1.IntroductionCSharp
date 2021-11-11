using System;

using System.Linq;

namespace Mallenom.IntroductionCSharp
{
	class Task3
	{
		private static bool FillRandomInt(ref int[]? array, int minValue, int maxValue)
		{
			if (array == null)
			{
				Console.WriteLine("Массив ссылается на null");
				return false;
			}

			Random random = new Random();
			for(int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(minValue, maxValue);
			}
			return true;
		}

		private static void PrintArray(in int[] array)
		{
			Console.Write("Массив: {");
			for(int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]}");
				if(i != array.Length - 1) Console.Write(", ");
			}
			Console.Write("}");
		}

		static void Main(string[] args)
		{
			int N;
			Console.Write("Введите размер массива: ");
			bool result = Int32.TryParse(Console.ReadLine(), out N);

			if(!result) Console.WriteLine("Доступно использовать только целые числа типа int");
			else
			{
				int[] array = new int[N];
				if (FillRandomInt(ref array, -100, 100))
				{
					int countEven = array.Count<int>(i => (i % 2).Equals(0));
					int countOdd = array.Length - countEven;

					PrintArray(in array);
					Console.WriteLine($"\nКоличество четных - {countEven}, а нечетных - {countOdd}.");
				}
			}
		}
	}
}

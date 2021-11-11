using System;

namespace Mallenom.IntroductionCSharp
{
	class Task1
	{
		static void Main(string[] args)
		{
			int N;

			Console.Write($"Введите ваш возраст (от {Entity.minAge} до {Entity.maxAge} лет): ");
			bool result = Int32.TryParse(Console.ReadLine(), out N);

			if (!result) Console.WriteLine("Доступно использовать только целые числа типа int");
			else
			{
				Entity entity = new Entity(N);
				entity.printAge();
			}
		}
	}
}

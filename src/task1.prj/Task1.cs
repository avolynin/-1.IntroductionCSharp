using System;

namespace Mallenom.IntroductionCSharp
{
	/// <summary> 
	/// Вывод строки «Мне N лет», обеспечив правильное согласование числа со словом «год». 
	/// </summary>
	class Task1
	{
		static void Main(string[] args)
		{
			int N; //Целочисленный возраст в годах
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

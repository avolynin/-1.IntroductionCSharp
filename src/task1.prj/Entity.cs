using System;

using System.Text;

namespace Mallenom.IntroductionCSharp
{
	class Entity
	{
		private int _age = -1;
		public const int maxAge = 99;
		public const int minAge = 0;

		public int Age
		{
			get { return _age; }
			set
			{
				if(value < minAge || value > maxAge)
				{
					Console.WriteLine("Возраст доступный для ввода: от 0 до 99 лет");
				}
				else
				{
					_age = value;
				}
			}
		}

		public Entity(int age)
		{
			this.Age = age;
		}

		public void printAge()
		{
			if(Age == -1)
			{
				Console.WriteLine("Возраст неизвестен");
				return;
			}

			StringBuilder sb = new StringBuilder($"Мне {Age} ");
			int lastNum = Age;

			//if(lastNum >= 100) lastNum %= 100;
			if(lastNum >= 10 && lastNum <= 19) sb.Append("лет");
			if(lastNum >= 20 && lastNum <= 99) lastNum %= 10;

			if(lastNum == 0 || (lastNum >= 5 && lastNum <= 9)) sb.Append("лет");
			if(lastNum == 1) sb.Append("год");
			if(lastNum >= 2 && lastNum <= 4) sb.Append("года");

			Console.WriteLine(sb);
		}
	}
}

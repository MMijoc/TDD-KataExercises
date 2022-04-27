using System;

namespace FizzBuzzKata
{
	public class FizzBuzzer
	{
		public void FizzBuzz()
		{
			for (int i = 1; i < 100; i++)
			{
				Console.WriteLine(ConvertNumber(i));
			}
		}

		public string ConvertNumber(int number)
		{
			if (number % 3 == 0 && number % 5 == 0)
			{
				return "FizzBuzz";
			}
			else if (number % 3 == 0)
			{
				return "Fizz";
			}
			else if (number % 5 == 0)
			{
				return "Buzz";
			}

			return number.ToString();
		}
	}
}
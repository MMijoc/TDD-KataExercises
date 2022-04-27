using System;

namespace FizzBuzzKata
{
	public class FizzBuzzer
	{
		public FizzBuzzer()
		{

		}

		public string FizzBuzz(int number)
		{
			if (number % 3 == 0)
				return "Fizz";

			return "1";
		}
	}
}
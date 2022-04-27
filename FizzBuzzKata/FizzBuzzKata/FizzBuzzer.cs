using System;

namespace FizzBuzzKata;

public class FizzBuzzer
{
	private const string _fizz = "Fizz";
	private const string _buzz = "Buzz";
	private const string _fizzBuzz = "FizzBuzz";
	public void FizzBuzz()
	{
		for (int i = 1; i < 100; i++)
		{
			Console.WriteLine(ConvertNumber(i));
		}
	}

	public string ConvertNumber(int number)
	{
		if (IsFizzBuzz(number))
		{
			return _fizzBuzz;
		}
		else if (IsFizz(number))
		{
			return _fizz;
		}
		else if (IsBuzz(number))
		{
			return _buzz;
		}

		return number.ToString();
	}

	private static bool IsBuzz(int number)
	{
		return number % 5 == 0;
	}

	private static bool IsFizz(int number)
	{
		return number % 3 == 0;
	}

	private static bool IsFizzBuzz(int number)
	{
		return number % 3 == 0 && number % 5 == 0;
	}
}

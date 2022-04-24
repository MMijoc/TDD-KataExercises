using System.Linq;

namespace StringCalculatorKata;

public class StringCalculator
{
	public int Add(string numbers)
	{
		if (string.IsNullOrEmpty(numbers))
		{
			return 0;
		}

		var result = numbers.Split(",")
			.Select(s => int.Parse(s))
			.Sum();

		return result;
	}
}
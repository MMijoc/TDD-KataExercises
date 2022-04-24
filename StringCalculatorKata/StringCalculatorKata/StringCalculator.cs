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
		var delimiters = new [] { ',', '\n' };

		var result = numbers.Split(delimiters)
			.Select(s => int.Parse(s))
			.Sum();

		return result;
	}
}
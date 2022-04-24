using System.Collections.Generic;
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
		var delimiters = new List<char> { ',', '\n' };

		if (numbers.StartsWith("//"))
		{
			char newDelimiter = numbers[2];
			delimiters.Add(newDelimiter);
			numbers = numbers.Remove(0, 4);
		}
		
		var result = numbers.Split(delimiters.ToArray())
			.Select(s => int.Parse(s))
			.Sum();

		return result;
	}
}
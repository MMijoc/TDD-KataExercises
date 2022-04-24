using System;
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

		var numberList = numbers
			.Split(delimiters.ToArray())
			.Select(s => int.Parse(s));

		var negatives = numberList.Where(n => n < 0);

		if (negatives.Any())
		{
			string negativeString = string.Join(
				',', negatives.Select(n => n.ToString())
				);

			throw new Exception($"Negatives not allowed: {negativeString}");
		}

		var result = numberList
			.Where(n => n <= 1000)
			.Sum();

		return result;
	}
}
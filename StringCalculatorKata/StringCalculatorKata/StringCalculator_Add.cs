using Xunit;

namespace StringCalculatorKata;

public class StringCalculator_Add
{
	private StringCalculator _calculator = new StringCalculator();

	[Fact]
	public void ReturnZeroGivenEmptyString()
	{

		var result = _calculator.Add("");

		Assert.Equal(0, result);
	}

	[Theory]
	[InlineData("1", 1)]
	[InlineData("2", 2)]
	public void ReturnNumberGivenStringWithOneNumber(string numbers, int expectedResult)
	{
		var result = _calculator.Add(numbers);

		Assert.Equal(expectedResult, result);
	}

	[Theory]
	[InlineData("1,2", 3)]
	[InlineData("2,3", 5)]
	public void ReturnSumGivenStringWithTwoCommaSeperatedNumbers(string numbers, int expectedResult)
	{
		var result = _calculator.Add(numbers);

		Assert.Equal(expectedResult, result);
	}

	[Theory]
	[InlineData("1,2,3", 6)]
	[InlineData("2,3,4", 9)]
	public void ReturnSumGivenStringWithThreeCommaSeperatedNumbers(string numbers, int expectedResult)
	{
		var result = _calculator.Add(numbers);

		Assert.Equal(expectedResult, result);
	}

	[Theory]
	[InlineData("1\n2,3", 6)]
	[InlineData("1\n2\n3", 6)]
	[InlineData("1,2\n3", 6)]
	public void ReturnSumGivenStringWithThreeCommaOrNewLineSeperatedNumbers(string numbers, int expectedResult)
	{
		var result = _calculator.Add(numbers);

		Assert.Equal(expectedResult, result);
	}
}

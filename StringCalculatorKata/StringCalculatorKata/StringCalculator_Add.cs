using Xunit;

namespace StringCalculatorKata;

public class StringCalculator_Add
{
	[Fact]
	public void ReturnZeroGivenEmptyString()
	{
		var calculator = new StringCalculator();

		var result = calculator.Add("");

		Assert.Equal(0, result);
	}

	 [Theory]
	 [InlineData("1", 1)]
	public void ReturnOneGivenStringWithOne(string numbers, int expectedResult)
	{
		var calculator = new StringCalculator();

		var result = calculator.Add(numbers);

		Assert.Equal(expectedResult, result);
	}
}

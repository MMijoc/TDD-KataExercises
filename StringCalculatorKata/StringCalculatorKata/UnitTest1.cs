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
}

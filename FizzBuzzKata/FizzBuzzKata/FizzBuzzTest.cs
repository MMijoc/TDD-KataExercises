using Xunit;

namespace FizzBuzzKata;

public class FizzBuzzTest
{
	private FizzBuzzer _fizzBuzz = new();

	[Fact]
	public void Returns1For1()
	{
		
		var result = _fizzBuzz.FizzBuzz(1);

		Assert.Equal("1", result);
	}

	[Fact]
	public void ReturnsFizzFor3()
	{
		var result = _fizzBuzz.FizzBuzz(3);

		Assert.Equal("Fizz", result);
	}

	[Theory]
	[InlineData(6, "Fizz")]
	[InlineData(9, "Fizz")]
	public void ReturnsFizzForNumberDivisbleBy3(int number, string expectedResult)
	{
		var result = _fizzBuzz.FizzBuzz(number);

		Assert.Equal(expectedResult, result);
	}
}

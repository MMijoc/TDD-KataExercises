using Xunit;

namespace FizzBuzzKata;

public class FizzBuzzTest
{
	private FizzBuzzer _fizzBuzz = new();

	[Theory]
	[InlineData(1, "1")]
	[InlineData(77, "77")]
	public void ConvertNumber_ReturnsNumberForNumberNotDivisbleBy3Or5(int number, string expectedResult)
	{
		var result = _fizzBuzz.ConvertNumber(number);

		Assert.Equal(expectedResult, result);
	}

	[Theory]
	[InlineData(6, "Fizz")]
	[InlineData(9, "Fizz")]
	public void ConvertNumber_ReturnsFizzForNumberDivisbleBy3(int number, string expectedResult)
	{
		var result = _fizzBuzz.ConvertNumber(number);

		Assert.Equal(expectedResult, result);
	}

	[Theory]
	[InlineData(5, "Buzz")]
	[InlineData(10, "Buzz")]
	public void ConvertNumber_ReturnsBuzzForNumberDivisbleBy5(int number, string expectedResult)
	{
		var result = _fizzBuzz.ConvertNumber(number);

		Assert.Equal(expectedResult, result);
	}

	[Theory]
	[InlineData(15, "FizzBuzz")]
	[InlineData(30, "FizzBuzz")]
	public void ConvertNumber_ReturnsFizBuzzForNumberDivisbleBy3AndBy5(int number, string expectedResult)
	{
		var result = _fizzBuzz.ConvertNumber(number);

		Assert.Equal(expectedResult, result);
	}
}

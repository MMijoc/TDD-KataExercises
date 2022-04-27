using Xunit;

namespace FizzBuzzKata;

public class FizzBuzzTest
{
	private FizzBuzzer _fizzBuzz = new();

	[Fact]
	public void ConvertNumber_Returns1For1()
	{
		
		var result = _fizzBuzz.ConvertNumber(1);

		Assert.Equal("1", result);
	}

	[Fact]
	public void ConvertNumber_ReturnsFizzFor3()
	{
		var result = _fizzBuzz.ConvertNumber(3);

		Assert.Equal("Fizz", result);
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

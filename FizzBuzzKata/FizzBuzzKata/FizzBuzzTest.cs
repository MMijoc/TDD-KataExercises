using Xunit;

namespace FizzBuzzKata;

public class FizzBuzzTest
{
	[Fact]
	public void CanCreateNewFizzBuzz()
	{
		FizzBuzzer fizzBuzz = new FizzBuzzer();
		fizzBuzz.FizzBuzz(0);
	}

	[Fact]
	public void Returns1For1()
	{
		FizzBuzzer fizzBuzz = new FizzBuzzer();
		var result = fizzBuzz.FizzBuzz(1);

		Assert.Equal("1", result);
	}

}

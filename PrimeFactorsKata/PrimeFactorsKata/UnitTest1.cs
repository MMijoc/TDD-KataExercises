using Xunit;

namespace PrimeFactorsKata;

public class UnitTest1
{
	[Fact]
	public void Of_1()
	{
		Assert.Empty(PrimeFactors.Of(1));
	}

	[Fact]
	public void Of_2()
	{
		Assert.True(PrimeFactors.Of(2).Count == 1);
		Assert.Contains(2, PrimeFactors.Of(2));
	}

	[Fact]
	public void Of_3()
	{
		Assert.True(PrimeFactors.Of(3).Count == 1);
		Assert.Contains(3, PrimeFactors.Of(3));
	}
}
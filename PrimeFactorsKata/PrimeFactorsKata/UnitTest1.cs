using Xunit;

namespace PrimeFactorsKata;

public class UnitTest1
{
	[Fact]
	public void Of_1()
	{
		Assert.Empty(PrimeFactors.Of(1));
	}
}
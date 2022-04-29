using System.Collections.Generic;
using Xunit;

namespace PrimeFactorsKata;
public class PrimeFactorsTest
{
	[Fact]
	public void Of_1()
	{
		Assert.Empty(PrimeFactors.Of(1));
	}

	[Fact]
	public void Of_2()
	{
		var result = PrimeFactors.Of(2);
		var expectedResult = new List<int> { 2 };
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Of_3()
	{
		var result = PrimeFactors.Of(3);
		var expectedResult = new List<int> { 3 };
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Of_4()
	{
		var result = PrimeFactors.Of(4);
		var expectedResult = new List<int> { 2, 2 };
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Of_6()
	{
		var result = PrimeFactors.Of(6);
		var expectedResult = new List<int> { 2, 3 };
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Of_8()
	{
		var result = PrimeFactors.Of(8);
		var expectedResult = new List<int> { 2, 2, 2 };
		Assert.Equal(expectedResult, result);
	}


}
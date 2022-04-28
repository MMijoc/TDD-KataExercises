using System;
using Xunit;

namespace NameInverterKata;

public class NameInverterTest
{
	[Fact]
	public void InvertThrowsNullExceptionForNull()
	{
		NameInverter inverter = new NameInverter();

		Action action = () => inverter.Invert(null);

		Assert.Throws<NullReferenceException>(action);
	}

	[Theory]
	[InlineData("", "")]
	[InlineData("    ", "")]
	public void InvertReturnsEmptyStringForEmptyStringOrWhitespace(string name, string expectedResult)
	{
		NameInverter inverter = new NameInverter();

		Assert.Equal(expectedResult, inverter.Invert(name));
	}

	[Theory]
	[InlineData("John", "John")]
	[InlineData("  John   ", "John")]
	public void InvertFirstNameReturnsFirstName(string name, string expectedResult)
	{
		NameInverter inverter = new NameInverter();

		Assert.Equal(expectedResult, inverter.Invert(name));
	}

}

using System;
using Xunit;

namespace NameInverterKata;

public class NameInverterTest
{
	[Fact]
	public void InvertThrwosNullExceptionForNull()
	{
		NameInverter inverter = new NameInverter();

		Action action = () => inverter.Invert(null);

		Assert.Throws<ArgumentNullException>(action);
	}

	[Theory]
	[InlineData("", "")]
	[InlineData("    ", "")]

	public void InvertReturnsEmptyStringForEmptyStringOrWhitespace(string name, string expectedResult)
	{
		NameInverter inverter = new NameInverter();

		Assert.Equal(expectedResult, inverter.Invert(name));
	}
}

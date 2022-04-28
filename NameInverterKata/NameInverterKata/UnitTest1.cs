using System;
using Xunit;

namespace NameInverterKata;

public class NameInverterTest
{
	private readonly NameInverter _inverter = new();

	[Fact]
	public void InvertThrowsNullExceptionForNull()
	{
		Action action = () => _inverter.Invert(null);

		Assert.Throws<NullReferenceException>(action);
	}

	[Theory]
	[InlineData("", "")]
	[InlineData("    ", "")]
	public void InvertReturnsEmptyStringForEmptyStringOrWhitespace(string name, string expectedResult)
	{
		Assert.Equal(expectedResult, _inverter.Invert(name));
	}

	[Theory]
	[InlineData("John", "John")]
	[InlineData("  John   ", "John")]
	public void InvertFirstNameReturnsFirstName(string name, string expectedResult)
	{
		Assert.Equal(expectedResult, _inverter.Invert(name));
	}

	[Theory]
	[InlineData("John Shepard", "Shepard, John")]
	[InlineData("  John   Shepard ", "Shepard, John")]
	public void InvertFirstLastReturnsLastCommaFirst(string name, string expectedResult)
	{
		Assert.Equal(expectedResult, _inverter.Invert(name));
	}
	[Theory]
	[InlineData("Mr. John Shepard", "Shepard, John")]
	[InlineData("Mrs. Jane Shepard ", "Shepard, Jane")]
	public void InvertFullNameWithoutHonorifics(string name, string expectedResult)
	{
		Assert.Equal(expectedResult, _inverter.Invert(name));
	}


}

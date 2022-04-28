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
}

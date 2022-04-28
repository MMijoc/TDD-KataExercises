using System;
using System.Collections.Generic;
using System.Linq;

namespace NameInverterKata;

public class NameInverter
{
	public string Invert(string name)
	{
		List<string> nameParts = new();

		nameParts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

		if (nameParts.Count == 1)
		{
			return nameParts[0];
		}

		if (nameParts.Count == 2)
		{
			return $"{nameParts[1]}, {nameParts[0]}";
		}

		return "";

	}
}

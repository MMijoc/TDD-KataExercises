using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameInverterKata;

public class NameInverter
{
	private readonly List<string> _honorifics = new() { "Mr.", "Mrs." };

	public string Invert(string name)
	{
		List<string> nameParts = new();
		StringBuilder result = new();

		nameParts = SplitToParts(name);
		nameParts.RemoveAll(x => _honorifics.Exists(y => y == x));

		if (nameParts.Count == 1)
		{
			return nameParts[0];
		}

		if (nameParts.Count == 2)
		{
			return $"{nameParts[1]}, {nameParts[0]}";
		}

		if (nameParts.Count > 2)
		{
			return $"{nameParts[1]}, {nameParts[0]} {string.Join(' ', nameParts.Skip(2))}";
		}

		return "";
	}

	private static List<string> SplitToParts(string name)
	{
		return name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
						.ToList();
	}
}

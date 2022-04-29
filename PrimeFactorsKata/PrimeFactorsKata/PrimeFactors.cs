using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata;
public static class PrimeFactors
{
	public static List<int> Of(int number)
	{
		List<int> factors = new();

		if (number == 1)
		{
			return factors;
		}

		factors.Add(number);

		return factors;
	}
}

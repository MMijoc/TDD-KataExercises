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
		int divisor = 2;

		while (number > 1)
		{
			while (number % divisor == 0)
			{
				factors.Add(divisor);
				number /= divisor;
			}
			divisor++; 
		}

		return factors;
	}
}

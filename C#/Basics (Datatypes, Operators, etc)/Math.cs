using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya
{
	class MathMethods
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Math.Max(34,134));
			Console.WriteLine(Math.Min(2,19));
			Console.WriteLine(Math.Abs(-34));
			Console.WriteLine(Math.Pow(5.7,3));
			Console.WriteLine(Math.Sqrt(49));
			Console.WriteLine(Math.Round(99.5));

			// Using Explicit typecasting to get value of Math.Pow in int

			int k = (int) Math.Pow(3,3);

			Console.WriteLine(k);

			Console.ReadLine();
		}
	}
}
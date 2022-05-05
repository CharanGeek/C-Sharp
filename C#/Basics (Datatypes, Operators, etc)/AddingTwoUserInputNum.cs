using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya
{
	class AddingTwoUserInputNum
	{
		static void Main(string[] args)
		{
			Console.Write("Enter first number: ");
			double n1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter second number: ");
			double n2 = Convert.ToDouble(Console.ReadLine());

			int sum = n1 + n2;
			Console.WriteLine("The sum of "+n1+" and "+n2+" is: "+sum);

			Console.ReadLine();
		}
	}
}
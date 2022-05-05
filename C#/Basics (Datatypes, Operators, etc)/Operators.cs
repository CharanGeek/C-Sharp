using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Aditya

{

	class Operators
	
	{
		
		static void Main(string[] args)

		{

			/*

			Types of operators in C# :

			    1) Arithemetic Operators

			    2) Assignment Operators

			    3) Logical Operators

			    4) Comparison Operators

			*/

			
			
			// Using Arithemetic Operators

			int a = 32,b=10;

			Console.WriteLine("The sum of a and b is: "+(a+b));

			Console.WriteLine("The difference between a and b is: "+(a-b));

			Console.WriteLine("The product of a and b is: "+(a*b));

			Console.WriteLine("The quotient of a and b is: "+(a/b));



            			// Using Assignment Operators

            			int k = b;

            			b /= 5;

            			Console.WriteLine("The value of k is: "+k);

            			Console.WriteLine("The value of b is: "+b);



           			// Using locical Operators

            			Console.WriteLine(true && false);

            			
Console.WriteLine(false && false);         // False and False will result in false


            			Console.WriteLine(false || true);

            			Console.WriteLine(false || false);           // False or false will result in false

            						Console.WriteLine(!false);

			
// Using Comparison Operators

			Console.WriteLine(42>=42);

			Console.WriteLine(100!=1000);


			Console.ReadLine();
		}
	
	}

}
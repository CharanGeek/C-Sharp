using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya
{
	class TypeCasting
	{
		static void Main(string[] args)
		{
			/* 
            
           			 There are 2 types of typecasting
            
            			1) Implicit typecasting (by C# compiler automatically)
            				It will convert char to int to long to float to double
                				This means that long can be coverted to float and double automatically
                
            			2) Explicit typecasting (by programmer using code)
            				int k = (int) 1.44521;
                
                          ---------------------------------------------------------------------------------------
			There are 2 ways to typecast
			
			1) Using keywords like (int)
			2) Using methods like Convert.ToDouble();
			*/
			
			// Using first method for typecasting
			int k = (int) 32.24;
			Console.WriteLine(k);
            
           			 // Using second method for typecasting
            			float fm = Convert.ToInt32(71.424143);
            			string meinStr = Convert.ToString(34.13416);
            
            			Console.WriteLine(fm);
           		 	Console.WriteLine(meinStr);

			Console.ReadLine();
		}
	}
}
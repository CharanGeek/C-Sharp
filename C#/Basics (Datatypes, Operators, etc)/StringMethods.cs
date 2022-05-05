using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya
{
	class StringMethods
	{
		static void Main(string[] args)
		{
			string phrase1 = "Programming in C# is";
			string phrase2 = "really easy till now";

			Console.WriteLine("I am \n\tnow in new \"line\" hahaha");
			Console.WriteLine(string.Concat(phrase1,phrase2));
			Console.WriteLine(phrase1.Length);
			Console.WriteLine(phrase2.ToUpper());
			Console.WriteLine(phrase1.ToLength());
			Console.WriteLine(phrase2.Contains("till"));
			Console.WriteLine(phrase1[16]);
			Console.WriteLine(phrase1.IndexOf("C#"));
			Console.WriteLine(phrase2.Substring(11,5);

			// Using template literal (or string interpolation)


            			Console.Write("what's your name? ");
            
			string user_name = Console.ReadLine();

            
           	 	Console.Write("what's your age? ");

			int user_age = Convert.ToInt32(Console.ReadLine());

		       
            Console.WriteLine($"Hey {user_name} you are still young at {user_age}");	

			Console.ReadLine();
		}
	}
}
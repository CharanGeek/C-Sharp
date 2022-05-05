using System;

namespace Aditya
{
	class GettingUserInput
	{
		static void Main(string[] args)
		{
			Console.Write("fuging tell me your mother's name :p ");
			string name = Console.ReadLine();

			Console.Write("fuging tell me your mother's age :p ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Hello "+name+" nice to fug you at "+age+" :D");

			Console.ReadLine();
		}
	}
}
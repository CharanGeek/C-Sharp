using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya
{
	class MadLibsGame
	{
		static void Main(string[] args)
		{
			string adjective,pluralNoun,celeb;

			Console.Write("Enter an adjective: ");
			adjective = Console.ReadLine();

			Console.Write("Enter a plural noun: ");
			pluralNoun = Console.ReadLine();

			Console.Write("Enter a celebrity name: ");
			celeb = Console.ReadLine();

			Console.WriteLine("Roses are "+adjective);
			Console.WriteLIne(pluralNoun+" are blue");
			Console.WriteLine("I love "+celeb);

			Console.ReadLine();
		}
	}
}
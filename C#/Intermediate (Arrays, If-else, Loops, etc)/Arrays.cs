using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya
{
	class Arrays
	{
		static void Main(string[] args)
		{
			int [] meinNums = {23, 20, 11, 64, 99, 101, 731};
			meinNums[3] = 1000;
			Console.WriteLine(meinNums[3]);

			string[] friends = new string[5];
			friends[0] = "Doesn't exsist";
			friends[1] = "YOU DONT HAVE FRIENDS";

			Console.WriteLine(friends[1]);

			Console.ReadLine();
		}
	}
}
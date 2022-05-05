using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya
{
	class IfElse
	{
		static void Main(string[] args)
		{
			Console.Write("what's your age? ");
			int age = Convert.ToInt32(Console.ReadLine());

			if ( age > 80){
				Console.WriteLine("Yamraj apke liye drive kar lenge apko driving ki jarurat nahi hai");
			}

			else if( age >= 18){
				Console.WriteLine("Idhar aa bacche thuje tera \"liscense\" deta hu");
			}

			else if( age <= 10){
				Console.WriteLine("Phele ABCD sikh le");
			}

			else if( age > 10){
				Console.WriteLine("Ajj gadi tera bhai chalaega!");
			}

			else{
				Console.WriteLine("Mar jao bhosdk");
			}

			Console.ReadLine();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IsWord
{
	class Program
	{
		static void Main(string[] args)
		{

			string querry;

			Console.WriteLine("Input querry to verify if it is a 'Word'?");
			querry = Console.ReadLine();

			foreach (char c in querry)
			{
				if (!Char.IsLetter(c))
				{
					Console.WriteLine("Querry contains number(s). Querry IS NOT a word.");
					Console.ReadLine();
				}

			}

			string aQuerry = querry.Substring(1);

			for (int i = 0; i < aQuerry.Length; i++)
			{
				if (char.IsUpper(aQuerry[i]))
				{
					Console.WriteLine("Only first letter of querry can be capitlized. Querry IS NOT a word.");
					Console.ReadLine();
				}
			}

			for (querry.Length = {1})
			{
				if (querry != "a" || querry != "A" || querry != "i" || querry != "I")
				{
					Console.WriteLine("Most words container multiple letters. Your querry IS NOT a word.");
					Console.ReadLine();
				}
			}



		


					/*					switch (querry)
									{
										case "a":
											Console.WriteLine("Querry IS a word.");
											Console.ReadLine();
										case "i":
											Console.WriteLine("Querry IS a word.");
											Console.ReadLine();
										case "I":
											Console.WriteLine("Querry IS a word.");
											Console.ReadLine();
										case "A":
											Console.WriteLine("Querry IS a word.");
											Console.ReadLine();
									}*/


					/*						Console.WriteLine("Input querry to verify if it is a 'Word'?");
											string querryBeta = Console.ReadLine();
											querry = querryBeta;

											char[] array = querry.ToArray(); */

					Console.ReadLine();




		}
	}
}


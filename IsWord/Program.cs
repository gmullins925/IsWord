﻿using System;
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
					break;
				}
			}



			string aQuerry = querry.Substring(1);

			for (int i = 0; i < aQuerry.Length; i++)
			{
				if (char.IsUpper(aQuerry[i]))
				{
					Console.WriteLine("Only first letter of querry can be capitlized. Querry IS NOT a word.");
					Console.ReadLine();
					break;
				}
			}


			char[] sngle = querry.ToCharArray();
			char first = sngle[0];
			//char second = sngle[1];
			for (int q = 0; q < querry.Length; q++)
			{
				if (querry.Length == 1)
				{
					switch (first)
					{
						case 'a':
							Console.WriteLine("Querry IS a word.");
							break;
						case 'i':
							Console.WriteLine("Querry IS a word.");
							break;
						case 'I':
							Console.WriteLine("Querry IS a word.");
							break;
						case 'A':
							Console.WriteLine("Querry IS a word.");
							break;
						default:
							Console.WriteLine("Most words container multiple letters. Your querry IS NOT a word.");
							break;
					}
				}
			}
			while (querry.Length >= 2)
			{
				NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary
				{
					DictionaryFile = "en-US.dic"
				};
				//oDict.Initialize();

				NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling
				{
					Dictionary = oDict
				};
				if (!oSpell.TestWord(querry))
				{
					Console.WriteLine("Your querry IS not a word");
				}

				else
				{
					Console.WriteLine(querry + " IS a word!");
				}
				Console.ReadLine();
			}
		}
	}
}



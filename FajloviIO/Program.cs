using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FajloviIO 
{
	class Program
	{
		static void Main(string[] args)
		{
			//Write i append
			File.WriteAllText("proba.txt", "Ovo je tekst iz c# :)" + Environment.NewLine);
			File.AppendAllText("proba.txt", "Ovo je dodatak");
			File.AppendAllText("proba.txt", "Ovo je dodatak 2");

			if (File.Exists("proba.txt"))
			{
				Console.WriteLine(File.ReadAllText("proba.txt"));

				foreach(string red in File.ReadLines("proba.txt"))
				{
					Console.WriteLine($"Red je: {red}");
				}
			}
			Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koordinaten_Punkte_C_sharp
{
	class Program
	{
		static void Main(string[] args)
		{
		CPunkt a = new CPunkt(10, 20);
		CPunkt b = new Cpunkt(a);
		CPunkt c = new CPunkt();

		c.X = 30;
		c.Y = 40;

		Console.WriteLine("Punkt B<" + b.X + "|" + b.Y +">");
		Console.WriteLine("Abstand von Punkt b zu <0|0>: " + b.Abstand());
		}
		
	}
}

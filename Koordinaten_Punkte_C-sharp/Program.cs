using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static Koordinaten_Punkte_C_sharp.CPunkt;

namespace Koordinaten_Punkte_C_sharp
{

	class CPunkt
	{
		//Var

		//private int X;
		//private int Y;

		// getter und setter
		public double X { get; internal set; }
		public double Y { get; internal set; }

		// Parameterkonstruktor (double X, double Y)
		public CPunkt(double X, double Y)
		{
			// Fall CPunkt a = new CPunkt(10, 20);
		}
		
		// Standardkonstruktor
		public CPunkt()
		{ 
			// FALL B CPunkt c = new CPunkt();
		}

		// Parameterkonsruktor (CPunkt p)		
		public CPunkt(CPunkt p)
		{
			// FALL C ?
		/*CPunkt b = CPunkt object a = null;
			a;
		*/
		}
		

		/*
		public void SetzeCPunkt(int X, int Y)
		{ 
			// do sth.
		}
		*/
		

	}

	class Program
	{
		static void Main(string[] args)
		{
		// Konstruktoren werden Aufgerufen
		CPunkt a = new CPunkt(10, 20);
		//CPunkt b = new Cpunkt(a);
		CPunkt c = new CPunkt();

		c.X = 30;	//aufruf der Methode zum erzeugen der XPosition
		c.Y = 40;	// YPosition

		//Console.WriteLine("Punkt B<" + b.X + "|" + b.Y +">");
		// Console.WriteLine("Abstand von Punkt b zu <0|0>: " + b.Abstand());

		// Beim Debugging (schrittweise) wird deutlich, dass die Ausgabe 
		// auf der Console , die GETTER-Methode nutzt um auf die Werte zuzugreifen! 
		Console.WriteLine("Inhalt von c.X: {0}, c.Y {1}", c.X, c.Y );
		}
		
	}
}

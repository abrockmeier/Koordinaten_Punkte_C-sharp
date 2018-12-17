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
		//private static object p;
		//private static object b;

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
			return;
		}
		
	}
	/* PROTOTYP
	internal class Abstand
	{
		double abstand;
		double quadratabstand;

		//public double Abstand { get => abstand; set => abstand = value; }

		static double Sqrt (double quadratabstand);
	
	
	// private float AbstandUrsprung (CPunkt)

	*/
	internal class Abstand
	{
		double quadratabstand;
		double abstand;
		// die Parameter auf CPunkt _,  reduzieren oder Polymorphie nutzen oder Umwandeln, bzw. get nutzen...
		private double AbstandUrsprung (double x, double y)
		{
			//  Quatsch ... (-) * (-) = + ... -> keine Fallunterscheid. notw.
			quadratabstand =  ( x * x ) + ( y * y );
			
			
			abstand = Math.Sqrt(quadratabstand);
			return abstand;
			// sollte was zurückgeben:   return  ;
		
			//  Konstruktor Aufruf wandert in die Main ---> CPunkt Ursrpung = new CPunkt (0,0);
		}

		private double AbstandUrsprung (CPunkt p) // TODO: 
		{
			quadratabstand = ( p.X * p.X ) + (p.Y * p.Y );
			abstand = Math.Sqrt(quadratabstand);
			return abstand;
		
		//  Konstruktor Aufruf wandert in die Main ---> CPunkt Ursrpung = new CPunkt (0,0);
		}

	}
	

	class Program
	{
		static void Main(string[] args)
		{
		// Konstruktoren werden Aufgerufen
		CPunkt a = new CPunkt(10, 20);
		CPunkt b = new CPunkt(a);
		
		CPunkt c = new CPunkt	// das "();" wurde von IntelliSense gegen {}-Klammern um die X,Y Zuweisung ausgetauscht...
		{
			X = 30, //aufruf der Methode zum erzeugen der XPosition
			Y = 40  // YPosition
		};

		// und hier der Aufruf des Konstruktors für die Abstandsbestimmung
		CPunkt Ursprung = new CPunkt (0,0);

			Console.WriteLine("Punkt B<" + b.X + "|" + b.Y +">");
			//Console.WriteLine("Abstand von Punkt b zu <0|0>: " + b.Abstand());

		// Beim Debugging (schrittweise) wird deutlich, dass die Ausgabe (Auskommentiert s.u.)
		// auf der Console , die GETTER-Methode nutzt um auf die Werte zuzugreifen! 
		// Console.WriteLine("Inhalt von c.X: {0}, c.Y {1}", c.X, c.Y );
		}
		
	}
}

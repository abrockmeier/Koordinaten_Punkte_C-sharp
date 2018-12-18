using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static Koordinaten_Punkte_C_sharp.CPunkt;

namespace Koordinaten_Punkte_C_sharp
{
	

	//class CPunkt
	//{
	//	//private static object p;
	//	//private static object b;

	//	//Var

	//	//private int X;
	//	//private int Y;

		
		
	//}
	/* DELETE following 11.Lines 
	internal class Abstand
	{
		double abstand;
		double quadratabstand;

		//public double Abstand { get => abstand; set => abstand = value; }

		static double Sqrt (double quadratabstand);
	
	
	// private float AbstandUrsprung (CPunkt)

	
	internal class CAbstand
	{
		

	}
	*/
	

	class Program
	{
		static void Main(string[] args)
		{
		// Konstruktoren werden Aufgerufen
			C_Punkt a = new C_Punkt(10, 20);
			C_Punkt b =  a; //a statt "new C_Punkt(a);"
		
			C_Punkt c = new C_Punkt	// das "();" wurde von IntelliSense gegen {}-Klammern um die X,Y Zuweisung ausgetauscht...
		{
			X = 30, //aufruf der Methode zum erzeugen der XPosition
			Y = 40  // YPosition
		};

		// und hier der Aufruf des Konstruktors für die Abstandsbestimmung
			//C_Punkt Ursprung = new C_Punkt (0,0);
			Console .WriteLine("Punkt A<" + a.X + "|" + a.Y +">");
			Console.WriteLine("Punkt B<" + b.X + "|" + b.Y +">");
			Console.WriteLine("Abstand von Punkt b zu <0|0>: " + b.Abstand(b));

		// Beim Debugging (schrittweise) wird deutlich, dass die Ausgabe (Auskommentiert s.u.)
		// auf der Console , die GETTER-Methode nutzt um auf die Werte zuzugreifen! 
		// Console.WriteLine("Inhalt von c.X: {0}, c.Y {1}", c.X, c.Y );
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koordinaten_Punkte_C_sharp
{
	class C_Punkt
	{
	// getter und setter
		public double X { get; internal set; }
		public double Y { get; internal set; }
		
		// Parameterkonstruktor (double X, double Y)
		public C_Punkt(double X, double Y)
		{
			// Fall CPunkt a = new CPunkt(10, 20);
		}
		
		// Standardkonstruktor
		public C_Punkt()
		{ 
			// FALL B CPunkt c = new CPunkt();
		}

		// Parameterkonsruktor (CPunkt p)		
		public C_Punkt(C_Punkt p)
		{
			return;
		}

		//Abstand aus Klasse_Abstand
		double quadratabstand;
		double abstand;
		readonly double x;
		// die Parameter auf CPunkt _,  reduzieren oder Polymorphie nutzen oder Umwandeln, bzw. get nutzen...
		public double Abstand (double x, double y)
		{
			//  Quatsch ... (-) * (-) = + ... -> keine Fallunterscheid. notw.
			quadratabstand =  ( x * x ) + ( y * y );
			
			
			abstand = Math.Sqrt(quadratabstand);
			x = abstand; 
			return x;
			// sollte was zurückgeben:   return  ;
		
			//  Konstruktor Aufruf wandert in die Main ---> CPunkt Ursrpung = new CPunkt (0,0);
		}

		public double Abstand (C_Punkt p) // 
		{
			quadratabstand = ( p.X * p.X ) + (p.Y * p.Y );
			abstand = Math.Sqrt(quadratabstand);
			return abstand;
		
		//  Konstruktor Aufruf wandert in die Main ---> CPunkt Ursrpung = new CPunkt (0,0);
		}
	}
}

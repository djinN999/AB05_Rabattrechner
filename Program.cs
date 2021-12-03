using System;

namespace AB05
{
	class Program
	{
		public static void Main(string[] args)
		{
			double einzelpreis, gesamtpreis1, gesamtpreis2, rabattbetrag, rabattprozent, prozent;
			int anzahl;
			string ware;

			Console.Write("Rabattrechner");

			Console.Write("\nWelches Produkt wurde gekauft? ");
			ware = Convert.ToString(Console.ReadLine());

			Console.Write("Wie hoch ist der Einzelpreis? ");
			einzelpreis = Convert.ToDouble(Console.ReadLine());

			Console.Write("Wie viel Stück haben Sie davon gekauft? ");
			anzahl = Convert.ToInt32(Console.ReadLine());

			Console.Write("Wie viel Rabatt wollen Sie gewähren? ");
			rabattprozent = Convert.ToDouble(Console.ReadLine());

			Console.Clear();

				prozent = 1 - (rabattprozent / 100);
				string.Format("{0:0.00}", prozent);
				gesamtpreis1 = einzelpreis * anzahl;
				gesamtpreis2 = gesamtpreis1 * prozent;
				rabattbetrag = gesamtpreis1 - gesamtpreis2;
				string.Format("{0:0.00}", rabattbetrag);


			Console.WriteLine("Für das Produkt {0} ergibt sich folgende Berechnung mit einem Rabattsatz von {1} %", ware, prozent);
			Console.WriteLine("\nDer Kunde kauft: {0} Stück {1} zu einem Einzelpreis von {2}", anzahl, ware, einzelpreis);
			Console.WriteLine("Gesamtpreis ohne Rabatt:     {0}", gesamtpreis1);
			Console.WriteLine("Rabattbetrag:     {0}", rabattbetrag);
			Console.WriteLine("Gesamtpreis nach Rabatt:     {0}", gesamtpreis2);
		}
	}
}

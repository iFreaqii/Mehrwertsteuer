using System;

/// <summary>
/// Nico Bauer
/// IS218
/// AWE
/// Für einen beliebig eingegebenen Geldbetrag ist die Mehrwertsteuer zu berechnen. Dazu soll sowohl der Geldbetrag als auch der Mehrwertsteuersatz eingelesen werden. 
/// Nach der Berechnung kann man wählen, ob nur der errechnete Betrag oder auch der eingegebene Betrag und der Mwst-Satz angezeigt werden. 
/// </summary>


namespace Mehrwertsteuer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration der benoetigten Variablen
            double geldbetrag = 0;
            double mwstsatz = 0;
            double ergebnis = 0; 
            string weiterrechnen = "";
            int auswahl;

            do
            {
                //Benutzereingabe des Geldbetrags
                Console.WriteLine("Bitte geben Sie einen beliebigen Geldbetrag ein!");
                try
                {
                    geldbetrag = Convert.ToDouble(Console.ReadLine());
                }

                catch
                {    
                    Console.WriteLine();
                }
                Console.WriteLine();

                //Benutzereingabe des Mehrwertsteuersatzes
                Console.WriteLine("Bitte geben Sie den Mehrwertsteuersatz ein!");
                try
                {
                    mwstsatz = Convert.ToDouble(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine();
                }
                Console.WriteLine();

                ergebnis = geldbetrag * (mwstsatz / 100);

                Console.WriteLine("Wollen Sie die Mehrwertsteuer (1) oder die Mehrwertsteuer und die getätigten Eingaben ausgegeben bekommen? (2)");
                
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.WriteLine("Der Gesamtbetrag beträgt: {0}", ergebnis);

                    Console.WriteLine("\n Möchten Sie eine weiteren Wert berechnen?\nAntworten Sie mit (j)a oder (n)ein.\n");
                    weiterrechnen = Console.ReadLine();
                }

                else if (auswahl == 2)
                {
                    Console.WriteLine("Der Gesamtbetrag beträgt: {0} Euro\nDer angegebene Betrag ist: {1}\nDer angegebene Mehrwertsteuersatz beträgt: {2}\n", ergebnis, geldbetrag, mwstsatz);

                    Console.WriteLine("\n Möchten Sie eine weiteren Wert berechnen?\nAntworten Sie mit (j)a oder (n)ein.\n");
                    weiterrechnen = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Bitte geben Sie einen gültigen Wert (1, 2) für Ihre Auswahl ein.");

                    Console.WriteLine("\n Möchten Sie eine weiteren Wert berechnen?\nAntworten Sie mit (j)a oder (n)ein.\n");
                    weiterrechnen = Console.ReadLine();
                }
                
            }
            while (weiterrechnen != "n");
        }
    }
}

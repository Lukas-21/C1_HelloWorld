using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilRechnerMitWerkstoffauswahl
{
    public static class Berechnungen
    {
        public static void Rechteck(Double Höhe1, Double Breite1, Double Länge1, Double Wandstärke1, Double Dichte1)
        {
            //Ergebniss Variablen
            Double Volumen;
            Double Querschnitt;
            Double Gewicht;            
            Double Festigkeitx;
            Double Festigkeity;

            //Berechnung  Querschnitt

            Querschnitt = (Höhe1 - Wandstärke1) * (Breite1 - Wandstärke1);

            Console.WriteLine("Querschnitt:");
            Console.WriteLine(Querschnitt + "cm²");

            //Berechnung Volumen 

            Volumen = (Höhe1 * Breite1 * Länge1) - ((Höhe1 - Wandstärke1) * (Breite1 - Wandstärke1) * Länge1);

            Console.WriteLine("Volumen:");
            Console.WriteLine(Math.Round(Volumen, 3) + "cm³");

            //Berechnung Gewicht 

            Gewicht = Dichte1 * Volumen;

            Console.WriteLine("Gewicht:");
            Console.WriteLine(Gewicht + "g");
            //Berechnung der Flächenträgheitsmomente

            Festigkeitx = ((Breite1 * Math.Pow(Höhe1, 3)) - ((Breite1 - Wandstärke1) * Math.Pow((Höhe1 - Wandstärke1), 3))) / 12;
            Festigkeity = ((Höhe1 * Math.Pow(Breite1, 3)) - ((Höhe1 - Wandstärke1) * Math.Pow((Breite1 - Wandstärke1), 3))) / 12;

            Console.WriteLine("Das Flaechentraegheitsmoment in x Richtung des Profils betraegt: " + Festigkeitx + " cm hoch 4"); //cm hoch 4 ordentlich angeben
            Console.WriteLine("Das Flaechentraegheitsmoment in y Richtung des Profils betraegt: " + Festigkeity + " cm hoch 4"); //cm hoch 4 ordentlich angeben
        }
        static public void Rohr(Double Durchmesser1, Double Laenge1, Double Wandstaerke1, Double Dichte1)
        {
            Double Voulumen;
            Double Querschnitt;
            Double Gewicht;
            Double DurchmesserQ;
            Double DurchmesserQk;
            Double Festigkeit;

            DurchmesserQ = Math.Pow(Durchmesser1, 2);
            DurchmesserQk = Math.Pow(Durchmesser1 - (2 * Wandstaerke1), 2);


            //Querschnitt
            Querschnitt = ((Math.PI * DurchmesserQ) / 4) - ((Math.PI * DurchmesserQk) / 4);

            Console.WriteLine("Querschnitt:");
            Console.WriteLine(Querschnitt + "cm²");

            //Volumen

            Voulumen = (((Math.PI * DurchmesserQ) / 4) * Laenge1) - (((Math.PI * (DurchmesserQ - Wandstaerke1)) / 4) * Laenge1);

            Console.WriteLine("Voulumen:");
            Console.WriteLine(Voulumen + "cm³");

            //Gewicht

            Gewicht = Dichte1 * Voulumen;

            Console.WriteLine("Gewicht:");
            Console.WriteLine(Gewicht + "g");

            Festigkeit = (Math.PI * (Math.Pow((Durchmesser1), 4) - Math.Pow((Durchmesser1 - Wandstaerke1 * 2), 4))) / 64;

            Console.WriteLine("Das Flaechentraegheitsmoment des Profils betraegt: " + Festigkeit + " cm hoch 4"); //cm hoch 4 ordentlich angeben

        } 

       

        
    }    
}

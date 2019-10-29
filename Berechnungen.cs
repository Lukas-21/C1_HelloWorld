using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilRechnerMitWerkstoffauswahl
{
    public static class Berechnungen
    {
        public static void KreisRohr(Double radiusU, Double wandstaerkeU, Double laengeU, Double dichteU)
        {
            Double querschnitt;
            Double volumen;
            Double gewicht;
            Double festigkeit;

            querschnitt = Math.Pow(radiusU, 2) * Math.PI - Math.Pow((radiusU - wandstaerkeU), 2) * Math.PI;
            volumen = querschnitt * laengeU;
            gewicht = volumen * dichteU;
            festigkeit = (Math.PI * (Math.Pow((2 * radiusU), 4) - Math.Pow((2 * (radiusU - wandstaerkeU)), 4))) / 64;

            String ausgabeQuersch = String.Format("{0:0,000}", querschnitt);
            String ausgabeVol = String.Format("{0:0,000}", volumen);
            String ausgabeGew = String.Format("{0:0,000}", gewicht);
            String ausgabeFest = String.Format("{0:0,000}", festigkeit);

            Console.WriteLine("Der Querschnitt des Profils betraegt: " + ausgabeQuersch + "mm²");
            Console.WriteLine("Das Volumen des Profils betraegt: " + ausgabeVol + "mm³");
            Console.WriteLine("Das Gewicht des Profils betraegt: " + ausgabeGew + " g");
            Console.WriteLine("Das Flaechentraegheitsmoment des Profils betraegt: " + ausgabeFest + " mm hoch 4"); //cm hoch 4 ordentlich angeben
        }

        public static void KreisVoll(Double radiusU, Double laengeU, Double dichteU)
        {
            Double querschnitt;
            Double volumen;
            Double gewicht;
            Double festigkeit;

            querschnitt = Math.Pow(radiusU, 2) * Math.PI;
            volumen = querschnitt * laengeU;
            gewicht = volumen * dichteU;
            festigkeit = (Math.PI * (Math.Pow((2 * radiusU), 4))) / 64;

            String ausgabeQuersch = String.Format("{0:0,000}", querschnitt);
            String ausgabeVol = String.Format("{0:0,000}", volumen);
            String ausgabeGew = String.Format("{0:0,000}", gewicht);
            String ausgabeFest = String.Format("{0:0,000}", festigkeit);

            Console.WriteLine("Der Querschnitt des Profils betraegt: " + ausgabeQuersch + "mm²");
            Console.WriteLine("Das Volumen des Profils betraegt: " + ausgabeVol + "mm³");
            Console.WriteLine("Das Gewicht des Profils betraegt: " + ausgabeGew + " g");
            Console.WriteLine("Das Flaechentraegheitsmoment des Profils betraegt: " + ausgabeFest + " mm hoch 4"); //cm hoch 4 ordentlich angeben
        }

        public static void RechteckRohr(Double hoeheU, Double breiteU, Double wandstaerkeU, Double laengeU, Double dichteU)
        {
            Double querschnitt;
            Double volumen;
            Double gewicht;
            Double festigkeitx;
            Double festigkeity;

            querschnitt = hoeheU * breiteU - (hoeheU - wandstaerkeU) * (breiteU - wandstaerkeU);
            volumen = querschnitt * laengeU;
            gewicht = volumen * dichteU;
            festigkeitx = ((breiteU * Math.Pow(hoeheU, 3)) - ((breiteU - wandstaerkeU) * Math.Pow((hoeheU - wandstaerkeU), 3))) / 12;
            festigkeity = ((hoeheU * Math.Pow(breiteU, 3)) - ((hoeheU - wandstaerkeU) * Math.Pow((breiteU - wandstaerkeU), 3))) / 12;

            String ausgabeQuersch = String.Format("{0:0,000}", querschnitt);
            String ausgabeVol = String.Format("{0:0,000}", volumen);
            String ausgabeGew = String.Format("{0:0,000}", gewicht);
            String ausgabeFestx = String.Format("{0:0,000}", festigkeitx);
            String ausgabeFesty = String.Format("{0:0,000}", festigkeity);

            Console.WriteLine("Der Querschnitt des Profils betraegt: " + ausgabeQuersch + "mm²");
            Console.WriteLine("Das Volumen des Profils betraegt: " + ausgabeVol + "mm³");
            Console.WriteLine("Das Gewicht des Profils betraegt: " + ausgabeGew + " g");
            Console.WriteLine("Das Flaechentraegheitsmoment in x Richtung des Profils betraegt: " + ausgabeFestx + " mm hoch 4"); //cm hoch 4 ordentlich angeben
            Console.WriteLine("Das Flaechentraegheitsmoment in y Richtung des Profils betraegt: " + ausgabeFesty + " mm hoch 4"); //cm hoch 4 ordentlich angeben
        }

        public static void RechteckVoll(Double hoeheU, Double breiteU, Double laengeU, Double dichteU)
        {
            Double querschnitt;
            Double volumen;
            Double gewicht;
            Double festigkeitx;
            Double festigkeity;

            querschnitt = hoeheU * breiteU;
            volumen = querschnitt * laengeU;
            gewicht = volumen * dichteU;
            festigkeitx = (breiteU * Math.Pow(hoeheU, 3)) / 12;
            festigkeity = (hoeheU * Math.Pow(breiteU, 3)) / 12;

            String ausgabeQuersch = String.Format("{0:0,000}", querschnitt);
            String ausgabeVol = String.Format("{0:0,000}", volumen);
            String ausgabeGew = String.Format("{0:0,000}", gewicht);
            String ausgabeFestx = String.Format("{0:0,000}", festigkeitx);
            String ausgabeFesty = String.Format("{0:0,000}", festigkeity);

            Console.WriteLine("Der Querschnitt des Profils betraegt: " + ausgabeQuersch + "mm²");
            Console.WriteLine("Das Volumen des Profils betraegt: " + ausgabeVol + "mm³");
            Console.WriteLine("Das Gewicht des Profils betraegt: " + ausgabeGew + " g");
            Console.WriteLine("Das Flaechentraegheitsmoment in x Richtung des Profils betraegt: " + ausgabeFestx + " mm hoch 4"); //cm hoch 4 ordentlich angeben
            Console.WriteLine("Das Flaechentraegheitsmoment in y Richtung des Profils betraegt: " + ausgabeFesty + " mm hoch 4"); //cm hoch 4 ordentlich angeben
        }

        public static void LProfil(Double HoeheL, Double BreiteL, Double LaengeL, Double WandstaerkeL, Double DichteL)
        {
            Double Volumen;
            Double Querschnitt;
            Double Gewicht;
            Double Schwerpunktx;                //Abstend des Schwerpunktes zum Ursprungskoordinatensystem, welches auf der linken Profilkante liegt
            Double Schwerpunkty;                //Abstend des Schwerpunktes zum Ursprungskoordinatensystem, welches auf der unteren Profilkante liegt
            Double Festigkeitxx;
            Double Festigkeityy;
            Double Festigkeitxy;                //Deviationsmoment, da keine der Schwerpunktachsen Symetrieachse ist --- um Vredrehwinkel der hauptträgheitsachsen auszurechnen
            Double AchswinkelRad;                  //Verdrehung der Hauptträgheitsachsen zu den Schwerpunktachsen in Radiant
            Double AchswinkelGrad;                  //Verdrehung der Hauptträgheitsachsen zu den Schwerpunktachsen in Grad
            Double Festigkeitu;
            Double Festigkeitv;

            //Querschnitt
            Querschnitt = BreiteL * WandstaerkeL + (HoeheL - WandstaerkeL) * WandstaerkeL;

            Console.WriteLine("Querschnitt:");
            Console.WriteLine(Querschnitt + "mm²");

            //Voulumen
            Volumen = Querschnitt * LaengeL;

            Console.WriteLine("Volumen");
            Console.WriteLine(Volumen + "mm³");

            //Gewicht
            Gewicht = Volumen * DichteL;

            Console.WriteLine("Gewicht:");
            Console.WriteLine(Gewicht + "kg");

            //Schwerpunkte: (b * h * b/2--Schwerpunkt auf halber Höhe/Breite, ganze Fläche-- - (b - w) * (h - w)--Ausgeschnittene Fläche-- * ((b - w)/2 + w)--Schwerpunkt der Fläche, da Ursprungs KS auf linker Profilkante--) / (b * h - (b - w) * (h - w))--Querschnitt--
            Schwerpunktx = (BreiteL * HoeheL * (BreiteL / 2) - (BreiteL - WandstaerkeL) * (HoeheL - WandstaerkeL) * ((BreiteL - WandstaerkeL) / 2 + WandstaerkeL)) / ((BreiteL * HoeheL) - ((BreiteL - WandstaerkeL) * (HoeheL - WandstaerkeL)));
            Schwerpunkty = (HoeheL * BreiteL * (HoeheL / 2) - (HoeheL - WandstaerkeL) * (BreiteL - WandstaerkeL) * ((HoeheL - WandstaerkeL) / 2 + WandstaerkeL)) / ((HoeheL * BreiteL) - ((HoeheL - WandstaerkeL) * (BreiteL - WandstaerkeL)));



            //              -       Flächenträgheitsmomente         -Steiner Anteil: -Fläche  -;  -Abstand² des Teilschwerpkt. vom Gesamtschwerpkt, mit Ursprungs KS auf linker Profilkante
            //                                                                                                                               -     -         Flächenträgheitsmoment                           -      -           Fläche                    -    -Abstand² von Teilschw. zu Gesamtschw. mit KS auf Unterkante
            Festigkeitxx = ((WandstaerkeL * Math.Pow(HoeheL, 3) / 12) + (WandstaerkeL * HoeheL) * Math.Pow((HoeheL / 2 - Schwerpunkty), 2)) + (((BreiteL - WandstaerkeL) * Math.Pow(WandstaerkeL, 3) / 12) + (((BreiteL - WandstaerkeL) * WandstaerkeL) * Math.Pow((Schwerpunkty - (WandstaerkeL / 2)), 2)));                                       //Klappt
            Festigkeityy = ((HoeheL * Math.Pow(WandstaerkeL, 3) / 12) + (WandstaerkeL * HoeheL) * Math.Pow((Schwerpunktx - (WandstaerkeL / 2)), 2)) + ((WandstaerkeL * Math.Pow((BreiteL - WandstaerkeL), 3) / 12) + (((BreiteL - WandstaerkeL) * WandstaerkeL) * Math.Pow(((BreiteL - WandstaerkeL) / 2 + WandstaerkeL) - Schwerpunktx, 2)));      //Klappt

            Festigkeitxy = -Math.Pow((BreiteL * HoeheL), 2) / 4 - (-(Math.Pow((BreiteL * HoeheL), 2) - Math.Pow((HoeheL * WandstaerkeL), 2) - Math.Pow((BreiteL * WandstaerkeL), 2) + Math.Pow(WandstaerkeL, 4)) / 4) + (((BreiteL * HoeheL) - (BreiteL - WandstaerkeL) * (HoeheL - WandstaerkeL)) * Schwerpunktx * Schwerpunkty);

            //Achswinkel = (1 / 2) * Math.Atan((2 * Festigkeitxy) / (Festigkeitxx - Festigkeityy));
            AchswinkelRad = (Math.Atan((2 * Festigkeitxy) / (Festigkeitxx - Festigkeityy))) / 2;
            AchswinkelGrad = AchswinkelRad * 180 / Math.PI;

            Festigkeitu = (Festigkeitxx + Festigkeityy) / 2 + (((Festigkeitxx - Festigkeityy) / 2) * Math.Cos(2 * AchswinkelRad)) + Festigkeitxy * Math.Sin(2 * AchswinkelRad);
            Festigkeitv = (Festigkeitxx + Festigkeityy) / 2 - (((Festigkeitxx - Festigkeityy) / 2) * Math.Cos(2 * AchswinkelRad)) - Festigkeitxy * Math.Sin(2 * AchswinkelRad);

            Console.WriteLine("Schwerpunktverschiebiung in x = " + Schwerpunktx);
            Console.WriteLine("Schwerpunktverschiebiung in y = " + Schwerpunkty);
            Console.WriteLine("Das Flächenträgheitsmoment um die x Achse beträgt: " + Festigkeitxx + "mm^4");
            Console.WriteLine("Das Flächenträgheitsmoment um die y Achse beträgt: " + Festigkeityy + "mm^4");
            Console.WriteLine("Das Deviationsmoment Ixy beträgt: " + Festigkeitxy);
            Console.WriteLine("Verdrehung der HTA zu Schwerpkt. Achsen = " + AchswinkelRad + ".");
            Console.WriteLine("Dies entspricht " + AchswinkelGrad + "°.");
            Console.WriteLine("U Achse = X Achse + " + AchswinkelGrad + ". - Positive Werte drehen gegen den Urzeigersinn.");
            Console.WriteLine("V Achse = Y Achse + " + AchswinkelGrad + ".");
            Console.WriteLine("Das Flächenträgheitsmoment um die u Achse beträgt: " + Festigkeitu + "mm^4");
            Console.WriteLine("Das Flächenträgheitsmoment um die v Achse beträgt: " + Festigkeitv + "mm^4");
            Console.ReadKey();

            // ins Hauptprogramm:
            Console.WriteLine();
            Console.WriteLine("Bitte beachten Sie, dass wir die Kantenverrundungen der I, T, U, sowie der L Profile nicht berücksichtigen können.");
            Console.WriteLine("So kommt es dazu, das wir bei genormten Profilen kleinere Abweichungen von den tatsächlichen Werten erhalten.");
            Console.WriteLine();
        }
        public static void IProfil(Double Hoehe1, Double Breite1, Double Stegbreite1, Double Flanschbreite1, Double Laenge1, Double Dichte1)
        {
            //Ergebnis Variablen
            Double Breiteb;
            Double Hoeheh;
            Double Querschnitt;
            Double Volumen;
            Double Gewicht;
            Double FTMx;
            Double FTMy;

            //Zwischenrechnungen
            Breiteb = Breite1 - Stegbreite1;
            Hoeheh = Hoehe1 - 2 * Flanschbreite1;


            //Berechnung Querschnitt
            Querschnitt = (2 * Breite1 * Flanschbreite1) + ((Hoehe1 - 2 * Flanschbreite1) * Stegbreite1);

            Console.WriteLine("Querschnitt");
            Console.WriteLine(Querschnitt + "mm²");

            //Berechnung Volumen
            Volumen = Querschnitt * Laenge1;

            Console.WriteLine("Volumen");
            Console.WriteLine(Volumen + "mm³");

            //Berechnung Gewicht 
            Gewicht = Dichte1 * Volumen;

            Console.WriteLine("Gewicht");
            Console.WriteLine(Gewicht + "kg");

            //Berechnung FTM

            FTMx = ((Breite1 * Math.Pow(Hoehe1, 3) / 12) - (Breiteb * Math.Pow(Hoeheh, 3) / 12));

            Console.WriteLine("Flächenträgheitsmoment Ixx");
            Console.WriteLine(FTMx + "mm⁴");

            FTMy = 2 * ((Flanschbreite1 * Math.Pow(Breite1, 3) / 12)) + ((Hoeheh * Math.Pow(Stegbreite1, 3)) / 12);

            Console.WriteLine("Flächenträgheitsmoment Iyy");
            Console.WriteLine(FTMy + "mm⁴");


        }
    }
}

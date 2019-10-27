using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilRechnerMitWerkstoffauswahl
{
    public static class ProfilRechner
    {
        public static String Begruessung;
        public static String n = Environment.NewLine;
        static public void Main(string[] args)
        {
            //Grundprogramm zum testen der Variablen und zum Programmieren seines teil programmes.<3

            String Hoehe;
            String Laenge;
            String Breite;
            String Wandstaerke;
            String Dichte;
            String AuswahlProfil;
            String Durchmesser;
            String AuswahlDichte;
            String AuswahlSprache;

            Double HoeheD;
            Double BreiteD;
            Double LaengeD;
            Double DichteD;
            Double WandstaerkeD;
            Double DurchmesserD;
            Double AuswahlProfilD;
            Double AuswahlDichteD;
            Double AuswahlSpracheD;
          

           
            Console.WriteLine("Please select a language" + n + "Bitte Sprache auswählen" + n + n + "(1) Deutsch" + n + "(2) English");

            AuswahlSprache =Console.ReadLine();
            AuswahlSpracheD = Convert.ToDouble(AuswahlSprache);

            if (AuswahlSpracheD.Equals(1.0))
            {
                Begruessung = "Art des Profiles Auswählen" + n + "Bitte Nur ganze Zahlen Eingeben" +n + n + "(1) Rechteck" + n + "(2) Rohr" + n + "(3) T - Profil ";
            }
            else if (AuswahlSpracheD.Equals(2.0))
            {
                Begruessung = "Choose the profile" + n + n + "(1) Rectangle" + n + "(2) Pipe" + n + "(3)T-Section";
            }
            else if (AuswahlSpracheD.Equals(3.0))
            {

            }
            else
            {
                
            }

            Console.WriteLine(Begruessung);
           
            AuswahlProfil = Console.ReadLine();

            AuswahlProfilD = Convert.ToDouble(AuswahlProfil);


            if (AuswahlProfilD.Equals(1.0))
            {
                Console.WriteLine("Rechteck Profil");
                Console.WriteLine("Berechnung eines Rechteckprofiles");

                Console.WriteLine("Bitte die Gewuenschte Hoehe Eingeben in cm");
                Hoehe = Console.ReadLine();

                Console.WriteLine("Bitte die Gewuenschte Breite Eingebenin cm");
                Breite = Console.ReadLine();

                Console.WriteLine("Bitte die Gewuenschte Laenge Eingebenin cm");
                Laenge = Console.ReadLine();

                Console.WriteLine("Bitte die Gewuenschte Wandstaerke Eingeben in cm");
                Wandstaerke = Console.ReadLine();
                Console.WriteLine();

                WandstaerkeD = Convert.ToDouble(Wandstaerke);
                HoeheD = Convert.ToDouble(Hoehe);
                BreiteD = Convert.ToDouble(Breite);
                LaengeD = Convert.ToDouble(Laenge);

                if (WandstaerkeD.Equals(HoeheD))
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Wandstärke muss kleiner als Höhe Sein");

                }
                else if (WandstaerkeD.Equals(BreiteD))
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Wandstärke muss kleiner als Breite Sein");
                }
                else if (true)
                {
                    Console.WriteLine("Werkstoff auswahl = 1");
                    Console.WriteLine("Manuelle Eingabe der Dichte = 2");
                    AuswahlDichte = Console.ReadLine();

                    AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                    if (AuswahlDichteD.Equals(1.0))
                    {
                        String WerkstoffAuswahl;
                        Double WerkstoffAuswahlD;
                        Console.WriteLine("Werkstoffe:");
                        Console.WriteLine();
                        Console.WriteLine("S235     =1");
                        Console.WriteLine("AlMg4    =2");
                        Console.WriteLine("S355     =3");
                        Console.WriteLine("42CrMo4  =4");
                        Console.WriteLine("E295     =5");
                        Console.WriteLine("E355     =6");
                        Console.WriteLine("C45      =7");
                        WerkstoffAuswahl = Console.ReadLine();

                        WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                        DichteD = WerkstoffSammlung.Werkstoffe(WerkstoffAuswahlD);


                        Berechnungen.Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);

                    }
                    else if (AuswahlDichteD.Equals(2.0))
                    {
                        Console.WriteLine("Bitte die Gewuenschte Dichte Eingeben in g/cm³");
                        Dichte = Console.ReadLine();

                        DichteD = Convert.ToDouble(Dichte);
                        HoeheD = Convert.ToDouble(Hoehe);
                        BreiteD = Convert.ToDouble(Breite);
                        LaengeD = Convert.ToDouble(Laenge);
                        WandstaerkeD = Convert.ToDouble(Wandstaerke);

                        Berechnungen.Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (true)
                    {
                        Console.WriteLine("Falsche eingabe");
                    }
                }            

            }
            else if (AuswahlProfilD.Equals(2.0))
            {
                Console.WriteLine("Rohr Profil");
                Console.WriteLine("Berechnung eines Rohrprofiles");

                Console.WriteLine("Bitte den Gewünschten Durchmesser Eingeben in cm");
                Durchmesser = Console.ReadLine();

                Console.WriteLine("Bitte  die Gewünschte Länge Eingeben in cm");
                Laenge = Console.ReadLine();

                Console.WriteLine("Bitte die Gewünschte Wandstaerke Eingeben in cm");
                Wandstaerke = Console.ReadLine();
                Console.WriteLine();

                DurchmesserD = Convert.ToDouble(Durchmesser);
                LaengeD = Convert.ToDouble(Laenge);
                WandstaerkeD = Convert.ToDouble(Wandstaerke);

                if (WandstaerkeD.Equals(DurchmesserD))
                {
                    Console.WriteLine("Falsche Eingabe");
                }
                else if (true)
                {
                    Console.WriteLine("Werkstoff auswahl = 1");
                    Console.WriteLine("Manuelle Eingabe der Dichte = 2");
                    AuswahlDichte = Console.ReadLine();

                    AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                    if (AuswahlDichteD.Equals(1.0))
                    {
                        String WerkstoffAuswahl;
                        Double WerkstoffAuswahlD;
                        Console.WriteLine("Werkstoffe:");
                        Console.WriteLine();
                        Console.WriteLine("S235     =1");
                        Console.WriteLine("AlMg4    =2");
                        Console.WriteLine("S355     =3");
                        Console.WriteLine("42CrMo4  =4");
                        Console.WriteLine("E295     =5");
                        Console.WriteLine("E355     =6");
                        Console.WriteLine("C45      =7");
                        WerkstoffAuswahl = Console.ReadLine();

                        WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                        DichteD = WerkstoffSammlung.Werkstoffe(WerkstoffAuswahlD);

                        Berechnungen.Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (AuswahlDichteD.Equals(2.0))
                    {
                        Console.WriteLine("Bitte die Gewuenschte Dichte Eingeben in g/cm³");
                        Dichte = Console.ReadLine();

                        DichteD = Convert.ToDouble(Dichte);

                        Berechnungen.Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (true)
                    {
                        Console.WriteLine("Falsche eingabe");
                        Console.WriteLine("Wandstärke muss kleiner als Durchmesser sein");
                    }

                }

               
              



            }
            else if (AuswahlProfilD.Equals(3.0))

            {
                Console.WriteLine("T-Profil");
                Console.WriteLine("Berchnung eines T-Profils");

                Console.WriteLine("Bitte Breite eingeben in cm");
                Breite = Console.ReadLine();

                Console.WriteLine("Bitte Höhe eingeben in cm");
                Hoehe = Console.ReadLine();

                Console.WriteLine("Bitte Wandstärke eingebenin cm");
                Wandstaerke = Console.ReadLine();

                Console.WriteLine("Bitte Länge eingeben in cm");
                Laenge = Console.ReadLine();
                Console.WriteLine();

                WandstaerkeD = Convert.ToDouble(Wandstaerke);
                HoeheD = Convert.ToDouble(Hoehe);
                BreiteD = Convert.ToDouble(Breite);
                LaengeD = Convert.ToDouble(Laenge);

                if (WandstaerkeD.Equals(HoeheD))
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Wandstärke muss kleiner als Höhe Sein");

                }
                else if (WandstaerkeD.Equals(BreiteD))
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Wandstärke muss kleiner als Breite Sein");
                }
                else if (true)
                {
                    Console.WriteLine("Werkstoff auswahl = 1");
                    Console.WriteLine("Manuelle Eingabe der Dichte = 2");
                    AuswahlDichte = Console.ReadLine();

                    AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                    if (AuswahlDichteD.Equals(1.0))
                    {
                        String WerkstoffAuswahl;
                        Double WerkstoffAuswahlD;
                        Console.WriteLine("Werkstoffe:");
                        Console.WriteLine();
                        Console.WriteLine("S235     =1");
                        Console.WriteLine("AlMg4    =2");
                        Console.WriteLine("S355     =3");
                        Console.WriteLine("42CrMo4  =4");
                        Console.WriteLine("E295     =5");
                        Console.WriteLine("E355     =6");
                        Console.WriteLine("C45      =7");

                        WerkstoffAuswahl = Console.ReadLine();

                        WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                        DichteD = WerkstoffSammlung.Werkstoffe(WerkstoffAuswahlD);


                        Berechnungen.Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);

                    }
                    else if (AuswahlDichteD.Equals(2.0))
                    {
                        Console.WriteLine("Bitte die Gewuenschte Dichte Eingeben in g/cm³");
                        Dichte = Console.ReadLine();

                        DichteD = Convert.ToDouble(Dichte);
                        HoeheD = Convert.ToDouble(Hoehe);
                        BreiteD = Convert.ToDouble(Breite);
                        LaengeD = Convert.ToDouble(Laenge);
                        WandstaerkeD = Convert.ToDouble(Wandstaerke);

                        Berechnungen.Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (true)
                    {
                        Console.WriteLine("Falsche eingabe");
                    }
                }

            }           

            Console.WriteLine("Taste drücken zum beenden");
            Console.ReadKey();

        }
   
    }
}
    


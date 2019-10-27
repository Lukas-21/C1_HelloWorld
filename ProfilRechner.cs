using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilRechnerMitWerkstoffauswahl
{
    public static class ProfilRechner
    {
        public static String EndProgramm;
        public static String ProfilAuswahl;
        //Rechteck
        public static String RechteckHoehe;
        public static String RechteckBreite;
        public static String ProfilLaenge;
        public static String ProfilWandstaerke;
        public static String FehlerWandHoehe;
        public static String FehlerWandBreite;
        //Rohr
        public static String RohrDurchmesser;
        public static String FehlerDurchmesserWand;
        //Werkstoffe
        public static String EinleitungWerkstoffe;
        public static String Werkstoffe;
        public static String Error;
        public static String ManuelleDichte ;
        //Helpers
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
                ProfilAuswahl = "Art des Profiles Auswählen" + n + "Bitte Nur ganze Zahlen Eingeben" + n + n + "(1) Rechteck" + n + "(2) Rohr" + n + "(3) T - Profil";
                RechteckHoehe = "Rechteck Profil" + n + "Berechnung eines Rechteckprofiles" + n + "Bitte die Gewuenschte Hoehe Eingeben in mm";
                RechteckBreite = "Bitte die Gewuenschte Breite Eingeben in mm";
                ProfilLaenge = "Bitte die Gewuenschte Laenge Eingebenin mm";
                ProfilWandstaerke = "Bitte die Gewuenschte Wandstaerke Eingeben in mm";
                FehlerWandHoehe = "Falsche Eingabe" + n + "Wandstärke muss kleiner als Höhe sein";
                FehlerWandBreite = "Falsche Eingabe" + n + "Wandstärke muss kleiner als Breite Sein";
                EinleitungWerkstoffe = "(1) Werkstoff auswahl" + n + "(2) Manuelle eingabe der Dichte";
                Werkstoffe = "Werkstoffe";
                Error = "Falsche Eingabe";
                ManuelleDichte = "Bitte die Gewuenschte Dichte Eingeben in g / cm³";
                RohrDurchmesser = "Rohr Profil" + n + "Berechnung eines Rohrprofiles" + n + "Bitte den Gewünschten Durchmesser Eingeben in mm";
                FehlerDurchmesserWand = "Wandstärke muss kleiner als Durchmesser sein";
                EndProgramm = "TAste drücken zum beenden";
            }
            else if (AuswahlSpracheD.Equals(2.0))
            {
                ProfilAuswahl = "Choose the profile" + n + n + "(1) Rectangle" + n + "(2) Pipe" + n + "(3)T-Section";
                RechteckHoehe = "Rectangle Profile" + n + "Calculation started" + n + "Enter hight in mm";
                RechteckBreite = "Enter width in mm";
                ProfilLaenge = "Enter lenght in mm";
                ProfilWandstaerke = "Enter wall thickness";
                FehlerWandHoehe = "Error" + n + "Wall thickness must be lower then hight";
                FehlerWandBreite = "Error" + n + "Wall thickness must be lower then width";
                EinleitungWerkstoffe = "(1) Choose material" + n + "Manually entering  density";
                Error = "Error";
                Werkstoffe = "Materials";
                ManuelleDichte = "Enter density in g/cm³";
                RohrDurchmesser = "Pipe" + n + "Calculation started" + n + "Enter diameter in mm";
                FehlerDurchmesserWand = "Error" + n + "Wall thickness must be lower then diameter";
                EndProgramm = "Use any key to end";

            }
            else if (AuswahlSpracheD.Equals(3.0))
            {
                Console.WriteLine(Error);
            }
            else
            {
                Console.WriteLine(Error);
            }

            Console.WriteLine(ProfilAuswahl);
           
            AuswahlProfil = Console.ReadLine();

            AuswahlProfilD = Convert.ToDouble(AuswahlProfil);


            if (AuswahlProfilD.Equals(1.0))
            {
                Console.WriteLine(RechteckHoehe);             
                Hoehe = Console.ReadLine();

                Console.WriteLine(RechteckBreite);
                Breite = Console.ReadLine();

                Console.WriteLine(ProfilLaenge);
                Laenge = Console.ReadLine();

                Console.WriteLine(ProfilWandstaerke);
                Wandstaerke = Console.ReadLine();
                Console.WriteLine();

                WandstaerkeD = Convert.ToDouble(Wandstaerke);
                HoeheD = Convert.ToDouble(Hoehe);
                BreiteD = Convert.ToDouble(Breite);
                LaengeD = Convert.ToDouble(Laenge);

                if (WandstaerkeD.Equals(HoeheD))
                {
                    Console.WriteLine(FehlerWandHoehe);
                }
                else if (WandstaerkeD.Equals(BreiteD))
                {
                    Console.WriteLine(FehlerWandBreite);                
                }
                else 
                {
                    Console.WriteLine(EinleitungWerkstoffe);                    
                    AuswahlDichte = Console.ReadLine();
                    AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                    if (AuswahlDichteD.Equals(1.0))
                    {
                        String WerkstoffAuswahl;
                        Double WerkstoffAuswahlD;
                        Console.WriteLine(Werkstoffe);
                        Console.WriteLine();
                        Console.WriteLine("(1) S235");
                        Console.WriteLine("(2) AlMg4");
                        Console.WriteLine("(4) S355");
                        Console.WriteLine("(5) 42CrMo4");
                        Console.WriteLine("(6) E295");
                        Console.WriteLine("(7) E355");
                        Console.WriteLine("(8) C45");
                        WerkstoffAuswahl = Console.ReadLine();

                        WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                        DichteD = WerkstoffSammlung.Werkstoffe(WerkstoffAuswahlD);


                        Berechnungen.Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);

                    }
                    else if (AuswahlDichteD.Equals(2.0))
                    {
                        Console.WriteLine(ManuelleDichte);
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
                        Console.WriteLine(Error);
                    }
                }            

            }
            else if (AuswahlProfilD.Equals(2.0))
            {
                Console.WriteLine(RohrDurchmesser);
                Durchmesser = Console.ReadLine();

                Console.WriteLine(ProfilLaenge);
                Laenge = Console.ReadLine();

                Console.WriteLine(ProfilWandstaerke);
                Wandstaerke = Console.ReadLine();
                Console.WriteLine();

                DurchmesserD = Convert.ToDouble(Durchmesser);
                LaengeD = Convert.ToDouble(Laenge);
                WandstaerkeD = Convert.ToDouble(Wandstaerke);

                if (WandstaerkeD.Equals(DurchmesserD))
                {
                    Console.WriteLine(FehlerDurchmesserWand);
                }
                else
                {

                    Console.WriteLine(EinleitungWerkstoffe);
                    AuswahlDichte = Console.ReadLine();

                    AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                    if (AuswahlDichteD.Equals(1.0))
                    {
                        String WerkstoffAuswahl;
                        Double WerkstoffAuswahlD;
                        Console.WriteLine(Werkstoffe);
                        Console.WriteLine();
                        Console.WriteLine("(1) S235");
                        Console.WriteLine("(2) AlMg4");
                        Console.WriteLine("(4) S355");
                        Console.WriteLine("(5) 42CrMo4");
                        Console.WriteLine("(6) E295");
                        Console.WriteLine("(7) E355");
                        Console.WriteLine("(8) C45");
                        WerkstoffAuswahl = Console.ReadLine();

                        WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                        DichteD = WerkstoffSammlung.Werkstoffe(WerkstoffAuswahlD);

                        Berechnungen.Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (AuswahlDichteD.Equals(2.0))
                    {
                        Console.WriteLine(ManuelleDichte);
                        Dichte = Console.ReadLine();

                        DichteD = Convert.ToDouble(Dichte);

                        Berechnungen.Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else 
                    {
                        Console.WriteLine(Error);
                       
                    }
                }
            }
           

            Console.WriteLine(EndProgramm);
            Console.ReadKey();

        }
   
    }
}
    


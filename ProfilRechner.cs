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
        public static String RechteckRohrauswahl;
        public static String RechteckHoehe;
        public static String RechteckBreite;
        public static String ProfilLaenge;
        public static String ProfilWandstaerke;
        public static String FehlerWandHoehe;
        public static String FehlerWandBreite;
        //Kreis
        public static String KreisRohrauswahl;
        public static String RohrDurchmesser;
        public static String FehlerDurchmesserWand;
        //Profile
        public static String IProfilHoehe;
        public static String IProfilStegbreite;
        public static String IProfilFlanschbreite;
        public static String TProfilHoehe;
        public static String UProfilHoehe;
        public static String LProfilHoehe;
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
            String Stegbreite;
            String Flanschbreite;

            Double HoeheD;
            Double BreiteD;
            Double LaengeD;
            Double DichteD;
            Double WandstaerkeD;
            Double DurchmesserD;
            Double AuswahlProfilD;
            Double AuswahlDichteD;
            Double AuswahlSpracheD;
            Double StegbreiteD;
            Double FlanschbreiteD;
          

           
            Console.WriteLine("Please select a language" + n + "(1) English" + n + "(2) Français"  + n + "(3) Deutsch");

            AuswahlSprache =Console.ReadLine();
            AuswahlSpracheD = Convert.ToDouble(AuswahlSprache);

            if (AuswahlSpracheD.Equals(3.0))
            {               
                ProfilAuswahl = "Art des Profiles Auswählen" + n + "Bitte Nur ganze Zahlen Eingeben" + n + n + "(1) Rechteck"
                + n + "(2) Kreis" + n +  "(3) I - Profil" + n + "(4) T - Profil" + n + "(5) U - Profil" + n + "(6) L - Profil" + n + "(7) I - Profil";
                RechteckRohrauswahl = "Rechteck Profil" + n + "Die Berechnung beginnt" + n + "Wollen Sie ein Rohr oder Vollmaterial erstellen?";
                RechteckHoehe = "Bitte die Gewuenschte Hoehe in mm eingeben";
                RechteckBreite = "Bitte die Gewuenschte Breite in mm eingeben!";
                ProfilLaenge = "Bitte die Gewuenschte Laenge in mm eingeben!";
                ProfilWandstaerke = "Bitte die Gewuenschte Wandstaerke in mm eingeben";
                FehlerWandHoehe = "Falsche Eingabe" + n + "Wandstärke muss kleiner als Höhe sein";
                FehlerWandBreite = "Falsche Eingabe" + n + "Wandstärke muss kleiner als Breite Sein";
                EinleitungWerkstoffe = "(1) Werkstoff auswahl" + n + "(2) Manuelle eingabe der Dichte";
                Werkstoffe = "Werkstoffe";
                Error = "Falsche Eingabe";
                ManuelleDichte = "Bitte die Gewuenschte Dichte in g / cm³ eingeben";
                RohrDurchmesser = "Kreis Profil" + n + "Die Berechnung beginnt" + n + "Bitte den Gewünschten Durchmesser in mm eingeben";
                FehlerDurchmesserWand = "Wandstärke muss kleiner als Durchmesser sein!";
                IProfilHoehe = "I - Profil" + n + "Die Berechnung beginnt" + n + "Bitte die Gewuenschte Hoehe in mm eingeben";
                IProfilStegbreite = "Bitte die gewuenschte Stegbreite in mm eingeben";
                IProfilFlanschbreite = "Bitte die gewuenschte Flanschbreite in mm eingeben";
                TProfilHoehe = "T - Profil" + n + "Die Berechnung beginnt" + n + "Bitte die Gewuenschte Hoehe in mm eingeben";
                UProfilHoehe = "U - Profil" + n + "Die Berechnung beginnt" + n + "Bitte die Gewuenschte Hoehe in mm eingeben";
                LProfilHoehe = "L - Profil" + n + "Die Berechnung beginnt" + n + "Bitte die Gewuenschte Hoehe in mm eingeben";
                EndProgramm = "TAste drücken zum beenden";

            }
            else if (AuswahlSpracheD.Equals(1.0))
            {
                ProfilAuswahl = "Choose the profile" + n + "Only enter whole numbers" + n + n + "(1) Rectangle"
                + n + "(2) Circle" + n + "(3) I-Section" + n + "(4) T-Section" + n + "(5) U-Section" + n + "(6) L-Section";
                RechteckRohrauswahl = "Rectangle profile" + n + "Calculation started" + n + "Do you want to create a pipe or solid material";
                RechteckHoehe = "Enter hight in mm";
                RechteckBreite = "Enter width in mm";
                ProfilLaenge = "Enter lenght in mm";
                ProfilWandstaerke = "Enter wall thickness";
                FehlerWandHoehe = "Error" + n + "Wall thickness must be lower then hight";
                FehlerWandBreite = "Error" + n + "Wall thickness must be lower then width";
                EinleitungWerkstoffe = "(1) Choose material" + n + "Manually enter density";
                Error = "Error";
                Werkstoffe = "Materials";
                ManuelleDichte = "Enter density in g/cm³";
                RohrDurchmesser = "Circle profile" + n + "Calculation started" + n + "Enter diameter in mm";
                FehlerDurchmesserWand = "Error" + n + "Wall thickness must be lower then diameter";
                IProfilHoehe = "I-profile" + n + "Calculation started" + n + "Enter hight in mm";
                TProfilHoehe = "T-profile" + n + "Calculation started" + n + "Enter hight in mm";
                UProfilHoehe = "U-profile" + n + "Calculation started" + n + "Enter hight in mm";
                LProfilHoehe = "L-profile" + n + "Calculation started" + n + "Enter hight in mm";
                EndProgramm = "Press any key to end";

            }
            else if (AuswahlSpracheD.Equals(2.0))
            {
                Console.WriteLine("Nous travaillons dans ce part de notre site actuellement");

                ProfilAuswahl = "Veuillez choisir le profil" + n + "Veuillez seulement entrer nombres entiers" + n + n + "(1) Rectangle"
                + n + "(2) Cercle" + n + "(3) I-Profil" + n + "(4) T-Profil" + n + "(5) U-Profil" + n + "(6) L-Profil";
                RechteckRohrauswahl = "Profil rectangle" + n + "La calculation d'un profil rectangle" + n + "Voullez vouz créer une pipe ou du matériau solide?";
                RechteckHoehe = "Entez la hauteur en mm";
                RechteckBreite = "Veuillez entez la largeur en mm";
                ProfilLaenge = "Veuillez entez la longueur en mm";
                ProfilWandstaerke = "Veuillez entez la épaisseur de paroi en mm";
                FehlerWandHoehe = "Erreur" + n + "La épaisseur de paroi droit être moins que la hauter";
                FehlerWandBreite = "Erreur" + n + "La épaisseur de paroi droit être moins que la largeur";
                EinleitungWerkstoffe = "(1) Choisir le material d'une liste" + n + "Entrer la densité manuellement";
                Error = "Erreur";
                Werkstoffe = "Les materials:";
                ManuelleDichte = "Veuillez entez la densité en g/cm³";
                RohrDurchmesser = "Profil cercle" + n + "La calculation d'un profil cercle" + n + "Entez la diamètre en mm";
                FehlerDurchmesserWand = "Error" + n + "La épaisseur de paroi droit être moins que le diamètre";
                IProfilHoehe = "I - profil" + n + "La calculation a commancée" + n + "Entez la hauteur en mm";
                TProfilHoehe = "T - profil" + n + "La calculation a commancée" + n + "Entez la hauteur en mm";
                UProfilHoehe = "U - profil" + n + "La calculation a commancée" + n + "Entez la hauteur en mm";
                LProfilHoehe = "L - profil" + n + "La calculation a commancée" + n + "Entez la hauteur en mm";
                EndProgramm = "Veuillez entrer acun clé pour finir";
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


                        Berechnungen.RechteckRohr(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);

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

                        Berechnungen.RechteckRohr(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (true)
                    {
                        Console.WriteLine(Error);
                    }
                }

            }            
            else if (AuswahlProfilD.Equals(3.0))
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

                        Berechnungen.KreisRohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (AuswahlDichteD.Equals(2.0))
                    {
                        Console.WriteLine(ManuelleDichte);
                        Dichte = Console.ReadLine();

                        DichteD = Convert.ToDouble(Dichte);

                        Berechnungen.KreisRohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else
                    {
                        Console.WriteLine(Error);

                    }
                }
            }
            else if (AuswahlProfilD.Equals(5.0))
            {
                Console.WriteLine();
                Hoehe = Console.ReadLine();

                Console.WriteLine();
                Breite = Console.ReadLine();

                Console.WriteLine();
                Laenge = Console.ReadLine();

                Console.WriteLine();
                Wandstaerke = Console.ReadLine();

                Console.WriteLine();
                Dichte = Console.ReadLine();

                HoeheD = Convert.ToDouble(Hoehe);
                BreiteD = Convert.ToDouble(Breite);
                LaengeD = Convert.ToDouble(Laenge);
                WandstaerkeD = Convert.ToDouble(Wandstaerke);
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

                    Berechnungen.LProfil(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);
                }
                else if (AuswahlDichteD.Equals(2.0))
                {
                    Console.WriteLine(ManuelleDichte);
                    Dichte = Console.ReadLine();

                    DichteD = Convert.ToDouble(Dichte);

                    Berechnungen.LProfil(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);


                }
            }
            else if (AuswahlProfilD.Equals(7.0))
            {
                Console.WriteLine(IProfilHoehe);
                Hoehe = Console.ReadLine();

                Console.WriteLine(RechteckBreite);
                Breite = Console.ReadLine();

                Console.WriteLine(IProfilStegbreite);
                Stegbreite = Console.ReadLine();

                Console.WriteLine(IProfilFlanschbreite);
                Flanschbreite = Console.ReadLine();

                Console.WriteLine(ProfilLaenge);
                Laenge = Console.ReadLine();

                HoeheD = Convert.ToDouble(Hoehe);
                BreiteD = Convert.ToDouble(Breite);
                StegbreiteD = Convert.ToDouble(Stegbreite);
                FlanschbreiteD = Convert.ToDouble(Flanschbreite);
                LaengeD = Convert.ToDouble(Laenge);
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

                    Berechnungen.IProfil(HoeheD, BreiteD, StegbreiteD, FlanschbreiteD, LaengeD, DichteD);
                }
                else if (AuswahlDichteD.Equals(2.0))
                {
                    Console.WriteLine(ManuelleDichte);
                    Dichte = Console.ReadLine();

                    DichteD = Convert.ToDouble(Dichte);

                    Berechnungen.IProfil(HoeheD, BreiteD, StegbreiteD, FlanschbreiteD, LaengeD, DichteD);
                }
            }
            Console.WriteLine(EndProgramm);
            Console.ReadKey();

        }
   
    }
}
    


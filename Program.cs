using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilRechnerMitWerkstoffauswahl
{
    class Program
    {
        static void Main(string[] args)
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


            Double HoeheD;
            Double BreiteD;
            Double LaengeD;
            Double DichteD;
            Double WandstaerkeD;
            Double DurchmesserD;
            Double AuswahlProfilD;
            Double AuswahlDichteD;

            Console.WriteLine("Please select a Language");
            Console.WriteLine("(1) Deutsch");
            Console.WriteLine("(2) English");
            Console.WriteLine("(3) Français");
            String Sprachauswahl = Console.ReadLine();
            Double SprachauswahlD = Convert.ToDouble(Sprachauswahl);

            if (SprachauswahlD.Equals(1.0))
            {
                //Deutsch
                Console.WriteLine("Art des Profiles Auswählen");
                Console.WriteLine("Bitte Nur ganze Zahlen Eingeben");
                Console.WriteLine("Bitte alle Eingaben mit Enter Bestätigen");
                Console.WriteLine();
                Console.WriteLine("(1) Rechteck))");
                Console.WriteLine("(2) Rohr");
                Console.WriteLine("(3) T-Profil");

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
                        Console.WriteLine("(1) Werkstoff auswahl");
                        Console.WriteLine("(2) Manuelle Eingabe der Dichte");
                        AuswahlDichte = Console.ReadLine();

                        AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                        if (AuswahlDichteD.Equals(1.0))
                        {
                            String WerkstoffAuswahl;
                            Double WerkstoffAuswahlD;
                            Console.WriteLine("Werkstoffe:");
                            Console.WriteLine();
                            Console.WriteLine("(1) S235");
                            Console.WriteLine("(2) AlMg4");
                            Console.WriteLine("(3) S355");
                            Console.WriteLine("(4) 42CrMo4");
                            Console.WriteLine("(5) E295");
                            Console.WriteLine("(6) E3555");
                            Console.WriteLine("(7) C45");
                            WerkstoffAuswahl = Console.ReadLine();

                            WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                            DichteD = Werkstoffe(WerkstoffAuswahlD);


                            Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD,SprachauswahlD);

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

                            Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD,SprachauswahlD);
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
                        Console.WriteLine("(1) Werkstoff auswahl");
                        Console.WriteLine("(2) Manuelle Eingabe der Dichte");
                        AuswahlDichte = Console.ReadLine();

                        AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                        if (AuswahlDichteD.Equals(1.0))
                        {
                            String WerkstoffAuswahl;
                            Double WerkstoffAuswahlD;
                            Console.WriteLine("Werkstoffe:");
                            Console.WriteLine();
                            Console.WriteLine("(1) S235");
                            Console.WriteLine("(2) AlMg4");
                            Console.WriteLine("(3) S355");
                            Console.WriteLine("(4) 42CrMo4");
                            Console.WriteLine("(5) E295");
                            Console.WriteLine("(6) E3555");
                            Console.WriteLine("(7) C45");
                            WerkstoffAuswahl = Console.ReadLine();

                            WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                            DichteD = Werkstoffe(WerkstoffAuswahlD);

                            Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD,SprachauswahlD);
                        }
                        else if (AuswahlDichteD.Equals(2.0))
                        {
                            Console.WriteLine("Bitte die Gewuenschte Dichte Eingeben in g/cm³");
                            Dichte = Console.ReadLine();

                            DichteD = Convert.ToDouble(Dichte);

                            Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD,SprachauswahlD);
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
                        Console.WriteLine("(1) Werkstoff auswahl");
                        Console.WriteLine("(2) Manuelle Eingabe der Dichte");
                        AuswahlDichte = Console.ReadLine();

                        AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                        if (AuswahlDichteD.Equals(1.0))
                        {
                            String WerkstoffAuswahl;
                            Double WerkstoffAuswahlD;
                            Console.WriteLine("Werkstoffe:");
                            Console.WriteLine();
                            Console.WriteLine("(1) S235");
                            Console.WriteLine("(2) AlMg4");
                            Console.WriteLine("(3) S355");
                            Console.WriteLine("(4) 42CrMo4");
                            Console.WriteLine("(5) E295");
                            Console.WriteLine("(6) E3555");
                            Console.WriteLine("(7) C45");

                            WerkstoffAuswahl = Console.ReadLine();

                            WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                            DichteD = Werkstoffe(WerkstoffAuswahlD);


                            TProfil(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD,SprachauswahlD);

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

                            TProfil(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD,SprachauswahlD);
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

            else if (SprachauswahlD.Equals(2.0))
            {
                //Englisch
                Console.WriteLine("Choose your Profiles ");                
                Console.WriteLine("Please confirm with  the enter key");
                Console.WriteLine();
                Console.WriteLine("(1) Rectangle))");
                Console.WriteLine("(2) Pipe");
                Console.WriteLine("(3) T-Profile");

                AuswahlProfil = Console.ReadLine();

                AuswahlProfilD = Convert.ToDouble(AuswahlProfil);


                if (AuswahlProfilD.Equals(1.0))
                {
                    Console.WriteLine("Retangle profile");

                    Console.WriteLine("Please enter hight in cm");
                    Hoehe = Console.ReadLine();

                    Console.WriteLine("Please enter width in cm");
                    Breite = Console.ReadLine();

                    Console.WriteLine("Please enter lenght in cm");
                    Laenge = Console.ReadLine();

                    Console.WriteLine("Please enter thickness in cm");
                    Wandstaerke = Console.ReadLine();
                    Console.WriteLine();

                    WandstaerkeD = Convert.ToDouble(Wandstaerke);
                    HoeheD = Convert.ToDouble(Hoehe);
                    BreiteD = Convert.ToDouble(Breite);
                    LaengeD = Convert.ToDouble(Laenge);

                    if (WandstaerkeD.Equals(HoeheD))
                    {
                        Console.WriteLine("Error");
                        Console.WriteLine("Thickness must be less then hight");

                    }
                    else if (WandstaerkeD.Equals(BreiteD))
                    {
                        Console.WriteLine("Error");
                        Console.WriteLine("Thickness must be less then width");
                    }
                    else if (true)
                    {
                        Console.WriteLine("(1) Choosing material out of catalog");
                        Console.WriteLine("(2) Enter density manually");
                        AuswahlDichte = Console.ReadLine();

                        AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                        if (AuswahlDichteD.Equals(1.0))
                        {
                            String WerkstoffAuswahl;
                            Double WerkstoffAuswahlD;
                            Console.WriteLine("Materials:");
                            Console.WriteLine();
                            Console.WriteLine("(1) S235");
                            Console.WriteLine("(2) AlMg4");
                            Console.WriteLine("(3) S355");
                            Console.WriteLine("(4) 42CrMo4");
                            Console.WriteLine("(5) E295");
                            Console.WriteLine("(6) E3555");
                            Console.WriteLine("(7) C45");
                            WerkstoffAuswahl = Console.ReadLine();

                            WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                            DichteD = Werkstoffe(WerkstoffAuswahlD);


                            Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD, SprachauswahlD);

                        }
                        else if (AuswahlDichteD.Equals(2.0))
                        {
                            Console.WriteLine("Enter density in g/cm³");
                            Dichte = Console.ReadLine();

                            DichteD = Convert.ToDouble(Dichte);
                            HoeheD = Convert.ToDouble(Hoehe);
                            BreiteD = Convert.ToDouble(Breite);
                            LaengeD = Convert.ToDouble(Laenge);
                            WandstaerkeD = Convert.ToDouble(Wandstaerke);

                            Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD, SprachauswahlD);
                        }
                        else if (true)
                        {
                            Console.WriteLine("Error");
                        }
                    }

                }
                else if (AuswahlProfilD.Equals(2.0))
                {
                    Console.WriteLine("Pipe profile");
                    
                    Console.WriteLine("Enter diameter in cm");
                    Durchmesser = Console.ReadLine();

                    Console.WriteLine("Enter length in cm");
                    Laenge = Console.ReadLine();

                    Console.WriteLine("Enter thickness in cm");
                    Wandstaerke = Console.ReadLine();
                    Console.WriteLine();

                    DurchmesserD = Convert.ToDouble(Durchmesser);
                    LaengeD = Convert.ToDouble(Laenge);
                    WandstaerkeD = Convert.ToDouble(Wandstaerke);

                    if (WandstaerkeD.Equals(DurchmesserD))
                    {
                        Console.WriteLine("Error");
                    }
                    else if (true)
                    {
                        Console.WriteLine("(1) Choose material out of catalog");
                        Console.WriteLine("(2) Enter density manually");
                        AuswahlDichte = Console.ReadLine();

                        AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                        if (AuswahlDichteD.Equals(1.0))
                        {
                            String WerkstoffAuswahl;
                            Double WerkstoffAuswahlD;
                            Console.WriteLine("Materials:");
                            Console.WriteLine();
                            Console.WriteLine("(1) S235");
                            Console.WriteLine("(2) AlMg4");
                            Console.WriteLine("(3) S355");
                            Console.WriteLine("(4) 42CrMo4");
                            Console.WriteLine("(5) E295");
                            Console.WriteLine("(6) E3555");
                            Console.WriteLine("(7) C45");
                            WerkstoffAuswahl = Console.ReadLine();

                            WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                            DichteD = Werkstoffe(WerkstoffAuswahlD);

                            Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD, SprachauswahlD);
                        }
                        else if (AuswahlDichteD.Equals(2.0))
                        {
                            Console.WriteLine("Enter density in g/cm³");
                            Dichte = Console.ReadLine();

                            DichteD = Convert.ToDouble(Dichte);

                            Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD, SprachauswahlD);
                        }
                        else if (true)
                        {
                            Console.WriteLine("Erroe");
                            Console.WriteLine("Thickness must be less than diameter");
                        }

                    }






                }
                else if (AuswahlProfilD.Equals(3.0))

                {
                    Console.WriteLine("T-Profile");
                 
                    Console.WriteLine("Enter width in cm");
                    Breite = Console.ReadLine();

                    Console.WriteLine("Enter hight in cm");
                    Hoehe = Console.ReadLine();

                    Console.WriteLine("Enter thickness in cm");
                    Wandstaerke = Console.ReadLine();

                    Console.WriteLine("Enter lenght in cm");
                    Laenge = Console.ReadLine();
                    Console.WriteLine();

                    WandstaerkeD = Convert.ToDouble(Wandstaerke);
                    HoeheD = Convert.ToDouble(Hoehe);
                    BreiteD = Convert.ToDouble(Breite);
                    LaengeD = Convert.ToDouble(Laenge);

                    if (WandstaerkeD.Equals(HoeheD))
                    {
                        Console.WriteLine("Error");
                        Console.WriteLine("Thickness must be less then hight");

                    }
                    else if (WandstaerkeD.Equals(BreiteD))
                    {
                        Console.WriteLine("Error");
                        Console.WriteLine("Tickness must be less than width");
                    }
                    else if (true)
                    {
                        Console.WriteLine("(1) Choose material out of catalog");
                        Console.WriteLine("(2) Enter density manually");
                        AuswahlDichte = Console.ReadLine();

                        AuswahlDichteD = Convert.ToDouble(AuswahlDichte);

                        if (AuswahlDichteD.Equals(1.0))
                        {
                            String WerkstoffAuswahl;
                            Double WerkstoffAuswahlD;
                            Console.WriteLine("Materials:");
                            Console.WriteLine();
                            Console.WriteLine("(1) S235");
                            Console.WriteLine("(2) AlMg4");
                            Console.WriteLine("(3) S355");
                            Console.WriteLine("(4) 42CrMo4");
                            Console.WriteLine("(5) E295");
                            Console.WriteLine("(6) E3555");
                            Console.WriteLine("(7) C45");

                            WerkstoffAuswahl = Console.ReadLine();

                            WerkstoffAuswahlD = Convert.ToDouble(WerkstoffAuswahl);

                            DichteD = Werkstoffe(WerkstoffAuswahlD);


                            TProfil(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD, SprachauswahlD);

                        }
                        else if (AuswahlDichteD.Equals(2.0))
                        {
                            Console.WriteLine("Enter density in g/cm³");
                            Dichte = Console.ReadLine();

                            DichteD = Convert.ToDouble(Dichte);
                            HoeheD = Convert.ToDouble(Hoehe);
                            BreiteD = Convert.ToDouble(Breite);
                            LaengeD = Convert.ToDouble(Laenge);
                            WandstaerkeD = Convert.ToDouble(Wandstaerke);

                            TProfil(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD, SprachauswahlD);
                        }
                        else if (true)
                        {
                            Console.WriteLine("Error");
                        }
                    }

                }

                Console.WriteLine("Push any button to close");
                Console.ReadKey();
            }
            else if (SprachauswahlD.Equals(3.0))
            {

            }
            else
            {

            }


        }
        static void Rechteck(Double Höhe1, Double Breite1, Double Länge1, Double Wandstärke1, Double Dichte1,Double Sprache)
        {
            //Ergebniss Variablen
            Double Volumen;
            Double Querschnitt;
            Double Gewicht;
            Double FTM;
            if (Sprache.Equals(1.0))
            {
                //Berechnung  Querschnitt

                Querschnitt = (Höhe1 - Wandstärke1) * (Breite1 - Wandstärke1);

                Console.WriteLine("Querschnitt:");
                Console.WriteLine(Querschnitt + "cm²");

                //Berechnung Volumen 

                Volumen = (Höhe1 * Breite1 * Länge1) - ((Höhe1 - Wandstärke1) * (Breite1 - Wandstärke1) * Länge1);

                Console.WriteLine("Volumen:");
                Console.WriteLine(Volumen + "cm³");

                //Berechnung Gewicht 

                Gewicht = Dichte1 * Volumen;

                Console.WriteLine("Gewicht:");
                Console.WriteLine(Gewicht + "g");
            }
            else if (Sprache.Equals(2.0))
            {
                //Berechnung  Querschnitt

                Querschnitt = (Höhe1 - Wandstärke1) * (Breite1 - Wandstärke1);

                Console.WriteLine("Cross-Section:");
                Console.WriteLine(Querschnitt + "cm²");

                //Berechnung Volumen 

                Volumen = (Höhe1 * Breite1 * Länge1) - ((Höhe1 - Wandstärke1) * (Breite1 - Wandstärke1) * Länge1);

                Console.WriteLine("Volume:");
                Console.WriteLine(Volumen + "cm³");

                //Berechnung Gewicht 

                Gewicht = Dichte1 * Volumen;

                Console.WriteLine("Weight:");
                Console.WriteLine(Gewicht + "g");
            }
            else
            {
                Console.WriteLine("Error");  
            }

           
        }

        static void Rohr(Double Durchmesser1, Double Laenge1, Double Wandstaerke1, Double Dichte1,Double Sprache)
        {
            Double Voulumen;
            Double Querschnitt;
            Double Gewicht;
            Double FTM;
            Double DurchmesserQ;

            DurchmesserQ = Math.Pow(Durchmesser1, 2);

            if (Sprache.Equals(1.0))
            {
                //Querschnitt
                Querschnitt = (Math.PI * DurchmesserQ) / 4;

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
            }
            else if (Sprache.Equals(2.0))
            {
                //Querschnitt
                Querschnitt = (Math.PI * DurchmesserQ) / 4;

                Console.WriteLine("Cross-Section:");
                Console.WriteLine(Querschnitt + "cm²");

                //Volumen

                Voulumen = (((Math.PI * DurchmesserQ) / 4) * Laenge1) - (((Math.PI * (DurchmesserQ - Wandstaerke1)) / 4) * Laenge1);

                Console.WriteLine("Voulume:");
                Console.WriteLine(Voulumen + "cm³");

                //Gewicht

                Gewicht = Dichte1 * Voulumen;

                Console.WriteLine("Weight:");
                Console.WriteLine(Gewicht + "g");
            }
            else
            {
                Console.WriteLine("Error");
            }
           

        }
        static void TProfil(Double Breite1, Double Hoehe1, Double Laenge1, Double Wandstaerke1, Double Dichte1,Double Sprache)
        {
            Double Volumen;
            Double Querschnitt;
            Double Gewicht;
            Double FTM;
            if (Sprache.Equals(1.0))
            {
                //Querschnitt
                Querschnitt = (Wandstaerke1 * Breite1) + (Breite1 * (Hoehe1 - Wandstaerke1));

                Console.WriteLine("Querschnitt:");
                Console.WriteLine(Querschnitt + "cm²");

                //Voulumen
                Volumen = (Wandstaerke1 * Breite1 * Laenge1) + ((Hoehe1 - Wandstaerke1) * Breite1 * Laenge1);

                Console.WriteLine("Volumen");
                Console.WriteLine(Volumen + "cm³");

                //Gewicht
                Gewicht = Volumen * Dichte1;

                Console.WriteLine("Gewicht:");
                Console.WriteLine(Gewicht + "g");
            }
            else if (Sprache.Equals(2.0))
            {
                //Querschnitt
                Querschnitt = (Wandstaerke1 * Breite1) + (Breite1 * (Hoehe1 - Wandstaerke1));

                Console.WriteLine("Cross-Section:");
                Console.WriteLine(Querschnitt + "cm²");

                //Voulumen
                Volumen = (Wandstaerke1 * Breite1 * Laenge1) + ((Hoehe1 - Wandstaerke1) * Breite1 * Laenge1);

                Console.WriteLine("Volume");
                Console.WriteLine(Volumen + "cm³");

                //Gewicht
                Gewicht = Volumen * Dichte1;

                Console.WriteLine("Weight:");
                Console.WriteLine(Gewicht + "g");
            }
            else
            {
                Console.WriteLine("Error");
            }
            
        }

        static Double Werkstoffe(Double WerkstoffNummer)
        {
            Double WerkstoffDichte;
            if (WerkstoffNummer.Equals(1.0))
            {
                //S253
                WerkstoffDichte = 7.84;
                return WerkstoffDichte;
            }
            else if (WerkstoffNummer.Equals(2.0))  
            {
                //AlMg4
                WerkstoffDichte = 2.66;
                return WerkstoffDichte;
                
            }
            else if (WerkstoffNummer.Equals(3.0))
            {
                //S355
                WerkstoffDichte = 7.84;
                return WerkstoffDichte;
            }
            else if (WerkstoffNummer.Equals(4.0))
            {
                //42CrMo4
                WerkstoffDichte = 7.72;
                return WerkstoffDichte;
            }
            else if (WerkstoffNummer.Equals(5.0))
            {
                //E295
                WerkstoffDichte = 7.85;
                return WerkstoffDichte;
            }
            else if (WerkstoffNummer.Equals(6.0))
            {
                //E355
                WerkstoffDichte = 7.85;
                return WerkstoffDichte;
            }
            else if (WerkstoffNummer.Equals(7.0))
            {
                //C45
                WerkstoffDichte = 7.85;
                return WerkstoffDichte;
            }
            else if (true)
            {
                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("Bitte Dichte Manuell eingeben");
                String Dichte = Console.ReadLine();
                WerkstoffDichte = Convert.ToDouble(Dichte);
                return WerkstoffDichte;
            }

        }
    }
}
    


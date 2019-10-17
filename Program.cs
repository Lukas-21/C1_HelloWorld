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
            Console.WriteLine("Art des Profiles Auswählen");
            Console.WriteLine("Bitte Nur ganze Zahlen Eingeben");
            Console.WriteLine("Bitte alle Eingaben mit Enter Bestätigen");
            Console.WriteLine();
            Console.WriteLine("(1) Rechteck,(2) Rohr,(3) T-Profil");
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


                        Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);

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

                        Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);
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

                        Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
                    }
                    else if (AuswahlDichteD.Equals(2.0))
                    {
                        Console.WriteLine("Bitte die Gewuenschte Dichte Eingeben in g/cm³");
                        Dichte = Console.ReadLine();

                        DichteD = Convert.ToDouble(Dichte);

                        Rohr(DurchmesserD, LaengeD, WandstaerkeD, DichteD);
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


                        Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);

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

                        Rechteck(HoeheD, BreiteD, LaengeD, WandstaerkeD, DichteD);
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

        static void Rechteck(Double Höhe1, Double Breite1, Double Länge1, Double Wandstärke1, Double Dichte1)
        {
            //Ergebniss Variablen
            Double Volumen;
            Double Querschnitt;
            Double Gewicht;
            Double FTM;

            //Berechnung  Querschnitt

            Querschnitt = (Höhe1 - Wandstärke1) * ( Breite1 - Wandstärke1);

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

        static void Rohr(Double Durchmesser1, Double Laenge1, Double Wandstaerke1, Double Dichte1)
        {
            Double Voulumen;
            Double Querschnitt;
            Double Gewicht;
            Double FTM;
            Double DurchmesserQ;

                DurchmesserQ = Math.Pow(Durchmesser1, 2);
                

            //Querschnitt
            Querschnitt = (Math.PI * DurchmesserQ) / 4;

            Console.WriteLine("Querschnitt:");
            Console.WriteLine(Querschnitt + "cm²");

            //Volumen

            Voulumen = (((Math.PI * DurchmesserQ ) /4) * Laenge1) - (((Math.PI * (DurchmesserQ - Wandstaerke1)) / 4) * Laenge1);

            Console.WriteLine("Voulumen:");
            Console.WriteLine(Voulumen + "cm³");

            //Gewicht

            Gewicht = Dichte1 * Voulumen;

            Console.WriteLine("Gewicht:");
            Console.WriteLine(Gewicht + "g");

        }
        static void TProfil(Double Breite1, Double Hoehe1, Double Laenge1, Double Wandstaerke1, Double Dichte1)
        {
            Double Volumen;
            Double Querschnitt;
            Double Gewicht;
            Double FTM;

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
    


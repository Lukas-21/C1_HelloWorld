using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilRechnerMitWerkstoffauswahl
{
    public static class  WerkstoffSammlung
    {
        public static Double Werkstoffe(Double WerkstoffNummer)
        {
            Double WerkstoffDichte;
            String b = ProfilRechner.Begruessung;
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

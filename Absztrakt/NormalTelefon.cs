using System;
using System.Collections.Generic;
using System.Text;

namespace Absztrakt
{
    public class NormalTelefon : Telefon
    {
        public int maxToltottseg { get; set; }
        public int aktualisToltottseg { get; set; }

        public NormalTelefon(int ar, List<String> tudaslista,int maxToltottseg, int aktualisToltottseg)
        {
            this.ar = ar;
            this.tudja = tudaslista;
            this.maxToltottseg = maxToltottseg;
            this.aktualisToltottseg = aktualisToltottseg;
        }
        public int MeddigBirja()
        {
            return maxToltottseg - aktualisToltottseg;
        }

        public override string ToString()
        {
            return $"{ar}Ft  {String.Join(" ",tudja)} max: {maxToltottseg}Ah, aktuális: {aktualisToltottseg}Ah";
        }
    }
}

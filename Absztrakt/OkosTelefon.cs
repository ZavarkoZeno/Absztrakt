using System;
using System.Collections.Generic;
using System.Text;

namespace Absztrakt
{
    internal class OkosTelefon : NormalTelefon
    {
        public String OS { get; set; }
        public OkosTelefon(int ar, List<String> tudaslista, String OS) : base(ar, tudaslista, 0, 0)
        {
            this.OS = OS;
        }
        public bool telepitheto(String telepites)
        {
            return tudja.Contains(telepites);
        }

        public override string ToString()
        {
            return $"{ar}Ft  {String.Join(" ",tudja)} OS: {OS}";
        }
    }
}

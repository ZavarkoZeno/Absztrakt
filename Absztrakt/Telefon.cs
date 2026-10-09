using System;
using System.Collections.Generic;
using System.Text;

namespace Absztrakt
{
    public abstract class Telefon
    {
        public int ar { get; set; }
        public List<String> tudja { get; set; }
        public bool tud(String tudas)
        {
            return tudja.Contains(tudas);
        }
    }
}

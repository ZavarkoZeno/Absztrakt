namespace Absztrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon t1 = new NormalTelefon(100000, new List<String> {"SMS", "SOS"}, 2400, 2000);
            Console.WriteLine(t1);
            Telefon t2 = new OkosTelefon(200000, new List<String> {"Internet"}, "Android");
            Console.WriteLine(t2);
            List<Telefon> telefonok = new List<Telefon>();
            telefonok.Add(t1);
            telefonok.Add(t2);
            foreach (var t in telefonok)
            {
                Console.WriteLine(t);
            }
            int db = 0;
            foreach (var t in telefonok)
            {
                if (t.tud("SOS"))
                {
                    db++;
                }
            }
            Console.WriteLine($"Az SOS-t alkalmas telefonko száma: {db}");

            int BirasiAtlag = 0;
            int Tdb = 0;
            foreach (var t in telefonok)
            {
                BirasiAtlag += ((NormalTelefon)t).MeddigBirja();
                Tdb++;
            }
            if (Tdb > 0)
            {
                Console.WriteLine($"A telefonok birási átlaga: {BirasiAtlag / Tdb} Ah");
            }

            int TudasDb = telefonok[0].tudja.Count();
            string TudasID = telefonok[0].ToString();
            foreach (var t in telefonok)
            {
                if (t.tudja.Count() > TudasDb)
                {
                    TudasDb = t.tudja.Count();
                    TudasID = t.ToString();
                }
                Console.WriteLine($"A {TudasID} típusú telefon tárolja a legtöbb tudást: {TudasDb}");
            }
        }
    }
}

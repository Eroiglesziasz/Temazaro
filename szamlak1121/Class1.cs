using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlak1121
{
    internal class szamla
    {
        int id;
        string nev;
        int egyenleg;
        DateTime datum;

        public szamla(int id, string nev, int egyenleg, DateTime datum)
        {
            this.id = id;
            this.nev = nev;
            this.egyenleg = egyenleg;
            this.datum = datum;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Egyenleg { get => egyenleg; set => egyenleg = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }
}

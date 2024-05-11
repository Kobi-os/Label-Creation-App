using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public abstract class Producent
    {
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public int Nip { get; set; }

        public Producent(string nazwa, string adres, int nip) 
        {
            Nazwa = nazwa;
            Adres = adres;
            Nip = nip;
        }


    }
}

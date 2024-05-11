using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public class Pocisk : Luska
    {
        public string RodzajPocisku;
        public Pocisk (string rodzajPocisku ,string shellType, int bulletNumber, string nazwa, string adres, int nip) : base(shellType, bulletNumber, nazwa, adres, nip)
        {
            RodzajPocisku = rodzajPocisku;
        }
    }
}

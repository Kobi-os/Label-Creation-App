using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public class Luska : Srut
    {
        public string ShellType;
        public Luska(string shellType ,int bulletNumber, string nazwa, string adres, int nip) : base(bulletNumber, nazwa, adres, nip)
        {
            ShellType = shellType;
        }
    }
}

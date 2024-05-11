using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public class Magazynek : Pocisk
    {
        public Magazynek(string rodzajPocisku,string shellType,int bulletNumber, string nazwa, string adres, int nip) : base(rodzajPocisku, shellType, bulletNumber, nazwa, adres, nip)
        {
            RodzajPocisku = rodzajPocisku;
            ShellType = shellType;
            BulletNumber = bulletNumber;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"{RodzajPocisku} {ShellType} {BulletNumber} {Nazwa} {Adres} {Nip}");
        }
    }
}

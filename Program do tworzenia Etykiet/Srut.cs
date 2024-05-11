using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public class Srut : Producent
    {
        public int BulletNumber { get; set; }

        public Srut(int bulletNumber, string nazwa, string adres, int nip) : base(nazwa, adres, nip)
        {
/*            Random random = new Random();
            bulletNumber = random.Next(1, 50);*/
            BulletNumber = bulletNumber;

        }
    }
}

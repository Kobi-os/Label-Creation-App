using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public class Kolczan : Strzaly
    {
        public Kolczan(string arrowType, string typGrotu, double dlugoscGrotu) : base(arrowType, typGrotu, dlugoscGrotu)
        {
            ArrowType = arrowType;
            TypGrotu = typGrotu;
            DlugoscGrotu = dlugoscGrotu;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"{ArrowType}, {TypGrotu}, {DlugoscGrotu}");
        }
    }
}

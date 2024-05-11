using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public class Grot
    {
        public string TypGrotu { get; set; }
        public double DlugoscGrotu { get; set;}

        public Grot(string typGrotu, double dlugoscGrotu) 
        {
            TypGrotu = typGrotu;
            DlugoscGrotu = dlugoscGrotu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_Creating_App
{
    public class Strzaly : Grot
    {
        public string ArrowType { get; set; }


        public Strzaly(string arrowType, string typGrotu, double dlugoscGrotu) : base(typGrotu, dlugoscGrotu)
        {
            ArrowType = arrowType;
        }
    }
}

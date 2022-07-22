using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220406_CsGo
{
    abstract class Silah
    {
        public int agirlik { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public bool ateslimi { get; set; }
        public int menzil { get; set; }


        abstract public sbyte damage(sbyte giris);

    }
}

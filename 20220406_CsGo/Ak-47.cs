using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220406_CsGo
{
    class Ak_47:Silah
    {
        public byte yenileme()
        {
            return 30;
        }
        public override sbyte damage(sbyte giris)
        {
            giris -= 35;

            if (giris <= 0)
            {

                return 0;
            }
            return giris;

        }
    }
}



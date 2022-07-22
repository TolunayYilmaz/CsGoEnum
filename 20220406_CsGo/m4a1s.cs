using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220406_CsGo
{
    class m4a1s:Silah
    {
        public byte yenileme()
        {
            return 25;
        }
        public override sbyte damage(sbyte giris)
        {
            giris -= 25;

            if (giris <= 0)
            {

                return 0;
            }
            return giris;

        }
    }
}

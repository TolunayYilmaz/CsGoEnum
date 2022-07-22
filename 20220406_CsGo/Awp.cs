using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220406_CsGo
{
    class Awp:Silah,DurbunInterface
    {
        public sbyte durbundamage { get; set; } = 100;

        public byte yenileme()
        {
            return 7;
        }
        public override sbyte damage(sbyte giris)
        {
            giris -= 45;

            if (giris <= 0)
            {

                return 0;
            }
            return giris;

        }
        public sbyte damage2(sbyte giris)
        {
            giris -= durbundamage;

            if (giris <= 0)
            {

                return 0;
            }
            return giris;

        }

    }
}

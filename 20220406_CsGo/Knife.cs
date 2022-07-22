using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220406_CsGo
{
    class Knife : Silah, yenile
    {

        public byte yenileme()
        {
            return 5;
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

    }
}

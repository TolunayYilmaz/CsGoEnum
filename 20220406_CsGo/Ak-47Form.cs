using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220406_CsGo
{
    public partial class Ak_47Form : Form, Düsman, AtesliSilah
    {
        Ak_47 Ak47Üret=new Ak_47();
        public sbyte health { get; set; } = 100;
        public byte sarjor { get; set; } = 30;
        public int OluSayisi { get; set; } = 1;
        public Ak_47Form()
        {
            InitializeComponent();
        }

        void Ak47Hasar()
        {

            if (sarjor > 0)
            {
                label1.Text = Ak47Üret.damage(health).ToString();
                health = Ak47Üret.damage(health);
                canProgress.Value = health;

                if (health == 0)
                {
                    label2.Text = (OluSayisi++).ToString();
                    health = 100;
                    canProgress.Value = health;
                    label1.Text = health.ToString();
                }
                sarjor--;
                SarjorProgress.Value = (sarjor * 100) / 30;
            }

            else if (sarjor == 0)
            {
                MessageBox.Show("Mermin bitti");

            }
        }
        private void Ak_47Form_Load(object sender, EventArgs e)
        {
            canProgress.Value = health;
            SarjorProgress.Value = (sarjor * 100) / 30; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ak47Hasar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sarjor = Ak47Üret.yenileme();
            SarjorProgress.Value = (sarjor * 100)/30;
        }
    }
}

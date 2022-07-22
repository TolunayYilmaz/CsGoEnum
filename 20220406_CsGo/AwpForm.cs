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
    public partial class AwpForm : Form,Düsman,AtesliSilah

    {
        Awp AwpUret = new Awp();


        public sbyte health { get; set; } = 100;
        public byte sarjor { get; set; } = 7;
        public int OluSayisi { get; set; } = 1;
        
        public AwpForm()
        {
            InitializeComponent();
        }

        private void AwpForm_Load(object sender, EventArgs e)
        {
            canProgress.Value = health;
            SarjorProgress.Value = (sarjor * 100) / 7;
        }

        void AwpHasar()
        { 

            if (sarjor > 0)
            {
                label1.Text = AwpUret.damage(health).ToString();
                health = AwpUret.damage(health);
                canProgress.Value = health;

                if (health == 0)
                {
                    label2.Text = (OluSayisi++).ToString();
                    health = 100;
                    canProgress.Value = health;
                    label1.Text = health.ToString();
                }
                sarjor--;
                SarjorProgress.Value = (sarjor * 100) / 7;
            }


            else if (sarjor == 0)
            {
                MessageBox.Show("Mermin bitti");

            }
        }
        void AwpHasarDurbun()
        {

            if (sarjor > 0)
            {
                label1.Text = AwpUret.damage2(health).ToString();
                health = AwpUret.damage2(health);
                canProgress.Value = health;

                if (health == 0)
                {
                    label2.Text = (OluSayisi++).ToString();
                    health = 100;
                    canProgress.Value = health;
                    label1.Text = health.ToString();
                }
                sarjor--;
                SarjorProgress.Value = (sarjor * 100) / 7;
            }


            else if (sarjor == 0)
            {
                MessageBox.Show("Mermin bitti");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AwpHasar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sarjor = AwpUret.yenileme();
            SarjorProgress.Value = (sarjor * 100)/7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AwpHasarDurbun();
        }
    }
}

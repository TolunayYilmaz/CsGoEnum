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
    public partial class m4a1sform : Form,Düsman,AtesliSilah
    {
        m4a1s m4uret = new m4a1s();


        public sbyte health { get; set; } = 100;
        public byte sarjor { get; set; } = 25;
        public int OluSayisi { get; set; } = 1;
        
   
        
        public m4a1sform()
        {
            InitializeComponent();
        }

        private void m4a1sform_Load(object sender, EventArgs e)
        {
            canProgress.Value = health;
            SarjorProgress.Value = sarjor*4;
        }
        void m4a1s()
        {
            
            if (sarjor > 0)
            {
                label1.Text = m4uret.damage(health).ToString();
                health = m4uret.damage(health);
                canProgress.Value = health;
                
                if (health == 0)
                {
                    label2.Text = (OluSayisi++).ToString();
                    health = 100;
                    canProgress.Value = health;
                    label1.Text = health.ToString();
                }
                sarjor--;
                SarjorProgress.Value = sarjor * 4;
            }

            else if (sarjor == 0)
            {
                MessageBox.Show("Mermin bitti");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            m4a1s();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sarjor = m4uret.yenileme();
            SarjorProgress.Value = sarjor * 4;
        }

  
    }
}

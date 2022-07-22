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
    
    public partial class Bıcak : Form
    {
        Knife bıcakla = new Knife();
        public byte sarjor { get; set; } = 5;
        public sbyte health { get; set; } = 100;
        public int OluSayisi { get; set; } = 1;
        public Bıcak()
        {
            InitializeComponent();
        }
       
    
       void bıcak()
        {
            if (sarjor > 0)
            {  
                label1.Text = bıcakla.damage(health).ToString();
                health = bıcakla.damage(health);
                canProgress.Value = health;
                if (health <= 0)//?
                {
                  label2.Text = (OluSayisi++).ToString();
                  health = 100;
                  canProgress.Value = health;
                  label1.Text = health.ToString(); 
                }
                sarjor--;
                SarjorProgress.Value = sarjor * 20;
            }
      
            else if (sarjor == 0)
            {
                MessageBox.Show("Bıçağı bileyle dileyley");
                
            }
        }

   

   

        private void Bıcak_Load(object sender, EventArgs e)
        {
            canProgress.Value = health;
            SarjorProgress.Value = sarjor*20;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bıcak();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sarjor = bıcakla.yenileme();
            SarjorProgress.Value = sarjor * 20;
        }
    }
}

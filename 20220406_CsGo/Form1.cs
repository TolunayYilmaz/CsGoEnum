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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Özellikler
        void bicaközellik()
        {
            Knife bıcaközellik = new Knife();
            bıcaközellik.agirlik = 120;
            bıcaközellik.ateslimi = false;
            bıcaközellik.marka = "QuarterMAster";
            bıcaközellik.model = "S1";
            bıcaközellik.menzil = 1;
            MessageBox.Show("Ağırlık(Gr): "+bıcaközellik.agirlik.ToString() 
                +"\nAteşli mi: "+bıcaközellik.ateslimi + "\nMarka: " + bıcaközellik.marka + "\nModel: " + bıcaközellik.model
                + "\nMenzil: " + bıcaközellik.menzil);
        }
        void m4a1sözellik1()
        {
            m4a1s m4a1sözellikekle = new m4a1s();
            m4a1sözellikekle.agirlik = 4556;
            m4a1sözellikekle.ateslimi = true;
            m4a1sözellikekle.marka = "Sarsılmaz";
            m4a1sözellikekle.menzil = 550;
            m4a1sözellikekle.model = "T12";
            MessageBox.Show("Ağırlık(Gr): " + m4a1sözellikekle.agirlik.ToString()
                + "\nAteşli mi: " + m4a1sözellikekle.ateslimi + "\nMarka: " + m4a1sözellikekle.marka + "\nModel: " + m4a1sözellikekle.model + "\nMenzil: " + m4a1sözellikekle.menzil);
        }
        void ak47Ozellik()
        {
            Ak_47 ak47özellikekle = new Ak_47();
            ak47özellikekle.agirlik = 5000;
            ak47özellikekle.ateslimi = true;
            ak47özellikekle.marka = "Ak-47";
            ak47özellikekle.model = "K35";
            ak47özellikekle.menzil = 750;
            MessageBox.Show("Ağırlık(Gr): " + ak47özellikekle.agirlik.ToString()
                + "\nAteşli mi: " + ak47özellikekle.ateslimi + "\nMarka: " + ak47özellikekle.marka + "\nModel: " + ak47özellikekle.model + "\nMenzil: " + ak47özellikekle.menzil);
        }
        void AwpOzellik()
        {
            Awp Awpözellikekle = new Awp();
            Awpözellikekle.agirlik = 6200;
            Awpözellikekle.ateslimi = true;
            Awpözellikekle.marka = "AWP";
            Awpözellikekle.model = "Z-12";
            Awpözellikekle.menzil = 2500;
            MessageBox.Show("Ağırlık(Gr): " + Awpözellikekle.agirlik.ToString()
                + "\nAteşli mi: " + Awpözellikekle.ateslimi + "\nMarka: " + Awpözellikekle.marka + "\nModel: " + Awpözellikekle.model + "\nMenzil: " + Awpözellikekle.menzil);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void bicak_Click(object sender, EventArgs e)
        {
            bicaközellik();
        }

        private void m4a1s_Click(object sender, EventArgs e)
        {
            m4a1sözellik1();
        }

        private void ak47Btn_Click(object sender, EventArgs e)
        {
            ak47Ozellik();
        }

        private void AwpBtn_Click(object sender, EventArgs e)
        {
            AwpOzellik();
        }

        private void BigiBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 Tuşu: Bıçak" +"\n2 Tuşu: M4A1S" + "\n3 Tuşu: Ak-47" + "\n4 Tuşu: Awp");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                Bıcak formacm4 = new Bıcak();
                formacm4.ShowDialog();
            }
            if (e.KeyCode == Keys.D2)
            {
                m4a1sform formacm4 = new m4a1sform();
                formacm4.ShowDialog();
            }
            if (e.KeyCode == Keys.D3)
            {
                Ak_47Form formacak47 = new Ak_47Form();
                formacak47.ShowDialog();
            }
            if (e.KeyCode == Keys.D4)
            {
                AwpForm formacAwp = new AwpForm();
                formacAwp.ShowDialog();
            }

        }

        private void cksBtn_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();

            }
            
        }
    }
}

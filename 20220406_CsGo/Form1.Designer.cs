
namespace _20220406_CsGo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bicakBtn = new System.Windows.Forms.Button();
            this.m4a1sBtn = new System.Windows.Forms.Button();
            this.ak47Btn = new System.Windows.Forms.Button();
            this.AwpBtn = new System.Windows.Forms.Button();
            this.BigiBtn = new System.Windows.Forms.Button();
            this.cksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bicakBtn
            // 
            this.bicakBtn.BackColor = System.Drawing.Color.Transparent;
            this.bicakBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bicakBtn.BackgroundImage")));
            this.bicakBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bicakBtn.Location = new System.Drawing.Point(66, 109);
            this.bicakBtn.Name = "bicakBtn";
            this.bicakBtn.Size = new System.Drawing.Size(82, 34);
            this.bicakBtn.TabIndex = 0;
            this.bicakBtn.Text = "Bıçak ";
            this.bicakBtn.UseVisualStyleBackColor = false;
            this.bicakBtn.Click += new System.EventHandler(this.bicak_Click);
            this.bicakBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // m4a1sBtn
            // 
            this.m4a1sBtn.BackColor = System.Drawing.Color.Transparent;
            this.m4a1sBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m4a1sBtn.BackgroundImage")));
            this.m4a1sBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m4a1sBtn.Location = new System.Drawing.Point(66, 168);
            this.m4a1sBtn.Name = "m4a1sBtn";
            this.m4a1sBtn.Size = new System.Drawing.Size(82, 34);
            this.m4a1sBtn.TabIndex = 1;
            this.m4a1sBtn.Text = "M4A1S";
            this.m4a1sBtn.UseVisualStyleBackColor = false;
            this.m4a1sBtn.Click += new System.EventHandler(this.m4a1s_Click);
            // 
            // ak47Btn
            // 
            this.ak47Btn.BackColor = System.Drawing.Color.Transparent;
            this.ak47Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ak47Btn.BackgroundImage")));
            this.ak47Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ak47Btn.Location = new System.Drawing.Point(66, 241);
            this.ak47Btn.Name = "ak47Btn";
            this.ak47Btn.Size = new System.Drawing.Size(82, 34);
            this.ak47Btn.TabIndex = 2;
            this.ak47Btn.Text = "AK-47";
            this.ak47Btn.UseVisualStyleBackColor = false;
            this.ak47Btn.Click += new System.EventHandler(this.ak47Btn_Click);
            // 
            // AwpBtn
            // 
            this.AwpBtn.BackColor = System.Drawing.Color.Transparent;
            this.AwpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AwpBtn.BackgroundImage")));
            this.AwpBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AwpBtn.Location = new System.Drawing.Point(66, 305);
            this.AwpBtn.Name = "AwpBtn";
            this.AwpBtn.Size = new System.Drawing.Size(82, 34);
            this.AwpBtn.TabIndex = 3;
            this.AwpBtn.Text = "AWP";
            this.AwpBtn.UseVisualStyleBackColor = false;
            this.AwpBtn.Click += new System.EventHandler(this.AwpBtn_Click);
            // 
            // BigiBtn
            // 
            this.BigiBtn.BackColor = System.Drawing.Color.Transparent;
            this.BigiBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BigiBtn.BackgroundImage")));
            this.BigiBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BigiBtn.Location = new System.Drawing.Point(66, 50);
            this.BigiBtn.Name = "BigiBtn";
            this.BigiBtn.Size = new System.Drawing.Size(82, 33);
            this.BigiBtn.TabIndex = 4;
            this.BigiBtn.Text = "Bilgi";
            this.BigiBtn.UseVisualStyleBackColor = false;
            this.BigiBtn.Click += new System.EventHandler(this.BigiBtn_Click);
            // 
            // cksBtn
            // 
            this.cksBtn.BackColor = System.Drawing.Color.Transparent;
            this.cksBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cksBtn.BackgroundImage")));
            this.cksBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cksBtn.Location = new System.Drawing.Point(66, 371);
            this.cksBtn.Name = "cksBtn";
            this.cksBtn.Size = new System.Drawing.Size(132, 45);
            this.cksBtn.TabIndex = 5;
            this.cksBtn.Text = "Çıkış Yap";
            this.cksBtn.UseVisualStyleBackColor = false;
            this.cksBtn.Click += new System.EventHandler(this.cksBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1177, 560);
            this.Controls.Add(this.cksBtn);
            this.Controls.Add(this.BigiBtn);
            this.Controls.Add(this.AwpBtn);
            this.Controls.Add(this.ak47Btn);
            this.Controls.Add(this.m4a1sBtn);
            this.Controls.Add(this.bicakBtn);
            this.Name = "Form1";
            this.Text = "CsGO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bicakBtn;
        private System.Windows.Forms.Button m4a1sBtn;
        private System.Windows.Forms.Button ak47Btn;
        private System.Windows.Forms.Button AwpBtn;
        private System.Windows.Forms.Button BigiBtn;
        private System.Windows.Forms.Button cksBtn;
    }
}


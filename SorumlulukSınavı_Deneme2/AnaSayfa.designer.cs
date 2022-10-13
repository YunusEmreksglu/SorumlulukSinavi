namespace SorumlulukSınavı_Deneme2
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btn_basla = new System.Windows.Forms.Button();
            this.btn_Donem = new System.Windows.Forms.Button();
            this.btn_Sinav = new System.Windows.Forms.Button();
            this.btn_SSG = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_MudurY = new System.Windows.Forms.Button();
            this.btn_Ogretmen = new System.Windows.Forms.Button();
            this.btn_Ders = new System.Windows.Forms.Button();
            this.btn_Brans = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_basla.Location = new System.Drawing.Point(50, 105);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(112, 23);
            this.btn_basla.TabIndex = 7;
            this.btn_basla.Text = "Öğretmen Atama";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // btn_Donem
            // 
            this.btn_Donem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_Donem.Location = new System.Drawing.Point(50, 47);
            this.btn_Donem.Name = "btn_Donem";
            this.btn_Donem.Size = new System.Drawing.Size(112, 23);
            this.btn_Donem.TabIndex = 8;
            this.btn_Donem.Tag = "Do";
            this.btn_Donem.Text = "Dönemler";
            this.btn_Donem.UseVisualStyleBackColor = false;
            this.btn_Donem.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // btn_Sinav
            // 
            this.btn_Sinav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_Sinav.Location = new System.Drawing.Point(50, 76);
            this.btn_Sinav.Name = "btn_Sinav";
            this.btn_Sinav.Size = new System.Drawing.Size(112, 23);
            this.btn_Sinav.TabIndex = 9;
            this.btn_Sinav.Text = "Sınav";
            this.btn_Sinav.UseVisualStyleBackColor = false;
            this.btn_Sinav.Click += new System.EventHandler(this.btn_Sinav_Click);
            // 
            // btn_SSG
            // 
            this.btn_SSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_SSG.Location = new System.Drawing.Point(52, 63);
            this.btn_SSG.Name = "btn_SSG";
            this.btn_SSG.Size = new System.Drawing.Size(110, 48);
            this.btn_SSG.TabIndex = 10;
            this.btn_SSG.Text = "Sorumluluk Sınavı PDF çıktı alma";
            this.btn_SSG.UseVisualStyleBackColor = false;
            this.btn_SSG.Click += new System.EventHandler(this.btn_SSG_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Location = new System.Drawing.Point(409, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DataBase Ekleme";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(507, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "✓";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.btn_SSG);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 170);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(50, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(112, 14);
            this.panel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıktı";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.btn_Donem);
            this.groupBox2.Controls.Add(this.btn_basla);
            this.groupBox2.Controls.Add(this.btn_Sinav);
            this.groupBox2.Location = new System.Drawing.Point(186, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 170);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(50, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 14);
            this.panel6.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlemler";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 170);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_MudurY
            // 
            this.btn_MudurY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_MudurY.Location = new System.Drawing.Point(50, 134);
            this.btn_MudurY.Name = "btn_MudurY";
            this.btn_MudurY.Size = new System.Drawing.Size(112, 23);
            this.btn_MudurY.TabIndex = 6;
            this.btn_MudurY.Tag = "MY";
            this.btn_MudurY.Text = "Müdür Yadrdımcısı";
            this.btn_MudurY.UseVisualStyleBackColor = false;
            this.btn_MudurY.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // btn_Ogretmen
            // 
            this.btn_Ogretmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_Ogretmen.Location = new System.Drawing.Point(50, 105);
            this.btn_Ogretmen.Name = "btn_Ogretmen";
            this.btn_Ogretmen.Size = new System.Drawing.Size(112, 23);
            this.btn_Ogretmen.TabIndex = 5;
            this.btn_Ogretmen.Tag = "O";
            this.btn_Ogretmen.Text = "Öğretmenler";
            this.btn_Ogretmen.UseVisualStyleBackColor = false;
            this.btn_Ogretmen.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // btn_Ders
            // 
            this.btn_Ders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_Ders.Location = new System.Drawing.Point(50, 76);
            this.btn_Ders.Name = "btn_Ders";
            this.btn_Ders.Size = new System.Drawing.Size(112, 23);
            this.btn_Ders.TabIndex = 4;
            this.btn_Ders.Tag = "D";
            this.btn_Ders.Text = "Dersler";
            this.btn_Ders.UseVisualStyleBackColor = false;
            this.btn_Ders.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // btn_Brans
            // 
            this.btn_Brans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.btn_Brans.Location = new System.Drawing.Point(50, 47);
            this.btn_Brans.Name = "btn_Brans";
            this.btn_Brans.Size = new System.Drawing.Size(112, 23);
            this.btn_Brans.TabIndex = 3;
            this.btn_Brans.Tag = "B";
            this.btn_Brans.Text = "Branşlar";
            this.btn_Brans.UseVisualStyleBackColor = false;
            this.btn_Brans.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.groupBox3.Controls.Add(this.btn_Brans);
            this.groupBox3.Controls.Add(this.btn_Ders);
            this.groupBox3.Controls.Add(this.btn_Ogretmen);
            this.groupBox3.Controls.Add(this.btn_MudurY);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 170);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 170);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(62, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 14);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okul Bilgileri";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(360, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(44, 170);
            this.panel5.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(12, 191);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(524, 20);
            this.panel7.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Müdür:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(548, 218);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaSayfa";
            this.Text = "                    Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnaSayfa_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btn_Donem;
        private System.Windows.Forms.Button btn_Sinav;
        private System.Windows.Forms.Button btn_SSG;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_MudurY;
        private System.Windows.Forms.Button btn_Ogretmen;
        private System.Windows.Forms.Button btn_Ders;
        private System.Windows.Forms.Button btn_Brans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


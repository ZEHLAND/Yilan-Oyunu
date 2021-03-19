            
namespace DonemProjesi
{
    partial class AnaEkran
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zaman = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zorButton = new System.Windows.Forms.RadioButton();
            this.kolayButton = new System.Windows.Forms.RadioButton();
            this.yardım = new System.Windows.Forms.Button();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.btnKisiKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.puanlama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "YILAN OYUNU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(460, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geçen Süre:";
            // 
            // zaman
            // 
            this.zaman.AutoSize = true;
            this.zaman.BackColor = System.Drawing.Color.Black;
            this.zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman.Location = new System.Drawing.Point(614, 9);
            this.zaman.Name = "zaman";
            this.zaman.Size = new System.Drawing.Size(71, 25);
            this.zaman.TabIndex = 4;
            this.zaman.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Location = new System.Drawing.Point(82, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(124, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(426, 345);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "KULLANINIZ !";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "OYUNU BAŞLATMAK İÇİN [B TUŞUNU]  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "OYUNU DURDURMAK İÇİN [D TUŞUNU]";
            // 
            // zorButton
            // 
            this.zorButton.AutoSize = true;
            this.zorButton.BackColor = System.Drawing.Color.Black;
            this.zorButton.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zorButton.ForeColor = System.Drawing.Color.Red;
            this.zorButton.Location = new System.Drawing.Point(354, 479);
            this.zorButton.Name = "zorButton";
            this.zorButton.Size = new System.Drawing.Size(141, 28);
            this.zorButton.TabIndex = 4;
            this.zorButton.TabStop = true;
            this.zorButton.Text = "ZOR SEVİYE";
            this.zorButton.UseVisualStyleBackColor = false;
            this.zorButton.CheckedChanged += new System.EventHandler(this.zorButton_CheckedChanged);
            // 
            // kolayButton
            // 
            this.kolayButton.AutoSize = true;
            this.kolayButton.BackColor = System.Drawing.Color.Black;
            this.kolayButton.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolayButton.ForeColor = System.Drawing.Color.Yellow;
            this.kolayButton.Location = new System.Drawing.Point(159, 479);
            this.kolayButton.Name = "kolayButton";
            this.kolayButton.Size = new System.Drawing.Size(169, 28);
            this.kolayButton.TabIndex = 3;
            this.kolayButton.TabStop = true;
            this.kolayButton.Text = "KOLAY SEVİYE";
            this.kolayButton.UseVisualStyleBackColor = false;
            this.kolayButton.CheckedChanged += new System.EventHandler(this.kolayButton_CheckedChanged);
            // 
            // yardım
            // 
            this.yardım.BackColor = System.Drawing.Color.Black;
            this.yardım.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yardım.ForeColor = System.Drawing.Color.Yellow;
            this.yardım.Location = new System.Drawing.Point(12, 555);
            this.yardım.Name = "yardım";
            this.yardım.Size = new System.Drawing.Size(97, 35);
            this.yardım.TabIndex = 8;
            this.yardım.Text = "YARDIM";
            this.yardım.UseVisualStyleBackColor = false;
            this.yardım.Click += new System.EventHandler(this.yardım_Click);
            // 
            // txtKisi
            // 
            this.txtKisi.BackColor = System.Drawing.Color.Black;
            this.txtKisi.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKisi.ForeColor = System.Drawing.Color.White;
            this.txtKisi.Location = new System.Drawing.Point(124, 552);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(228, 35);
            this.txtKisi.TabIndex = 9;
            // 
            // btnKisiKaydet
            // 
            this.btnKisiKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKisiKaydet.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKisiKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKisiKaydet.Location = new System.Drawing.Point(358, 555);
            this.btnKisiKaydet.Name = "btnKisiKaydet";
            this.btnKisiKaydet.Size = new System.Drawing.Size(172, 32);
            this.btnKisiKaydet.TabIndex = 10;
            this.btnKisiKaydet.Text = "Kişiyi Kaydet ";
            this.btnKisiKaydet.UseVisualStyleBackColor = false;
            this.btnKisiKaydet.Click += new System.EventHandler(this.btnKisiKaydet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(542, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Skorları Görüntüle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // puanlama
            // 
            this.puanlama.AutoSize = true;
            this.puanlama.BackColor = System.Drawing.Color.Black;
            this.puanlama.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanlama.Location = new System.Drawing.Point(93, 12);
            this.puanlama.Name = "puanlama";
            this.puanlama.Size = new System.Drawing.Size(34, 24);
            this.puanlama.TabIndex = 12;
            this.puanlama.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(328, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 14;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(695, 602);
            this.Controls.Add(this.kolayButton);
            this.Controls.Add(this.zorButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.puanlama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKisiKaydet);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.yardım);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zaman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.KeyPreview = true;
            this.Name = "AnaEkran";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label zaman;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton zorButton;
        private System.Windows.Forms.RadioButton kolayButton;
        private System.Windows.Forms.Button yardım;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.Button btnKisiKaydet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label puanlama;
        private System.Windows.Forms.Label label8;
    }
}


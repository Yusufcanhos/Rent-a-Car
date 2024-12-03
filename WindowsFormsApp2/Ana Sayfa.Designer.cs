namespace WindowsFormsApp2
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
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnSozlesme = new System.Windows.Forms.Button();
            this.btnSatıslar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.BackgroundImage")));
            this.btnMusteriEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriEkle.FlatAppearance.BorderSize = 2;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMusteriEkle.Location = new System.Drawing.Point(11, 103);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(145, 81);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMusteriListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriListele.BackgroundImage")));
            this.btnMusteriListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriListele.Location = new System.Drawing.Point(222, 103);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(147, 81);
            this.btnMusteriListele.TabIndex = 2;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAracEkle.BackgroundImage")));
            this.btnAracEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracEkle.Location = new System.Drawing.Point(19, 267);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(137, 77);
            this.btnAracEkle.TabIndex = 3;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAracListele
            // 
            this.btnAracListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAracListele.BackgroundImage")));
            this.btnAracListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAracListele.Location = new System.Drawing.Point(232, 264);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(137, 80);
            this.btnAracListele.TabIndex = 4;
            this.btnAracListele.Text = "Araç Listele";
            this.btnAracListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracListele.UseVisualStyleBackColor = true;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSozlesme.BackgroundImage")));
            this.btnSozlesme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSozlesme.Location = new System.Drawing.Point(19, 436);
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.Size = new System.Drawing.Size(137, 85);
            this.btnSozlesme.TabIndex = 5;
            this.btnSozlesme.Text = "Sözleşme";
            this.btnSozlesme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSozlesme.UseVisualStyleBackColor = true;
            this.btnSozlesme.Click += new System.EventHandler(this.btnSozlesme_Click);
            // 
            // btnSatıslar
            // 
            this.btnSatıslar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSatıslar.BackgroundImage")));
            this.btnSatıslar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSatıslar.Location = new System.Drawing.Point(232, 431);
            this.btnSatıslar.Name = "btnSatıslar";
            this.btnSatıslar.Size = new System.Drawing.Size(137, 90);
            this.btnSatıslar.TabIndex = 6;
            this.btnSatıslar.Text = "Satışlar";
            this.btnSatıslar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatıslar.UseVisualStyleBackColor = true;
            this.btnSatıslar.Click += new System.EventHandler(this.btnSatıslar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 570);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(958, 35);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Sizin için en iyi arabaları seçtik. Kiralayın ve keyfinize bakın!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "CarShift Rent A Car";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSatıslar);
            this.Controls.Add(this.btnSozlesme);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnMusteriEkle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnSozlesme;
        private System.Windows.Forms.Button btnSatıslar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


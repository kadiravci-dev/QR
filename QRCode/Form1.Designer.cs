namespace QRCode
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
            this.txtOlusturulacakKod = new System.Windows.Forms.TextBox();
            this.pckQR = new System.Windows.Forms.PictureBox();
            this.btnQR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnQRoku = new System.Windows.Forms.Button();
            this.txtOkunanKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pckQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOlusturulacakKod
            // 
            this.txtOlusturulacakKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlusturulacakKod.Location = new System.Drawing.Point(12, 32);
            this.txtOlusturulacakKod.Name = "txtOlusturulacakKod";
            this.txtOlusturulacakKod.Size = new System.Drawing.Size(301, 30);
            this.txtOlusturulacakKod.TabIndex = 11;
            // 
            // pckQR
            // 
            this.pckQR.Location = new System.Drawing.Point(334, 32);
            this.pckQR.Name = "pckQR";
            this.pckQR.Size = new System.Drawing.Size(249, 199);
            this.pckQR.TabIndex = 12;
            this.pckQR.TabStop = false;
            // 
            // btnQR
            // 
            this.btnQR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQR.FlatAppearance.BorderSize = 0;
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQR.ForeColor = System.Drawing.Color.White;
            this.btnQR.Location = new System.Drawing.Point(12, 128);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(148, 61);
            this.btnQR.TabIndex = 13;
            this.btnQR.Text = "QR Kod Oluştur";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Oluşturulacak Kod:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(166, 128);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(148, 61);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "QR Kodu Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnQRoku
            // 
            this.btnQRoku.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQRoku.FlatAppearance.BorderSize = 0;
            this.btnQRoku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQRoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQRoku.ForeColor = System.Drawing.Color.White;
            this.btnQRoku.Location = new System.Drawing.Point(12, 196);
            this.btnQRoku.Name = "btnQRoku";
            this.btnQRoku.Size = new System.Drawing.Size(148, 61);
            this.btnQRoku.TabIndex = 16;
            this.btnQRoku.Text = "QR Kodu Oku";
            this.btnQRoku.UseVisualStyleBackColor = true;
            this.btnQRoku.Click += new System.EventHandler(this.btnQRoku_Click);
            // 
            // txtOkunanKod
            // 
            this.txtOkunanKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOkunanKod.Location = new System.Drawing.Point(12, 90);
            this.txtOkunanKod.Name = "txtOkunanKod";
            this.txtOkunanKod.Size = new System.Drawing.Size(301, 30);
            this.txtOkunanKod.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Okunan Kodun Açıklaması:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(622, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOkunanKod);
            this.Controls.Add(this.btnQRoku);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.pckQR);
            this.Controls.Add(this.txtOlusturulacakKod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "QR KOD OLUŞTUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pckQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOlusturulacakKod;
        private System.Windows.Forms.PictureBox pckQR;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnQRoku;
        private System.Windows.Forms.TextBox txtOkunanKod;
        private System.Windows.Forms.Label label2;
    }
}


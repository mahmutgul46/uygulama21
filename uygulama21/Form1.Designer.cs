namespace uygulama21
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
            this.ListeVeriler = new System.Windows.Forms.ListBox();
            this.btnVeriBagla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListeVeriler
            // 
            this.ListeVeriler.FormattingEnabled = true;
            this.ListeVeriler.Location = new System.Drawing.Point(132, 12);
            this.ListeVeriler.Name = "ListeVeriler";
            this.ListeVeriler.Size = new System.Drawing.Size(120, 95);
            this.ListeVeriler.TabIndex = 0;
            // 
            // btnVeriBagla
            // 
            this.btnVeriBagla.Location = new System.Drawing.Point(10, 39);
            this.btnVeriBagla.Name = "btnVeriBagla";
            this.btnVeriBagla.Size = new System.Drawing.Size(75, 23);
            this.btnVeriBagla.TabIndex = 1;
            this.btnVeriBagla.Text = "Veri Bağla";
            this.btnVeriBagla.UseVisualStyleBackColor = true;
            this.btnVeriBagla.Click += new System.EventHandler(this.btnVeriBagla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 133);
            this.Controls.Add(this.btnVeriBagla);
            this.Controls.Add(this.ListeVeriler);
            this.Name = "Form1";
            this.Text = "Veri Bağla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListeVeriler;
        private System.Windows.Forms.Button btnVeriBagla;
    }
}


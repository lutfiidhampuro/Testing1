namespace Testing1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPersegiPanjang = new System.Windows.Forms.Button();
            this.btnSegitiga = new System.Windows.Forms.Button();
            this.btnPersegi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLingkaran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersegiPanjang
            // 
            this.btnPersegiPanjang.Location = new System.Drawing.Point(140, 101);
            this.btnPersegiPanjang.Name = "btnPersegiPanjang";
            this.btnPersegiPanjang.Size = new System.Drawing.Size(289, 97);
            this.btnPersegiPanjang.TabIndex = 0;
            this.btnPersegiPanjang.Text = "Luas Persegi Panjang";
            this.btnPersegiPanjang.UseVisualStyleBackColor = true;
            this.btnPersegiPanjang.Click += new System.EventHandler(this.btnPersegiPanjang_Click);
            // 
            // btnSegitiga
            // 
            this.btnSegitiga.Location = new System.Drawing.Point(140, 232);
            this.btnSegitiga.Name = "btnSegitiga";
            this.btnSegitiga.Size = new System.Drawing.Size(289, 88);
            this.btnSegitiga.TabIndex = 1;
            this.btnSegitiga.Text = "Luas Segitiga";
            this.btnSegitiga.UseVisualStyleBackColor = true;
            this.btnSegitiga.Click += new System.EventHandler(this.btnSegitiga_Click);
            // 
            // btnPersegi
            // 
            this.btnPersegi.Location = new System.Drawing.Point(140, 351);
            this.btnPersegi.Name = "btnPersegi";
            this.btnPersegi.Size = new System.Drawing.Size(289, 88);
            this.btnPersegi.TabIndex = 2;
            this.btnPersegi.Text = "Luas Persegi";
            this.btnPersegi.UseVisualStyleBackColor = true;
            this.btnPersegi.Click += new System.EventHandler(this.btnPersegi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Penghitung Luas Bangun Datar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLingkaran
            // 
            this.btnLingkaran.Location = new System.Drawing.Point(140, 471);
            this.btnLingkaran.Name = "btnLingkaran";
            this.btnLingkaran.Size = new System.Drawing.Size(289, 88);
            this.btnLingkaran.TabIndex = 4;
            this.btnLingkaran.Text = "Luas Lingkaran";
            this.btnLingkaran.UseVisualStyleBackColor = true;
            this.btnLingkaran.Click += new System.EventHandler(this.btnLingkaran_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(595, 592);
            this.Controls.Add(this.btnLingkaran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersegi);
            this.Controls.Add(this.btnSegitiga);
            this.Controls.Add(this.btnPersegiPanjang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersegiPanjang;
        private System.Windows.Forms.Button btnSegitiga;
        private System.Windows.Forms.Button btnPersegi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLingkaran;
    }
}


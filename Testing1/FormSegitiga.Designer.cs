namespace Testing1
{
    partial class FormSegitiga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSegitiga));
            this.btnBackSegitiga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackSegitiga
            // 
            this.btnBackSegitiga.Location = new System.Drawing.Point(349, 621);
            this.btnBackSegitiga.Name = "btnBackSegitiga";
            this.btnBackSegitiga.Size = new System.Drawing.Size(137, 29);
            this.btnBackSegitiga.TabIndex = 0;
            this.btnBackSegitiga.Text = "Back";
            this.btnBackSegitiga.UseVisualStyleBackColor = true;
            this.btnBackSegitiga.Click += new System.EventHandler(this.btnBackSegitiga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Luas Segitiga";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.tbHeight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnCount);
            this.panel1.Controls.Add(this.tbResult);
            this.panel1.Controls.Add(this.tbBase);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 275);
            this.panel1.TabIndex = 5;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(203, 79);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(137, 26);
            this.tbHeight.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tinggi";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(286, 216);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(68, 218);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(117, 33);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Hitung";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(203, 118);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(137, 26);
            this.tbResult.TabIndex = 3;
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(203, 40);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(137, 26);
            this.tbBase.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasil :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alas";
            // 
            // FormSegitiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(531, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackSegitiga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSegitiga";
            this.Text = "FormSegitiga";
            this.Load += new System.EventHandler(this.FormSegitiga_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackSegitiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
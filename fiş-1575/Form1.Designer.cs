namespace fiş_1575
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numCorba = new System.Windows.Forms.NumericUpDown();
            this.numSalata = new System.Windows.Forms.NumericUpDown();
            this.numAna = new System.Windows.Forms.NumericUpDown();
            this.numTatlı = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.txtBilgi2 = new System.Windows.Forms.TextBox();
            this.txtBilgi3 = new System.Windows.Forms.TextBox();
            this.txtBilgi4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTatlı)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 285);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numTatlı);
            this.tabPage2.Controls.Add(this.numAna);
            this.tabPage2.Controls.Add(this.numSalata);
            this.tabPage2.Controls.Add(this.numCorba);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sipariş";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çorba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tatlı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ana Yemek";
            // 
            // numCorba
            // 
            this.numCorba.Location = new System.Drawing.Point(89, 63);
            this.numCorba.Name = "numCorba";
            this.numCorba.Size = new System.Drawing.Size(120, 20);
            this.numCorba.TabIndex = 4;
            this.numCorba.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numSalata
            // 
            this.numSalata.Location = new System.Drawing.Point(89, 98);
            this.numSalata.Name = "numSalata";
            this.numSalata.Size = new System.Drawing.Size(120, 20);
            this.numSalata.TabIndex = 5;
            this.numSalata.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numAna
            // 
            this.numAna.Location = new System.Drawing.Point(89, 137);
            this.numAna.Name = "numAna";
            this.numAna.Size = new System.Drawing.Size(120, 20);
            this.numAna.TabIndex = 6;
            this.numAna.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numTatlı
            // 
            this.numTatlı.Location = new System.Drawing.Point(89, 178);
            this.numTatlı.Name = "numTatlı";
            this.numTatlı.Size = new System.Drawing.Size(120, 20);
            this.numTatlı.TabIndex = 7;
            this.numTatlı.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.txtTel);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(284, 259);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Müşteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBilgi4);
            this.tabPage3.Controls.Add(this.txtBilgi3);
            this.tabPage3.Controls.Add(this.txtBilgi2);
            this.tabPage3.Controls.Add(this.txtBilgi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(284, 259);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Hesap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(105, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(105, 80);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(157, 20);
            this.txtTel.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(105, 120);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(157, 89);
            this.txtAdres.TabIndex = 5;
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(13, 19);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(250, 20);
            this.txtBilgi.TabIndex = 0;
            // 
            // txtBilgi2
            // 
            this.txtBilgi2.Location = new System.Drawing.Point(13, 45);
            this.txtBilgi2.Name = "txtBilgi2";
            this.txtBilgi2.Size = new System.Drawing.Size(250, 20);
            this.txtBilgi2.TabIndex = 1;
            // 
            // txtBilgi3
            // 
            this.txtBilgi3.Location = new System.Drawing.Point(13, 71);
            this.txtBilgi3.Name = "txtBilgi3";
            this.txtBilgi3.Size = new System.Drawing.Size(250, 20);
            this.txtBilgi3.TabIndex = 2;
            // 
            // txtBilgi4
            // 
            this.txtBilgi4.Location = new System.Drawing.Point(13, 97);
            this.txtBilgi4.Name = "txtBilgi4";
            this.txtBilgi4.Size = new System.Drawing.Size(250, 20);
            this.txtBilgi4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTatlı)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numTatlı;
        private System.Windows.Forms.NumericUpDown numAna;
        private System.Windows.Forms.NumericUpDown numSalata;
        private System.Windows.Forms.NumericUpDown numCorba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.TextBox txtBilgi4;
        private System.Windows.Forms.TextBox txtBilgi3;
        private System.Windows.Forms.TextBox txtBilgi2;
    }
}


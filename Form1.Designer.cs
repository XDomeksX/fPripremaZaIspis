namespace fPripremaZaIspit
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
            this.CMBvrsta = new System.Windows.Forms.ComboBox();
            this.DTPdatum = new System.Windows.Forms.DateTimePicker();
            this.TRBsnaga = new System.Windows.Forms.TrackBar();
            this.BTNunesi = new System.Windows.Forms.Button();
            this.BTNispis = new System.Windows.Forms.Button();
            this.RTBispis = new System.Windows.Forms.RichTextBox();
            this.TXTnaziv = new System.Windows.Forms.TextBox();
            this.TXTmarka = new System.Windows.Forms.TextBox();
            this.LBLsnaga = new System.Windows.Forms.Label();
            this.LBLvrsta = new System.Windows.Forms.Label();
            this.LBLnaziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLdatum = new System.Windows.Forms.Label();
            this.LBLrispis = new System.Windows.Forms.Label();
            this.LBLsnagabroj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TRBsnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // CMBvrsta
            // 
            this.CMBvrsta.FormattingEnabled = true;
            this.CMBvrsta.Items.AddRange(new object[] {
            "Automobil",
            "Motor",
            "Plovilo",
            "Zrakoplov"});
            this.CMBvrsta.Location = new System.Drawing.Point(12, 79);
            this.CMBvrsta.Name = "CMBvrsta";
            this.CMBvrsta.Size = new System.Drawing.Size(212, 21);
            this.CMBvrsta.TabIndex = 0;
            // 
            // DTPdatum
            // 
            this.DTPdatum.Location = new System.Drawing.Point(12, 340);
            this.DTPdatum.Name = "DTPdatum";
            this.DTPdatum.Size = new System.Drawing.Size(200, 20);
            this.DTPdatum.TabIndex = 2;
            // 
            // TRBsnaga
            // 
            this.TRBsnaga.LargeChange = 20;
            this.TRBsnaga.Location = new System.Drawing.Point(242, 393);
            this.TRBsnaga.Maximum = 350;
            this.TRBsnaga.Minimum = 45;
            this.TRBsnaga.Name = "TRBsnaga";
            this.TRBsnaga.Size = new System.Drawing.Size(331, 45);
            this.TRBsnaga.SmallChange = 5;
            this.TRBsnaga.TabIndex = 4;
            this.TRBsnaga.Value = 45;
            this.TRBsnaga.Scroll += new System.EventHandler(this.TRBsnaga_Scroll);
            // 
            // BTNunesi
            // 
            this.BTNunesi.Location = new System.Drawing.Point(619, 108);
            this.BTNunesi.Name = "BTNunesi";
            this.BTNunesi.Size = new System.Drawing.Size(137, 68);
            this.BTNunesi.TabIndex = 5;
            this.BTNunesi.Text = "Unesi";
            this.BTNunesi.UseVisualStyleBackColor = true;
            this.BTNunesi.Click += new System.EventHandler(this.BTNunesi_Click);
            // 
            // BTNispis
            // 
            this.BTNispis.Location = new System.Drawing.Point(619, 257);
            this.BTNispis.Name = "BTNispis";
            this.BTNispis.Size = new System.Drawing.Size(137, 68);
            this.BTNispis.TabIndex = 6;
            this.BTNispis.Text = "Ispis";
            this.BTNispis.UseVisualStyleBackColor = true;
            this.BTNispis.Click += new System.EventHandler(this.BTNispis_Click);
            // 
            // RTBispis
            // 
            this.RTBispis.Location = new System.Drawing.Point(242, 79);
            this.RTBispis.Name = "RTBispis";
            this.RTBispis.Size = new System.Drawing.Size(331, 281);
            this.RTBispis.TabIndex = 7;
            this.RTBispis.Text = "";
            // 
            // TXTnaziv
            // 
            this.TXTnaziv.Location = new System.Drawing.Point(12, 194);
            this.TXTnaziv.Name = "TXTnaziv";
            this.TXTnaziv.Size = new System.Drawing.Size(212, 20);
            this.TXTnaziv.TabIndex = 8;
            // 
            // TXTmarka
            // 
            this.TXTmarka.Location = new System.Drawing.Point(12, 260);
            this.TXTmarka.Name = "TXTmarka";
            this.TXTmarka.Size = new System.Drawing.Size(212, 20);
            this.TXTmarka.TabIndex = 9;
            // 
            // LBLsnaga
            // 
            this.LBLsnaga.AutoSize = true;
            this.LBLsnaga.Location = new System.Drawing.Point(369, 377);
            this.LBLsnaga.Name = "LBLsnaga";
            this.LBLsnaga.Size = new System.Drawing.Size(76, 13);
            this.LBLsnaga.TabIndex = 10;
            this.LBLsnaga.Text = "Snaga motora:";
            // 
            // LBLvrsta
            // 
            this.LBLvrsta.AutoSize = true;
            this.LBLvrsta.Location = new System.Drawing.Point(12, 63);
            this.LBLvrsta.Name = "LBLvrsta";
            this.LBLvrsta.Size = new System.Drawing.Size(64, 13);
            this.LBLvrsta.TabIndex = 11;
            this.LBLvrsta.Text = "Vrsta vozila:";
            // 
            // LBLnaziv
            // 
            this.LBLnaziv.AutoSize = true;
            this.LBLnaziv.Location = new System.Drawing.Point(12, 178);
            this.LBLnaziv.Name = "LBLnaziv";
            this.LBLnaziv.Size = new System.Drawing.Size(67, 13);
            this.LBLnaziv.TabIndex = 12;
            this.LBLnaziv.Text = "Naziv vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Marka vozila:";
            // 
            // LBLdatum
            // 
            this.LBLdatum.AutoSize = true;
            this.LBLdatum.Location = new System.Drawing.Point(12, 324);
            this.LBLdatum.Name = "LBLdatum";
            this.LBLdatum.Size = new System.Drawing.Size(41, 13);
            this.LBLdatum.TabIndex = 14;
            this.LBLdatum.Text = "Datum:";
            // 
            // LBLrispis
            // 
            this.LBLrispis.AutoSize = true;
            this.LBLrispis.Location = new System.Drawing.Point(390, 63);
            this.LBLrispis.Name = "LBLrispis";
            this.LBLrispis.Size = new System.Drawing.Size(28, 13);
            this.LBLrispis.TabIndex = 15;
            this.LBLrispis.Text = "Ispis";
            // 
            // LBLsnagabroj
            // 
            this.LBLsnagabroj.AutoSize = true;
            this.LBLsnagabroj.Location = new System.Drawing.Point(393, 424);
            this.LBLsnagabroj.Name = "LBLsnagabroj";
            this.LBLsnagabroj.Size = new System.Drawing.Size(19, 13);
            this.LBLsnagabroj.TabIndex = 16;
            this.LBLsnagabroj.Text = "45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLsnagabroj);
            this.Controls.Add(this.LBLrispis);
            this.Controls.Add(this.LBLdatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLnaziv);
            this.Controls.Add(this.LBLvrsta);
            this.Controls.Add(this.LBLsnaga);
            this.Controls.Add(this.TXTmarka);
            this.Controls.Add(this.TXTnaziv);
            this.Controls.Add(this.RTBispis);
            this.Controls.Add(this.BTNispis);
            this.Controls.Add(this.BTNunesi);
            this.Controls.Add(this.TRBsnaga);
            this.Controls.Add(this.DTPdatum);
            this.Controls.Add(this.CMBvrsta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TRBsnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBvrsta;
        private System.Windows.Forms.DateTimePicker DTPdatum;
        private System.Windows.Forms.TrackBar TRBsnaga;
        private System.Windows.Forms.Button BTNunesi;
        private System.Windows.Forms.Button BTNispis;
        private System.Windows.Forms.RichTextBox RTBispis;
        private System.Windows.Forms.TextBox TXTnaziv;
        private System.Windows.Forms.TextBox TXTmarka;
        private System.Windows.Forms.Label LBLsnaga;
        private System.Windows.Forms.Label LBLvrsta;
        private System.Windows.Forms.Label LBLnaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLdatum;
        private System.Windows.Forms.Label LBLrispis;
        private System.Windows.Forms.Label LBLsnagabroj;
    }
}


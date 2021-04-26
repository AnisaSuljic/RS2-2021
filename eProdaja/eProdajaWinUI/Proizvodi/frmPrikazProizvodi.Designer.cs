
namespace eProdajaWinUI.Proizvodi
{
    partial class frmPrikazProizvodi
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
            this.cbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbJedMjere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picProizvod = new System.Windows.Forms.PictureBox();
            this.txtSlikaPutanja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSlikaSnimi = new System.Windows.Forms.Button();
            this.dgwProizvodi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.btnSnimiSlikuUBazu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProizvodi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVrstaProizvoda
            // 
            this.cbVrstaProizvoda.FormattingEnabled = true;
            this.cbVrstaProizvoda.Location = new System.Drawing.Point(148, 24);
            this.cbVrstaProizvoda.Name = "cbVrstaProizvoda";
            this.cbVrstaProizvoda.Size = new System.Drawing.Size(306, 24);
            this.cbVrstaProizvoda.TabIndex = 0;
            this.cbVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.cbVrstaProizvoda_SelectedIndexChangedAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrsta proizvoda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(148, 54);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(306, 22);
            this.txtSifra.TabIndex = 3;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(148, 82);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(306, 22);
            this.txtNaziv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(148, 110);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(84, 22);
            this.txtCijena.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cijena";
            // 
            // cbJedMjere
            // 
            this.cbJedMjere.FormattingEnabled = true;
            this.cbJedMjere.Location = new System.Drawing.Point(357, 108);
            this.cbJedMjere.Name = "cbJedMjere";
            this.cbJedMjere.Size = new System.Drawing.Size(97, 24);
            this.cbJedMjere.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jedinica mjere";
            // 
            // picProizvod
            // 
            this.picProizvod.Location = new System.Drawing.Point(476, 24);
            this.picProizvod.Name = "picProizvod";
            this.picProizvod.Size = new System.Drawing.Size(218, 108);
            this.picProizvod.TabIndex = 10;
            this.picProizvod.TabStop = false;
            // 
            // txtSlikaPutanja
            // 
            this.txtSlikaPutanja.Location = new System.Drawing.Point(148, 138);
            this.txtSlikaPutanja.Name = "txtSlikaPutanja";
            this.txtSlikaPutanja.Size = new System.Drawing.Size(259, 22);
            this.txtSlikaPutanja.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Slika";
            // 
            // btnSlikaSnimi
            // 
            this.btnSlikaSnimi.Location = new System.Drawing.Point(413, 137);
            this.btnSlikaSnimi.Name = "btnSlikaSnimi";
            this.btnSlikaSnimi.Size = new System.Drawing.Size(41, 23);
            this.btnSlikaSnimi.TabIndex = 13;
            this.btnSlikaSnimi.Text = "...";
            this.btnSlikaSnimi.UseVisualStyleBackColor = true;
            this.btnSlikaSnimi.Click += new System.EventHandler(this.btnSlikaSnimi_Click);
            // 
            // dgwProizvodi
            // 
            this.dgwProizvodi.AllowUserToAddRows = false;
            this.dgwProizvodi.AllowUserToDeleteRows = false;
            this.dgwProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProizvodi.Location = new System.Drawing.Point(3, 18);
            this.dgwProizvodi.Name = "dgwProizvodi";
            this.dgwProizvodi.ReadOnly = true;
            this.dgwProizvodi.RowHeadersWidth = 51;
            this.dgwProizvodi.RowTemplate.Height = 24;
            this.dgwProizvodi.Size = new System.Drawing.Size(706, 214);
            this.dgwProizvodi.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwProizvodi);
            this.groupBox1.Location = new System.Drawing.Point(-3, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 235);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi";
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "ofdSlikaProizvoda";
            // 
            // btnSnimiSlikuUBazu
            // 
            this.btnSnimiSlikuUBazu.Location = new System.Drawing.Point(571, 141);
            this.btnSnimiSlikuUBazu.Name = "btnSnimiSlikuUBazu";
            this.btnSnimiSlikuUBazu.Size = new System.Drawing.Size(123, 23);
            this.btnSnimiSlikuUBazu.TabIndex = 16;
            this.btnSnimiSlikuUBazu.Text = "Snimi sliku";
            this.btnSnimiSlikuUBazu.UseVisualStyleBackColor = true;
            // 
            // frmPrikazProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 410);
            this.Controls.Add(this.btnSnimiSlikuUBazu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSlikaSnimi);
            this.Controls.Add(this.txtSlikaPutanja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picProizvod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbJedMjere);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVrstaProizvoda);
            this.Name = "frmPrikazProizvodi";
            this.Text = "frmPrikazProizvodi";
            this.Load += new System.EventHandler(this.frmPrikazProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProizvodi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVrstaProizvoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbJedMjere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picProizvod;
        private System.Windows.Forms.TextBox txtSlikaPutanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSlikaSnimi;
        private System.Windows.Forms.DataGridView dgwProizvodi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Button btnSnimiSlikuUBazu;
    }
}

namespace eProdajaWinUI.Korisnici
{
    partial class frmDodajUrediKorisnici
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.txtLozinkaPotvrda = new System.Windows.Forms.TextBox();
            this.passpotvrdaLabel = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.KorImeLabel = new System.Windows.Forms.Label();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(159, 9);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(211, 22);
            this.txtIme.TabIndex = 1;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(159, 37);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(211, 22);
            this.txtPrezime.TabIndex = 3;
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(38, 40);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(59, 17);
            this.prezimeLabel.TabIndex = 2;
            this.prezimeLabel.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(38, 68);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // txtLozinkaPotvrda
            // 
            this.txtLozinkaPotvrda.Location = new System.Drawing.Point(159, 178);
            this.txtLozinkaPotvrda.Name = "txtLozinkaPotvrda";
            this.txtLozinkaPotvrda.Size = new System.Drawing.Size(211, 22);
            this.txtLozinkaPotvrda.TabIndex = 11;
            // 
            // passpotvrdaLabel
            // 
            this.passpotvrdaLabel.AutoSize = true;
            this.passpotvrdaLabel.Location = new System.Drawing.Point(38, 181);
            this.passpotvrdaLabel.Name = "passpotvrdaLabel";
            this.passpotvrdaLabel.Size = new System.Drawing.Size(105, 17);
            this.passpotvrdaLabel.TabIndex = 10;
            this.passpotvrdaLabel.Text = "Potvrda lozinke";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(159, 150);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(211, 22);
            this.txtLozinka.TabIndex = 9;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(38, 153);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(57, 17);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Lozinka";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(159, 122);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(211, 22);
            this.txtKorIme.TabIndex = 7;
            // 
            // KorImeLabel
            // 
            this.KorImeLabel.AutoSize = true;
            this.KorImeLabel.Location = new System.Drawing.Point(38, 125);
            this.KorImeLabel.Name = "KorImeLabel";
            this.KorImeLabel.Size = new System.Drawing.Size(99, 17);
            this.KorImeLabel.TabIndex = 6;
            this.KorImeLabel.Text = "Korisničko ime";
            // 
            // clbUloge
            // 
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(41, 243);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(149, 157);
            this.clbUloge.TabIndex = 12;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(272, 243);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(70, 21);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.Text = "Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(237, 444);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(132, 31);
            this.btnSnimi.TabIndex = 14;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // frmDodajUrediKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 515);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.clbUloge);
            this.Controls.Add(this.txtLozinkaPotvrda);
            this.Controls.Add(this.passpotvrdaLabel);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.KorImeLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajUrediKorisnici";
            this.Text = "frmDodajUrediKorisnici";
            this.Load += new System.EventHandler(this.frmDodajUrediKorisnici_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.TextBox txtLozinkaPotvrda;
        private System.Windows.Forms.Label passpotvrdaLabel;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label KorImeLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Button btnSnimi;
    }
}
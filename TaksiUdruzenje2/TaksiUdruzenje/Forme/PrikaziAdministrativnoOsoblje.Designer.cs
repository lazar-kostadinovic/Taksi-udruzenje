
namespace TaksiUdruzenje.Forme
{
    partial class PrikaziAdministrativnoOsoblje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.osoblje = new System.Windows.Forms.ListView();
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StrucnaSprema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVoznje = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.osoblje);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 274);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrativno osoblje";
            // 
            // osoblje
            // 
            this.osoblje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JMBG,
            this.Ime,
            this.Prezime,
            this.StrucnaSprema});
            this.osoblje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osoblje.FullRowSelect = true;
            this.osoblje.GridLines = true;
            this.osoblje.HideSelection = false;
            this.osoblje.Location = new System.Drawing.Point(3, 16);
            this.osoblje.Name = "osoblje";
            this.osoblje.Size = new System.Drawing.Size(411, 255);
            this.osoblje.TabIndex = 0;
            this.osoblje.UseCompatibleStateImageBehavior = false;
            this.osoblje.View = System.Windows.Forms.View.Details;
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            this.JMBG.Width = 113;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime.Width = 91;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prezime.Width = 112;
            // 
            // StrucnaSprema
            // 
            this.StrucnaSprema.Text = "Strucna Sprema";
            this.StrucnaSprema.Width = 91;
            // 
            // btnVoznje
            // 
            this.btnVoznje.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVoznje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoznje.Location = new System.Drawing.Point(452, 28);
            this.btnVoznje.Name = "btnVoznje";
            this.btnVoznje.Size = new System.Drawing.Size(150, 40);
            this.btnVoznje.TabIndex = 44;
            this.btnVoznje.Text = "Primljeni pozivi";
            this.btnVoznje.UseVisualStyleBackColor = false;
            this.btnVoznje.Click += new System.EventHandler(this.btnVoznje_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(452, 84);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(150, 54);
            this.btnDodaj.TabIndex = 45;
            this.btnDodaj.Text = "Dodaj aministrativno osoblje";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // PrikaziAdministrativnoOsoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 298);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnVoznje);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrikaziAdministrativnoOsoblje";
            this.Text = "PrikaziAdministrativnoOsoblje";
            this.Load += new System.EventHandler(this.PrikaziAdministrativnoOsoblje_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView osoblje;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader StrucnaSprema;
        private System.Windows.Forms.Button btnVoznje;
        private System.Windows.Forms.Button btnDodaj;
    }
}
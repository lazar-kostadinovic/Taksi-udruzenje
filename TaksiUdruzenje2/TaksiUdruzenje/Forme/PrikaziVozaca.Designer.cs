
namespace TaksiUdruzenje.Forme
{
    partial class PrikaziVozaca
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
            this.btnVoznje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vozaci = new System.Windows.Forms.ListView();
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrVozDoz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVozilo = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoznje
            // 
            this.btnVoznje.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVoznje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoznje.Location = new System.Drawing.Point(695, 242);
            this.btnVoznje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoznje.Name = "btnVoznje";
            this.btnVoznje.Size = new System.Drawing.Size(200, 49);
            this.btnVoznje.TabIndex = 46;
            this.btnVoznje.Text = "Obavljenje voznje";
            this.btnVoznje.UseVisualStyleBackColor = false;
            this.btnVoznje.Click += new System.EventHandler(this.btnVoznje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vozaci);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(671, 337);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozaci";
            // 
            // vozaci
            // 
            this.vozaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JMBG,
            this.Ime,
            this.Prezime,
            this.BrVozDoz,
            this.Kategorija});
            this.vozaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vozaci.FullRowSelect = true;
            this.vozaci.GridLines = true;
            this.vozaci.HideSelection = false;
            this.vozaci.Location = new System.Drawing.Point(4, 19);
            this.vozaci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vozaci.Name = "vozaci";
            this.vozaci.Size = new System.Drawing.Size(663, 314);
            this.vozaci.TabIndex = 0;
            this.vozaci.UseCompatibleStateImageBehavior = false;
            this.vozaci.View = System.Windows.Forms.View.Details;
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
            // BrVozDoz
            // 
            this.BrVozDoz.Text = "Broj Vozacke Dozvole";
            this.BrVozDoz.Width = 118;
            // 
            // Kategorija
            // 
            this.Kategorija.Text = "Kategorija";
            // 
            // btnVozilo
            // 
            this.btnVozilo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVozilo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozilo.Location = new System.Drawing.Point(695, 299);
            this.btnVozilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVozilo.Name = "btnVozilo";
            this.btnVozilo.Size = new System.Drawing.Size(200, 49);
            this.btnVozilo.TabIndex = 47;
            this.btnVozilo.Text = "Vozila vozaca";
            this.btnVozilo.UseVisualStyleBackColor = false;
            this.btnVozilo.Click += new System.EventHandler(this.btnVozilo_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(695, 34);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(200, 49);
            this.btnDodaj.TabIndex = 48;
            this.btnDodaj.Text = "Dodaj Vozaca";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // PrikaziVozaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 370);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnVozilo);
            this.Controls.Add(this.btnVoznje);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrikaziVozaca";
            this.Text = "Vozac";
            this.Load += new System.EventHandler(this.Vozac_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoznje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView vozaci;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader BrVozDoz;
        private System.Windows.Forms.ColumnHeader Kategorija;
        private System.Windows.Forms.Button btnVozilo;
        private System.Windows.Forms.Button btnDodaj;
    }
}
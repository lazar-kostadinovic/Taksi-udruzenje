namespace TaksiUdruzenje.Forme
{
    partial class PrikaziOsobu
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
            this.btnObrisiZaposlenog = new System.Windows.Forms.Button();
            this.btnIzmeniZaposlenog = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.osobe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdmOsoblje = new System.Windows.Forms.Button();
            this.btnVozaci = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisiZaposlenog
            // 
            this.btnObrisiZaposlenog.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiZaposlenog.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZaposlenog.Location = new System.Drawing.Point(689, 119);
            this.btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            this.btnObrisiZaposlenog.Size = new System.Drawing.Size(150, 40);
            this.btnObrisiZaposlenog.TabIndex = 40;
            this.btnObrisiZaposlenog.Text = "Obrisi osobu";
            this.btnObrisiZaposlenog.UseVisualStyleBackColor = false;
            this.btnObrisiZaposlenog.Click += new System.EventHandler(this.btnObrisiZaposlenog_Click);
            // 
            // btnIzmeniZaposlenog
            // 
            this.btnIzmeniZaposlenog.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIzmeniZaposlenog.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniZaposlenog.Location = new System.Drawing.Point(689, 73);
            this.btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            this.btnIzmeniZaposlenog.Size = new System.Drawing.Size(150, 40);
            this.btnIzmeniZaposlenog.TabIndex = 39;
            this.btnIzmeniZaposlenog.Text = "Izmeni osobu";
            this.btnIzmeniZaposlenog.UseVisualStyleBackColor = false;
            this.btnIzmeniZaposlenog.Click += new System.EventHandler(this.btnIzmeniOsobu_Click);
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodajZaposlenog.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(689, 27);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(150, 40);
            this.btnDodajZaposlenog.TabIndex = 38;
            this.btnDodajZaposlenog.Text = "Dodaj novu osobu";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajOsobu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.osobe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 283);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osobe";
            // 
            // osobe
            // 
            this.osobe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.osobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osobe.FullRowSelect = true;
            this.osobe.GridLines = true;
            this.osobe.HideSelection = false;
            this.osobe.Location = new System.Drawing.Point(3, 16);
            this.osobe.Name = "osobe";
            this.osobe.Size = new System.Drawing.Size(665, 264);
            this.osobe.TabIndex = 0;
            this.osobe.UseCompatibleStateImageBehavior = false;
            this.osobe.View = System.Windows.Forms.View.Details;
            this.osobe.SelectedIndexChanged += new System.EventHandler(this.osobe_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JMBG";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Srednje Slovo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj Telefona";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 151;
            // 
            // btnAdmOsoblje
            // 
            this.btnAdmOsoblje.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdmOsoblje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmOsoblje.Location = new System.Drawing.Point(689, 196);
            this.btnAdmOsoblje.Name = "btnAdmOsoblje";
            this.btnAdmOsoblje.Size = new System.Drawing.Size(150, 40);
            this.btnAdmOsoblje.TabIndex = 41;
            this.btnAdmOsoblje.Text = "Administrativno Osoblje";
            this.btnAdmOsoblje.UseVisualStyleBackColor = false;
            this.btnAdmOsoblje.Click += new System.EventHandler(this.btnAdmOsoblje_Click);
            // 
            // btnVozaci
            // 
            this.btnVozaci.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVozaci.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozaci.Location = new System.Drawing.Point(689, 242);
            this.btnVozaci.Name = "btnVozaci";
            this.btnVozaci.Size = new System.Drawing.Size(150, 40);
            this.btnVozaci.TabIndex = 42;
            this.btnVozaci.Text = "Vozaci";
            this.btnVozaci.UseVisualStyleBackColor = false;
            this.btnVozaci.Click += new System.EventHandler(this.btnVozaci_Click);
            // 
            // PrikaziOsobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 305);
            this.Controls.Add(this.btnVozaci);
            this.Controls.Add(this.btnAdmOsoblje);
            this.Controls.Add(this.btnObrisiZaposlenog);
            this.Controls.Add(this.btnIzmeniZaposlenog);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrikaziOsobu";
            this.Text = "PrikaziOsobu";
            this.Load += new System.EventHandler(this.PrikaziOsobu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnObrisiZaposlenog;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView osobe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAdmOsoblje;
        private System.Windows.Forms.Button btnVozaci;
    }
}
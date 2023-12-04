namespace TaksiUdruzenje.Forme
{
    partial class PrikaziVoznje
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBrojVoznji = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Voznje = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIzmeni.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIzmeni.Location = new System.Drawing.Point(772, 74);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(137, 51);
            this.btnIzmeni.TabIndex = 59;
            this.btnIzmeni.Text = "Izmeni voznju";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(769, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ukupan broj voznji:";
            // 
            // txbBrojVoznji
            // 
            this.txbBrojVoznji.Location = new System.Drawing.Point(772, 252);
            this.txbBrojVoznji.Name = "txbBrojVoznji";
            this.txbBrojVoznji.ReadOnly = true;
            this.txbBrojVoznji.Size = new System.Drawing.Size(121, 20);
            this.txbBrojVoznji.TabIndex = 57;
            this.txbBrojVoznji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Voznje);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 362);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sve voznje taksi sluzbe";
            // 
            // Voznje
            // 
            this.Voznje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader11});
            this.Voznje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Voznje.FullRowSelect = true;
            this.Voznje.GridLines = true;
            this.Voznje.HideSelection = false;
            this.Voznje.Location = new System.Drawing.Point(3, 16);
            this.Voznje.Name = "Voznje";
            this.Voznje.Size = new System.Drawing.Size(750, 343);
            this.Voznje.TabIndex = 1;
            this.Voznje.UseCompatibleStateImageBehavior = false;
            this.Voznje.View = System.Windows.Forms.View.Details;
            this.Voznje.SelectedIndexChanged += new System.EventHandler(this.Voznje_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vreme pocetka voznje";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vreme kraja voznje";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pocetna stanica";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Krajnja stanica";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vreme primanja poziva";
            this.columnHeader6.Width = 66;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "JMBG vozaca";
            this.columnHeader7.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID musterije";
            this.columnHeader9.Width = 70;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "JMBG administrativnog osoblja";
            this.columnHeader11.Width = 129;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisi.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnObrisi.Location = new System.Drawing.Point(772, 142);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 51);
            this.btnObrisi.TabIndex = 56;
            this.btnObrisi.Text = "Obrisi voznju";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDodaj.Location = new System.Drawing.Point(772, 15);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 53);
            this.btnDodaj.TabIndex = 60;
            this.btnDodaj.Text = "Dodaj voznju";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrikaziVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 377);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbBrojVoznji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrikaziVoznje";
            this.Text = "PrikaziVoznje";
            this.Load += new System.EventHandler(this.PrikaziVoznje_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBrojVoznji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView Voznje;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
    }
}
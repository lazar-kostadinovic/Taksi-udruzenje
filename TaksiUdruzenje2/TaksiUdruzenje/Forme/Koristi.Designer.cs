
namespace TaksiUdruzenje.Forme
{
    partial class Koristi
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
            this.kor = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDVozila = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumOd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 262);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koristi";
            // 
            // kor
            // 
            this.kor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.IDVozila,
            this.DatumOd,
            this.DatumDo});
            this.kor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kor.FullRowSelect = true;
            this.kor.GridLines = true;
            this.kor.HideSelection = false;
            this.kor.Location = new System.Drawing.Point(3, 16);
            this.kor.Name = "kor";
            this.kor.Size = new System.Drawing.Size(319, 243);
            this.kor.TabIndex = 0;
            this.kor.UseCompatibleStateImageBehavior = false;
            this.kor.View = System.Windows.Forms.View.Details;
            this.kor.SelectedIndexChanged += new System.EventHandler(this.kor_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // IDVozila
            // 
            this.IDVozila.Text = "ID Vozila";
            this.IDVozila.Width = 74;
            // 
            // DatumOd
            // 
            this.DatumOd.Text = "Datum od";
            this.DatumOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatumOd.Width = 92;
            // 
            // DatumDo
            // 
            this.DatumDo.Text = "Datum do";
            this.DatumDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatumDo.Width = 83;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisi.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(343, 120);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(150, 40);
            this.btnObrisi.TabIndex = 46;
            this.btnObrisi.Text = "Obrisi vozilo";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIzmeni.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(343, 74);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(150, 40);
            this.btnIzmeni.TabIndex = 45;
            this.btnIzmeni.Text = "Izmeni vozilo";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(343, 28);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(150, 40);
            this.btnDodaj.TabIndex = 44;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Koristi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 284);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Koristi";
            this.Text = "Koristi";
            this.Load += new System.EventHandler(this.Koristi_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView kor;
        private System.Windows.Forms.ColumnHeader IDVozila;
        private System.Windows.Forms.ColumnHeader DatumOd;
        private System.Windows.Forms.ColumnHeader DatumDo;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ColumnHeader ID;
    }
}
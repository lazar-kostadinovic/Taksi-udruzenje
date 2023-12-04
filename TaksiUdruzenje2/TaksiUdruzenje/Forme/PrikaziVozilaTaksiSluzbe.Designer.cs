namespace TaksiUdruzenje.Forme
{
    partial class PrikaziVozilaTaksiSluzbe
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
            this.vozila = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GodProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumIstekaReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegOznaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vozila);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 274);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozila";
            // 
            // vozila
            // 
            this.vozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Marka,
            this.Tip,
            this.GodProizvodnje,
            this.DatumIstekaReg,
            this.RegOznaka});
            this.vozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vozila.FullRowSelect = true;
            this.vozila.GridLines = true;
            this.vozila.HideSelection = false;
            this.vozila.Location = new System.Drawing.Point(3, 16);
            this.vozila.Name = "vozila";
            this.vozila.Size = new System.Drawing.Size(523, 255);
            this.vozila.TabIndex = 0;
            this.vozila.UseCompatibleStateImageBehavior = false;
            this.vozila.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 73;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Marka.Width = 64;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            this.Tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tip.Width = 72;
            // 
            // GodProizvodnje
            // 
            this.GodProizvodnje.Text = "Godina proizvodnje";
            this.GodProizvodnje.Width = 106;
            // 
            // DatumIstekaReg
            // 
            this.DatumIstekaReg.Text = "Datum isteka registracije";
            this.DatumIstekaReg.Width = 127;
            // 
            // RegOznaka
            // 
            this.RegOznaka.Text = "RegOznaka";
            this.RegOznaka.Width = 74;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(559, 28);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(150, 40);
            this.btnDodaj.TabIndex = 47;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIzmeni.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(559, 74);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(150, 40);
            this.btnIzmeni.TabIndex = 48;
            this.btnIzmeni.Text = "Izmeni vozilo";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // PrikaziVozilaTaksiSluzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 292);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrikaziVozilaTaksiSluzbe";
            this.Text = "PrikaziVozilaTaksiSluzbe";
            this.Load += new System.EventHandler(this.PrikaziVozilaTaksiSluzbe_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView vozila;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader GodProizvodnje;
        private System.Windows.Forms.ColumnHeader DatumIstekaReg;
        private System.Windows.Forms.ColumnHeader RegOznaka;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
    }
}
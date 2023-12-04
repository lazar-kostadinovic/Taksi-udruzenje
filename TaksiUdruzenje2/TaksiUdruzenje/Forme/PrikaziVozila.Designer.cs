namespace TaksiUdruzenje.Forme
{
    partial class PrikaziVozila
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
            this.btnSopVozila = new System.Windows.Forms.Button();
            this.btnVozilaTaksiSluzbe = new System.Windows.Forms.Button();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vozila = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSopVozila
            // 
            this.btnSopVozila.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSopVozila.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSopVozila.Location = new System.Drawing.Point(324, 274);
            this.btnSopVozila.Name = "btnSopVozila";
            this.btnSopVozila.Size = new System.Drawing.Size(150, 40);
            this.btnSopVozila.TabIndex = 48;
            this.btnSopVozila.Text = "Sopstvena vozila";
            this.btnSopVozila.UseVisualStyleBackColor = false;
            this.btnSopVozila.Click += new System.EventHandler(this.btnSopVozila_Click);
            // 
            // btnVozilaTaksiSluzbe
            // 
            this.btnVozilaTaksiSluzbe.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVozilaTaksiSluzbe.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozilaTaksiSluzbe.Location = new System.Drawing.Point(324, 228);
            this.btnVozilaTaksiSluzbe.Name = "btnVozilaTaksiSluzbe";
            this.btnVozilaTaksiSluzbe.Size = new System.Drawing.Size(150, 40);
            this.btnVozilaTaksiSluzbe.TabIndex = 47;
            this.btnVozilaTaksiSluzbe.Text = "Vozila taksi sluzbe";
            this.btnVozilaTaksiSluzbe.UseVisualStyleBackColor = false;
            this.btnVozilaTaksiSluzbe.Click += new System.EventHandler(this.btnVozilaTaksiSluzbe_Click);
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiVozilo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiVozilo.Location = new System.Drawing.Point(324, 77);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(150, 40);
            this.btnObrisiVozilo.TabIndex = 46;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = false;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozilo.Location = new System.Drawing.Point(324, 31);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(150, 40);
            this.btnDodajVozilo.TabIndex = 44;
            this.btnDodajVozilo.Text = "Dodaj novo vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vozila);
            this.groupBox1.Location = new System.Drawing.Point(2, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 318);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozila";
            // 
            // vozila
            // 
            this.vozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.vozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vozila.FullRowSelect = true;
            this.vozila.GridLines = true;
            this.vozila.HideSelection = false;
            this.vozila.Location = new System.Drawing.Point(3, 16);
            this.vozila.Name = "vozila";
            this.vozila.Size = new System.Drawing.Size(294, 299);
            this.vozila.TabIndex = 0;
            this.vozila.UseCompatibleStateImageBehavior = false;
            this.vozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marka";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 79;
            // 
            // PrikaziVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 339);
            this.Controls.Add(this.btnSopVozila);
            this.Controls.Add(this.btnVozilaTaksiSluzbe);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrikaziVozila";
            this.Text = "PrikaziVozila";
            this.Load += new System.EventHandler(this.PrikaziVozila_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSopVozila;
        private System.Windows.Forms.Button btnVozilaTaksiSluzbe;
        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView vozila;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
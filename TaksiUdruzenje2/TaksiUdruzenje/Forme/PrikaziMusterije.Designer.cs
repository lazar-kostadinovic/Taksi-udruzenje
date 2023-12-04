
namespace TaksiUdruzenje.Forme
{
    partial class PrikaziMusterije
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
            this.btnObrisiMusteriju = new System.Windows.Forms.Button();
            this.btnIzmeniMusteriju = new System.Windows.Forms.Button();
            this.btnDodajMusteriju = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.GroupBox();
            this.musterije = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoznje
            // 
            this.btnVoznje.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVoznje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoznje.Location = new System.Drawing.Point(577, 249);
            this.btnVoznje.Name = "btnVoznje";
            this.btnVoznje.Size = new System.Drawing.Size(150, 40);
            this.btnVoznje.TabIndex = 48;
            this.btnVoznje.Text = "Voznje";
            this.btnVoznje.UseVisualStyleBackColor = false;
            this.btnVoznje.Click += new System.EventHandler(this.btnVoznje_Click);
            // 
            // btnObrisiMusteriju
            // 
            this.btnObrisiMusteriju.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiMusteriju.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiMusteriju.Location = new System.Drawing.Point(577, 119);
            this.btnObrisiMusteriju.Name = "btnObrisiMusteriju";
            this.btnObrisiMusteriju.Size = new System.Drawing.Size(150, 40);
            this.btnObrisiMusteriju.TabIndex = 46;
            this.btnObrisiMusteriju.Text = "Obrisi musteriju";
            this.btnObrisiMusteriju.UseVisualStyleBackColor = false;
            this.btnObrisiMusteriju.Click += new System.EventHandler(this.btnObrisiMusteriju_Click);
            // 
            // btnIzmeniMusteriju
            // 
            this.btnIzmeniMusteriju.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIzmeniMusteriju.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniMusteriju.Location = new System.Drawing.Point(577, 73);
            this.btnIzmeniMusteriju.Name = "btnIzmeniMusteriju";
            this.btnIzmeniMusteriju.Size = new System.Drawing.Size(150, 40);
            this.btnIzmeniMusteriju.TabIndex = 45;
            this.btnIzmeniMusteriju.Text = "Izmeni musteriju";
            this.btnIzmeniMusteriju.UseVisualStyleBackColor = false;
            this.btnIzmeniMusteriju.Click += new System.EventHandler(this.btnIzmeniMusteriju_Click);
            // 
            // btnDodajMusteriju
            // 
            this.btnDodajMusteriju.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodajMusteriju.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajMusteriju.Location = new System.Drawing.Point(577, 28);
            this.btnDodajMusteriju.Name = "btnDodajMusteriju";
            this.btnDodajMusteriju.Size = new System.Drawing.Size(150, 40);
            this.btnDodajMusteriju.TabIndex = 44;
            this.btnDodajMusteriju.Text = "Dodaj novu musteriju";
            this.btnDodajMusteriju.UseVisualStyleBackColor = false;
            this.btnDodajMusteriju.Click += new System.EventHandler(this.btnDodajMusteriju_Click);
            // 
            // name
            // 
            this.name.Controls.Add(this.musterije);
            this.name.Location = new System.Drawing.Point(12, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(559, 280);
            this.name.TabIndex = 43;
            this.name.TabStop = false;
            this.name.Text = "Musterije";
            // 
            // musterije
            // 
            this.musterije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.musterije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musterije.FullRowSelect = true;
            this.musterije.GridLines = true;
            this.musterije.HideSelection = false;
            this.musterije.Location = new System.Drawing.Point(3, 16);
            this.musterije.Name = "musterije";
            this.musterije.Size = new System.Drawing.Size(553, 261);
            this.musterije.TabIndex = 0;
            this.musterije.UseCompatibleStateImageBehavior = false;
            this.musterije.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj Telefona 1";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Broj Telefona 2";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj Telefona 3";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 116;
            // 
            // PrikaziMusterije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 299);
            this.Controls.Add(this.btnVoznje);
            this.Controls.Add(this.btnObrisiMusteriju);
            this.Controls.Add(this.btnIzmeniMusteriju);
            this.Controls.Add(this.btnDodajMusteriju);
            this.Controls.Add(this.name);
            this.Name = "PrikaziMusterije";
            this.Text = "PrikaziMusterije";
            this.Load += new System.EventHandler(this.PrikaziMusterije_Load);
            this.name.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoznje;
        private System.Windows.Forms.Button btnObrisiMusteriju;
        private System.Windows.Forms.Button btnIzmeniMusteriju;
        private System.Windows.Forms.Button btnDodajMusteriju;
        private System.Windows.Forms.GroupBox name;
        private System.Windows.Forms.ListView musterije;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
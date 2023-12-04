
namespace TaksiUdruzenje.Forme
{
    partial class PocetnaStranica
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
            this.btnMusterije = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVozila = new System.Windows.Forms.Button();
            this.btnVoznje = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusterije
            // 
            this.btnMusterije.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMusterije.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusterije.Location = new System.Drawing.Point(67, 229);
            this.btnMusterije.Name = "btnMusterije";
            this.btnMusterije.Size = new System.Drawing.Size(227, 57);
            this.btnMusterije.TabIndex = 8;
            this.btnMusterije.Text = "Musterije";
            this.btnMusterije.UseVisualStyleBackColor = false;
            this.btnMusterije.Click += new System.EventHandler(this.btnMusterije_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "TAKSI UDRUZENJE";
            // 
            // buttonVozila
            // 
            this.buttonVozila.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonVozila.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVozila.Location = new System.Drawing.Point(67, 300);
            this.buttonVozila.Name = "buttonVozila";
            this.buttonVozila.Size = new System.Drawing.Size(227, 57);
            this.buttonVozila.TabIndex = 9;
            this.buttonVozila.Text = "Vozila";
            this.buttonVozila.UseVisualStyleBackColor = false;
            this.buttonVozila.Click += new System.EventHandler(this.buttonVozila_Click);
            // 
            // btnVoznje
            // 
            this.btnVoznje.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVoznje.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoznje.Location = new System.Drawing.Point(67, 157);
            this.btnVoznje.Name = "btnVoznje";
            this.btnVoznje.Size = new System.Drawing.Size(227, 57);
            this.btnVoznje.TabIndex = 10;
            this.btnVoznje.Text = "Voznje";
            this.btnVoznje.UseVisualStyleBackColor = false;
            this.btnVoznje.Click += new System.EventHandler(this.btnVoznje_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.BackColor = System.Drawing.Color.SandyBrown;
            this.btnZaposleni.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposleni.Location = new System.Drawing.Point(67, 85);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(227, 57);
            this.btnZaposleni.TabIndex = 11;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = false;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 369);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnVoznje);
            this.Controls.Add(this.buttonVozila);
            this.Controls.Add(this.btnMusterije);
            this.Controls.Add(this.label1);
            this.Name = "PocetnaStranica";
            this.Text = "v";
            this.Load += new System.EventHandler(this.PocetnaStranica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusterije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVozila;
        private System.Windows.Forms.Button btnVoznje;
        private System.Windows.Forms.Button btnZaposleni;
    }
}
namespace TaksiUdruzenje.Forme
{
    partial class IzmeniVoznju
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
            this.VremeKrajaVoznje = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbKrStanica = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbPocStanica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VremeKrajaVoznje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbKrStanica);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbPocStanica);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 209);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o voznji";
            // 
            // VremeKrajaVoznje
            // 
            this.VremeKrajaVoznje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VremeKrajaVoznje.Location = new System.Drawing.Point(138, 124);
            this.VremeKrajaVoznje.Name = "VremeKrajaVoznje";
            this.VremeKrajaVoznje.Size = new System.Drawing.Size(152, 24);
            this.VremeKrajaVoznje.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vreme kraja voznje";
            // 
            // txbKrStanica
            // 
            this.txbKrStanica.Location = new System.Drawing.Point(140, 82);
            this.txbKrStanica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbKrStanica.Name = "txbKrStanica";
            this.txbKrStanica.Size = new System.Drawing.Size(152, 24);
            this.txbKrStanica.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(166, 166);
            this.button1.MinimumSize = new System.Drawing.Size(128, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "IZMENI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbPocStanica
            // 
            this.txbPocStanica.Location = new System.Drawing.Point(140, 36);
            this.txbPocStanica.Name = "txbPocStanica";
            this.txbPocStanica.Size = new System.Drawing.Size(150, 24);
            this.txbPocStanica.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pocetna stanica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Krajnja stanica";
            // 
            // IzmeniVoznju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 242);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IzmeniVoznju";
            this.Text = "IzmeniVoznju";
            this.Load += new System.EventHandler(this.IzmeniVoznju_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbKrStanica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbPocStanica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker VremeKrajaVoznje;
    }
}
namespace TaksiUdruzenje.Forme
{
    partial class IzmeniOsobu
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
            this.texBrojTelefona = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.texBrojTelefona);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbAdresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o osobi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // texBrojTelefona
            // 
            this.texBrojTelefona.Location = new System.Drawing.Point(100, 82);
            this.texBrojTelefona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.texBrojTelefona.Name = "texBrojTelefona";
            this.texBrojTelefona.Size = new System.Drawing.Size(152, 24);
            this.texBrojTelefona.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(124, 124);
            this.button1.MinimumSize = new System.Drawing.Size(128, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "IZMENI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbAdresa
            // 
            this.txbAdresa.Location = new System.Drawing.Point(100, 36);
            this.txbAdresa.Name = "txbAdresa";
            this.txbAdresa.Size = new System.Drawing.Size(150, 24);
            this.txbAdresa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj Telefona";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IzmeniOsobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 197);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IzmeniOsobu";
            this.Text = "Izmeni Osobu";
            this.Load += new System.EventHandler(this.IzmeniOsobu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texBrojTelefona;
        private System.Windows.Forms.TextBox txbAdresa;
    }
}
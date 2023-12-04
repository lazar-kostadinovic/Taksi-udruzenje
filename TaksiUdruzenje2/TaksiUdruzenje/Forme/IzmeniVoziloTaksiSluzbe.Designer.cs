namespace TaksiUdruzenje.Forme
{
    partial class IzmeniVoziloTaksiSluzbe
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
            this.DatumIstekaReg = new System.Windows.Forms.DateTimePicker();
            this.txtRegOznaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatumIstekaReg);
            this.groupBox1.Controls.Add(this.txtRegOznaka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o vozilu";
            // 
            // DatumIstekaReg
            // 
            this.DatumIstekaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumIstekaReg.Location = new System.Drawing.Point(160, 37);
            this.DatumIstekaReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatumIstekaReg.Name = "DatumIstekaReg";
            this.DatumIstekaReg.Size = new System.Drawing.Size(151, 24);
            this.DatumIstekaReg.TabIndex = 9;
            // 
            // txtRegOznaka
            // 
            this.txtRegOznaka.Location = new System.Drawing.Point(160, 73);
            this.txtRegOznaka.Name = "txtRegOznaka";
            this.txtRegOznaka.Size = new System.Drawing.Size(150, 24);
            this.txtRegOznaka.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registarska oznaka:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(182, 117);
            this.button1.MinimumSize = new System.Drawing.Size(128, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "IZMENI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum isteka reg:";
            // 
            // IzmeniVoziloTaksiSluzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 187);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IzmeniVoziloTaksiSluzbe";
            this.Text = "izmeniVoziloTaksiSluzbe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegOznaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatumIstekaReg;
    }
}

namespace TaksiUdruzenje.Forme
{
    partial class DodajKoristi
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
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVozac = new System.Windows.Forms.TextBox();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datumDo);
            this.groupBox1.Controls.Add(this.datumOd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVozac);
            this.groupBox1.Controls.Add(this.txtVozilo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci koriscenju vozila";
            // 
            // datumDo
            // 
            this.datumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDo.Location = new System.Drawing.Point(124, 152);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(152, 22);
            this.datumDo.TabIndex = 16;
            this.datumDo.Value = new System.DateTime(2023, 5, 14, 0, 0, 0, 0);
            // 
            // datumOd
            // 
            this.datumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOd.Location = new System.Drawing.Point(124, 107);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(152, 22);
            this.datumOd.TabIndex = 15;
            this.datumOd.Value = new System.DateTime(2023, 5, 14, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Datum do";
            // 
            // txtVozac
            // 
            this.txtVozac.Location = new System.Drawing.Point(124, 43);
            this.txtVozac.Margin = new System.Windows.Forms.Padding(2);
            this.txtVozac.Name = "txtVozac";
            this.txtVozac.Size = new System.Drawing.Size(76, 22);
            this.txtVozac.TabIndex = 4;
            this.txtVozac.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(124, 77);
            this.txtVozilo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(76, 22);
            this.txtVozilo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(167, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "DODAJ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID vozila:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "JMBG vozaca:";
            // 
            // DodajKoristi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 269);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajKoristi";
            this.Text = "DodajKoristi";
            this.Load += new System.EventHandler(this.DodajKoristi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVozac;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
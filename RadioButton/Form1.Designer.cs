namespace RadioButton
{
    partial class Form1
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
            this.rdbAzalt = new System.Windows.Forms.RadioButton();
            this.rdbArttir = new System.Windows.Forms.RadioButton();
            this.lblSonucDegeri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIslemYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbAzalt
            // 
            this.rdbAzalt.AutoSize = true;
            this.rdbAzalt.Location = new System.Drawing.Point(32, 22);
            this.rdbAzalt.Name = "rdbAzalt";
            this.rdbAzalt.Size = new System.Drawing.Size(48, 17);
            this.rdbAzalt.TabIndex = 0;
            this.rdbAzalt.TabStop = true;
            this.rdbAzalt.Text = "Azalt";
            this.rdbAzalt.UseVisualStyleBackColor = true;
            // 
            // rdbArttir
            // 
            this.rdbArttir.AutoSize = true;
            this.rdbArttir.Location = new System.Drawing.Point(32, 45);
            this.rdbArttir.Name = "rdbArttir";
            this.rdbArttir.Size = new System.Drawing.Size(46, 17);
            this.rdbArttir.TabIndex = 1;
            this.rdbArttir.TabStop = true;
            this.rdbArttir.Text = "Arttır";
            this.rdbArttir.UseVisualStyleBackColor = true;
            // 
            // lblSonucDegeri
            // 
            this.lblSonucDegeri.AutoSize = true;
            this.lblSonucDegeri.Location = new System.Drawing.Point(70, 98);
            this.lblSonucDegeri.Name = "lblSonucDegeri";
            this.lblSonucDegeri.Size = new System.Drawing.Size(13, 13);
            this.lblSonucDegeri.TabIndex = 2;
            this.lblSonucDegeri.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sonuç : ";
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(119, 42);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(120, 20);
            this.nudMiktar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miktar";
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Location = new System.Drawing.Point(119, 78);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(120, 23);
            this.btnIslemYap.TabIndex = 6;
            this.btnIslemYap.Text = "İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = true;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(415, 269);
            this.Controls.Add(this.btnIslemYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSonucDegeri);
            this.Controls.Add(this.rdbArttir);
            this.Controls.Add(this.rdbAzalt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAzalt;
        private System.Windows.Forms.RadioButton rdbArttir;
        private System.Windows.Forms.Label lblSonucDegeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIslemYap;
    }
}


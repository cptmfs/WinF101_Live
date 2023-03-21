namespace TabControl
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
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDzTrh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgcT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDogumTarih = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMedeniHal = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tabPage1);
            this.tabcMain.Controls.Add(this.tabPage2);
            this.tabcMain.Controls.Add(this.tabPage3);
            this.tabcMain.Controls.Add(this.tabPage4);
            this.tabcMain.Location = new System.Drawing.Point(12, 12);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(471, 311);
            this.tabcMain.TabIndex = 0;
            this.tabcMain.SelectedIndexChanged += new System.EventHandler(this.tabcMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ana Bilgiler";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtpType);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtgcT);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtDzTrh);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtpNo);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pasaport Bilgileri";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(369, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtMedeniHal);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtFatherName);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtDogumTarih);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtSoyad);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtAd);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtTC);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(463, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nüfüs Bilgileri";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(463, 280);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Özlük Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtpNo
            // 
            this.txtpNo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtpNo.Location = new System.Drawing.Point(154, 29);
            this.txtpNo.Name = "txtpNo";
            this.txtpNo.Size = new System.Drawing.Size(184, 24);
            this.txtpNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasaport No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Düzenlenme Tarihi : ";
            // 
            // txtDzTrh
            // 
            this.txtDzTrh.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDzTrh.Location = new System.Drawing.Point(154, 59);
            this.txtDzTrh.Name = "txtDzTrh";
            this.txtDzTrh.Size = new System.Drawing.Size(184, 24);
            this.txtDzTrh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geçerlilik Tarihi : ";
            // 
            // txtgcT
            // 
            this.txtgcT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtgcT.Location = new System.Drawing.Point(154, 89);
            this.txtgcT.Name = "txtgcT";
            this.txtgcT.Size = new System.Drawing.Size(184, 24);
            this.txtgcT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pasaport Tipi : ";
            // 
            // txtpType
            // 
            this.txtpType.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtpType.Location = new System.Drawing.Point(154, 119);
            this.txtpType.Name = "txtpType";
            this.txtpType.Size = new System.Drawing.Size(184, 24);
            this.txtpType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Doğum tarihi : ";
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.BackColor = System.Drawing.Color.MistyRose;
            this.txtDogumTarih.Location = new System.Drawing.Point(123, 110);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(184, 24);
            this.txtDogumTarih.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Soyisim : ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.MistyRose;
            this.txtSoyad.Location = new System.Drawing.Point(123, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(184, 24);
            this.txtSoyad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "İsim  : ";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.MistyRose;
            this.txtAd.Location = new System.Drawing.Point(123, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(184, 24);
            this.txtAd.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "TC No : ";
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.MistyRose;
            this.txtTC.Location = new System.Drawing.Point(123, 20);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(184, 24);
            this.txtTC.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Baba Adı : ";
            // 
            // txtFatherName
            // 
            this.txtFatherName.BackColor = System.Drawing.Color.MistyRose;
            this.txtFatherName.Location = new System.Drawing.Point(123, 140);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(184, 24);
            this.txtFatherName.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Medeni Hal :";
            // 
            // txtMedeniHal
            // 
            this.txtMedeniHal.BackColor = System.Drawing.Color.MistyRose;
            this.txtMedeniHal.Location = new System.Drawing.Point(123, 170);
            this.txtMedeniHal.Name = "txtMedeniHal";
            this.txtMedeniHal.Size = new System.Drawing.Size(184, 24);
            this.txtMedeniHal.TabIndex = 18;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(19, 329);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 30);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgcT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDzTrh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMedeniHal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDogumTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button1;
    }
}


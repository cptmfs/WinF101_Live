namespace CheckedListBox
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
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb
            // 
            this.clb.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.clb.FormattingEnabled = true;
            this.clb.Items.AddRange(new object[] {
            "C#",
            "SQL",
            "MVC",
            "EntityFramework",
            "HTML",
            "CSS",
            "JS"});
            this.clb.Location = new System.Drawing.Point(12, 12);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(212, 251);
            this.clb.TabIndex = 0;
            this.clb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_ItemCheck);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Peru;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(171, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbx
            // 
            this.lbx.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lbx.FormattingEnabled = true;
            this.lbx.ItemHeight = 18;
            this.lbx.Location = new System.Drawing.Point(341, 10);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(212, 256);
            this.lbx.TabIndex = 2;
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.Peru;
            this.btnAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktar.Location = new System.Drawing.Point(236, 112);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(94, 32);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(565, 316);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.clb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Button btnAktar;
    }
}


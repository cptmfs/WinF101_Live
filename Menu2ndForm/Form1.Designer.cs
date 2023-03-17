namespace Menu2ndForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOsyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combobox01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mLTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(420, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOsyaToolStripMenuItem,
            this.itemAyarlar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOsyaToolStripMenuItem
            // 
            this.dOsyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dOsyaToolStripMenuItem.Name = "dOsyaToolStripMenuItem";
            this.dOsyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dOsyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combobox01ToolStripMenuItem,
            this.listBox01ToolStripMenuItem,
            this.listBox02ToolStripMenuItem,
            this.messageFormToolStripMenuItem,
            this.mLTextBoxToolStripMenuItem,
            this.radioButtonToolStripMenuItem,
            this.simpleCalculatorToolStripMenuItem});
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // combobox01ToolStripMenuItem
            // 
            this.combobox01ToolStripMenuItem.Name = "combobox01ToolStripMenuItem";
            this.combobox01ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.combobox01ToolStripMenuItem.Text = "Combobox01";
            this.combobox01ToolStripMenuItem.Click += new System.EventHandler(this.combobox01ToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // itemAyarlar
            // 
            this.itemAyarlar.Name = "itemAyarlar";
            this.itemAyarlar.Size = new System.Drawing.Size(56, 20);
            this.itemAyarlar.Text = "Ayarlar";
            // 
            // listBox01ToolStripMenuItem
            // 
            this.listBox01ToolStripMenuItem.Name = "listBox01ToolStripMenuItem";
            this.listBox01ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBox01ToolStripMenuItem.Text = "ListBox01";
            this.listBox01ToolStripMenuItem.Click += new System.EventHandler(this.listBox01ToolStripMenuItem_Click);
            // 
            // listBox02ToolStripMenuItem
            // 
            this.listBox02ToolStripMenuItem.Name = "listBox02ToolStripMenuItem";
            this.listBox02ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBox02ToolStripMenuItem.Text = "ListBox02";
            this.listBox02ToolStripMenuItem.Click += new System.EventHandler(this.listBox02ToolStripMenuItem_Click);
            // 
            // messageFormToolStripMenuItem
            // 
            this.messageFormToolStripMenuItem.Name = "messageFormToolStripMenuItem";
            this.messageFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageFormToolStripMenuItem.Text = "MessageForm";
            this.messageFormToolStripMenuItem.Click += new System.EventHandler(this.messageFormToolStripMenuItem_Click);
            // 
            // mLTextBoxToolStripMenuItem
            // 
            this.mLTextBoxToolStripMenuItem.Name = "mLTextBoxToolStripMenuItem";
            this.mLTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mLTextBoxToolStripMenuItem.Text = "MLTextBox";
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            // 
            // simpleCalculatorToolStripMenuItem
            // 
            this.simpleCalculatorToolStripMenuItem.Name = "simpleCalculatorToolStripMenuItem";
            this.simpleCalculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simpleCalculatorToolStripMenuItem.Text = "SimpleCalculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 328);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOsyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAyarlar;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combobox01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBox01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBox02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mLTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleCalculatorToolStripMenuItem;
    }
}


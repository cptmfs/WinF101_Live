namespace ADO01
{
    partial class AdoForm
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
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskPostalAdd = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtContactNameAdd = new System.Windows.Forms.TextBox();
            this.mskFaxAdd = new System.Windows.Forms.MaskedTextBox();
            this.mskPhoneAdd = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCountryAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRegionAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitleAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCityAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskPostalUpdate = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIDUpdate = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtContactNameUpdate = new System.Windows.Forms.TextBox();
            this.mskFaxUpdate = new System.Windows.Forms.MaskedTextBox();
            this.mskPhoneUpdate = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCountryUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegionUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelCN = new System.Windows.Forms.Label();
            this.txtTitleUpdate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCityUpdate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAddressUpdate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCompanyNameUpdate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.AllowUserToResizeRows = false;
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(12, 39);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.Size = new System.Drawing.Size(686, 318);
            this.dgwCustomer.TabIndex = 0;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers Data";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(868, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskPostalAdd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtIDAdd);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtContactNameAdd);
            this.groupBox1.Controls.Add(this.mskFaxAdd);
            this.groupBox1.Controls.Add(this.mskPhoneAdd);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCountryAdd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRegionAdd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTitleAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCityAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddressAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCompanyNameAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Add";
            // 
            // mskPostalAdd
            // 
            this.mskPostalAdd.Location = new System.Drawing.Point(250, 120);
            this.mskPostalAdd.Mask = "00000";
            this.mskPostalAdd.Name = "mskPostalAdd";
            this.mskPostalAdd.Size = new System.Drawing.Size(84, 20);
            this.mskPostalAdd.TabIndex = 11;
            this.mskPostalAdd.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Postal Code :";
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Location = new System.Drawing.Point(94, 18);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(84, 20);
            this.txtIDAdd.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Customer ID :";
            // 
            // txtContactNameAdd
            // 
            this.txtContactNameAdd.Location = new System.Drawing.Point(94, 73);
            this.txtContactNameAdd.Name = "txtContactNameAdd";
            this.txtContactNameAdd.Size = new System.Drawing.Size(84, 20);
            this.txtContactNameAdd.TabIndex = 3;
            // 
            // mskFaxAdd
            // 
            this.mskFaxAdd.Location = new System.Drawing.Point(94, 150);
            this.mskFaxAdd.Mask = "(999) 000-0000";
            this.mskFaxAdd.Name = "mskFaxAdd";
            this.mskFaxAdd.Size = new System.Drawing.Size(84, 20);
            this.mskFaxAdd.TabIndex = 6;
            // 
            // mskPhoneAdd
            // 
            this.mskPhoneAdd.Location = new System.Drawing.Point(94, 124);
            this.mskPhoneAdd.Mask = "(999) 000-0000";
            this.mskPhoneAdd.Name = "mskPhoneAdd";
            this.mskPhoneAdd.Size = new System.Drawing.Size(84, 20);
            this.mskPhoneAdd.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(61, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Fax :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Phone :";
            // 
            // txtCountryAdd
            // 
            this.txtCountryAdd.Location = new System.Drawing.Point(250, 95);
            this.txtCountryAdd.Name = "txtCountryAdd";
            this.txtCountryAdd.Size = new System.Drawing.Size(84, 20);
            this.txtCountryAdd.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Country :";
            // 
            // txtRegionAdd
            // 
            this.txtRegionAdd.Location = new System.Drawing.Point(251, 69);
            this.txtRegionAdd.Name = "txtRegionAdd";
            this.txtRegionAdd.Size = new System.Drawing.Size(84, 20);
            this.txtRegionAdd.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Region :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact Name :";
            // 
            // txtTitleAdd
            // 
            this.txtTitleAdd.Location = new System.Drawing.Point(94, 99);
            this.txtTitleAdd.Name = "txtTitleAdd";
            this.txtTitleAdd.Size = new System.Drawing.Size(84, 20);
            this.txtTitleAdd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ContactTitle :";
            // 
            // txtCityAdd
            // 
            this.txtCityAdd.Location = new System.Drawing.Point(250, 43);
            this.txtCityAdd.Name = "txtCityAdd";
            this.txtCityAdd.Size = new System.Drawing.Size(84, 20);
            this.txtCityAdd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "City :";
            // 
            // txtAddressAdd
            // 
            this.txtAddressAdd.Location = new System.Drawing.Point(250, 17);
            this.txtAddressAdd.Name = "txtAddressAdd";
            this.txtAddressAdd.Size = new System.Drawing.Size(84, 20);
            this.txtAddressAdd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address : ";
            // 
            // txtCompanyNameAdd
            // 
            this.txtCompanyNameAdd.Location = new System.Drawing.Point(94, 46);
            this.txtCompanyNameAdd.Name = "txtCompanyNameAdd";
            this.txtCompanyNameAdd.Size = new System.Drawing.Size(84, 20);
            this.txtCompanyNameAdd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskPostalUpdate);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtIDUpdate);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtContactNameUpdate);
            this.groupBox2.Controls.Add(this.mskFaxUpdate);
            this.groupBox2.Controls.Add(this.mskPhoneUpdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCountryUpdate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRegionUpdate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.labelCN);
            this.groupBox2.Controls.Add(this.txtTitleUpdate);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtCityUpdate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtAddressUpdate);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtCompanyNameUpdate);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(358, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 183);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Update";
            // 
            // mskPostalUpdate
            // 
            this.mskPostalUpdate.Location = new System.Drawing.Point(250, 121);
            this.mskPostalUpdate.Name = "mskPostalUpdate";
            this.mskPostalUpdate.Size = new System.Drawing.Size(84, 20);
            this.mskPostalUpdate.TabIndex = 11;
            this.mskPostalUpdate.ValidatingType = typeof(int);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(178, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Postal Code :";
            // 
            // txtIDUpdate
            // 
            this.txtIDUpdate.Location = new System.Drawing.Point(93, 17);
            this.txtIDUpdate.Name = "txtIDUpdate";
            this.txtIDUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtIDUpdate.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Customer ID :";
            // 
            // txtContactNameUpdate
            // 
            this.txtContactNameUpdate.Location = new System.Drawing.Point(93, 70);
            this.txtContactNameUpdate.Name = "txtContactNameUpdate";
            this.txtContactNameUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtContactNameUpdate.TabIndex = 24;
            // 
            // mskFaxUpdate
            // 
            this.mskFaxUpdate.Location = new System.Drawing.Point(93, 147);
            this.mskFaxUpdate.Name = "mskFaxUpdate";
            this.mskFaxUpdate.Size = new System.Drawing.Size(84, 20);
            this.mskFaxUpdate.TabIndex = 23;
            // 
            // mskPhoneUpdate
            // 
            this.mskPhoneUpdate.Location = new System.Drawing.Point(93, 121);
            this.mskPhoneUpdate.Name = "mskPhoneUpdate";
            this.mskPhoneUpdate.Size = new System.Drawing.Size(84, 20);
            this.mskPhoneUpdate.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fax :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phone :";
            // 
            // txtCountryUpdate
            // 
            this.txtCountryUpdate.Location = new System.Drawing.Point(250, 95);
            this.txtCountryUpdate.Name = "txtCountryUpdate";
            this.txtCountryUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtCountryUpdate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Country :";
            // 
            // txtRegionUpdate
            // 
            this.txtRegionUpdate.Location = new System.Drawing.Point(251, 69);
            this.txtRegionUpdate.Name = "txtRegionUpdate";
            this.txtRegionUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtRegionUpdate.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Region :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(232, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelCN
            // 
            this.labelCN.AutoSize = true;
            this.labelCN.Location = new System.Drawing.Point(9, 72);
            this.labelCN.Name = "labelCN";
            this.labelCN.Size = new System.Drawing.Size(81, 13);
            this.labelCN.TabIndex = 12;
            this.labelCN.Text = "Contact Name :";
            // 
            // txtTitleUpdate
            // 
            this.txtTitleUpdate.Location = new System.Drawing.Point(93, 96);
            this.txtTitleUpdate.Name = "txtTitleUpdate";
            this.txtTitleUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtTitleUpdate.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "ContactTitle :";
            // 
            // txtCityUpdate
            // 
            this.txtCityUpdate.Location = new System.Drawing.Point(250, 43);
            this.txtCityUpdate.Name = "txtCityUpdate";
            this.txtCityUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtCityUpdate.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(214, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "City :";
            // 
            // txtAddressUpdate
            // 
            this.txtAddressUpdate.Location = new System.Drawing.Point(250, 17);
            this.txtAddressUpdate.Name = "txtAddressUpdate";
            this.txtAddressUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtAddressUpdate.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(196, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Address : ";
            // 
            // txtCompanyNameUpdate
            // 
            this.txtCompanyNameUpdate.Location = new System.Drawing.Point(93, 43);
            this.txtCompanyNameUpdate.Name = "txtCompanyNameUpdate";
            this.txtCompanyNameUpdate.Size = new System.Drawing.Size(84, 20);
            this.txtCompanyNameUpdate.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Company Name :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(736, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Search Text :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(813, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbxCountry
            // 
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(813, 62);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(156, 21);
            this.cbxCountry.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(758, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Country :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(704, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 59);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(95, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.Location = new System.Drawing.Point(841, 89);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(108, 28);
            this.btnList.TabIndex = 44;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // AdoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(988, 549);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbxCountry);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCustomer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AdoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Customers Data";
            this.Load += new System.EventHandler(this.AdoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCityAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressAdd;
        private System.Windows.Forms.TextBox txtCountryAdd;
        private System.Windows.Forms.TextBox txtRegionAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContactNameUpdate;
        private System.Windows.Forms.MaskedTextBox mskFaxUpdate;
        private System.Windows.Forms.MaskedTextBox mskPhoneUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCountryUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRegionUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelCN;
        private System.Windows.Forms.TextBox txtTitleUpdate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCityUpdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAddressUpdate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCompanyNameUpdate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIDUpdate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIDAdd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtContactNameAdd;
        private System.Windows.Forms.MaskedTextBox mskFaxAdd;
        private System.Windows.Forms.MaskedTextBox mskPhoneAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitleAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskPostalAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskPostalUpdate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
    }
}


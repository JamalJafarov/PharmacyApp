namespace PharmacyApp
{
    partial class AddMedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicineForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicinename = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.nmCost = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nmSellprice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.ckIsreceipt = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtProducedate = new System.Windows.Forms.DateTimePicker();
            this.dtExpiredate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.ckCategories = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSellprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1813, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1747, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(491, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine Name";
            // 
            // txtMedicinename
            // 
            this.txtMedicinename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicinename.Location = new System.Drawing.Point(491, 77);
            this.txtMedicinename.Name = "txtMedicinename";
            this.txtMedicinename.Size = new System.Drawing.Size(340, 50);
            this.txtMedicinename.TabIndex = 2;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCost.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCost.Location = new System.Drawing.Point(491, 137);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(80, 41);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Cost";
            // 
            // nmCost
            // 
            this.nmCost.DecimalPlaces = 2;
            this.nmCost.Location = new System.Drawing.Point(491, 181);
            this.nmCost.Name = "nmCost";
            this.nmCost.Size = new System.Drawing.Size(340, 39);
            this.nmCost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(491, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sell Price";
            // 
            // nmSellprice
            // 
            this.nmSellprice.DecimalPlaces = 2;
            this.nmSellprice.Location = new System.Drawing.Point(491, 288);
            this.nmSellprice.Name = "nmSellprice";
            this.nmSellprice.Size = new System.Drawing.Size(340, 39);
            this.nmSellprice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(492, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(492, 403);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(339, 217);
            this.txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(877, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Firms";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(853, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 600);
            this.panel1.TabIndex = 4;
            // 
            // cmbFirms
            // 
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(877, 182);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(400, 40);
            this.cmbFirms.TabIndex = 5;
            // 
            // ckIsreceipt
            // 
            this.ckIsreceipt.AutoSize = true;
            this.ckIsreceipt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckIsreceipt.ForeColor = System.Drawing.Color.ForestGreen;
            this.ckIsreceipt.Location = new System.Drawing.Point(879, 77);
            this.ckIsreceipt.Name = "ckIsreceipt";
            this.ckIsreceipt.Size = new System.Drawing.Size(214, 41);
            this.ckIsreceipt.TabIndex = 6;
            this.ckIsreceipt.Text = "With Receipt";
            this.ckIsreceipt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(871, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Produce Date";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtProducedate
            // 
            this.dtProducedate.Location = new System.Drawing.Point(879, 288);
            this.dtProducedate.Name = "dtProducedate";
            this.dtProducedate.Size = new System.Drawing.Size(400, 39);
            this.dtProducedate.TabIndex = 7;
            // 
            // dtExpiredate
            // 
            this.dtExpiredate.Location = new System.Drawing.Point(879, 403);
            this.dtExpiredate.Name = "dtExpiredate";
            this.dtExpiredate.Size = new System.Drawing.Size(400, 39);
            this.dtExpiredate.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(871, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "Expire Date";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(871, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Count";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(879, 524);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(340, 39);
            this.nmCount.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.ForeColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(1303, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 600);
            this.panel2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(1331, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "Categories";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(1331, 77);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(400, 48);
            this.cmbCategories.TabIndex = 5;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            this.cmbCategories.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbCategories_KeyUp);
            // 
            // ckCategories
            // 
            this.ckCategories.FormattingEnabled = true;
            this.ckCategories.Items.AddRange(new object[] {
            "ckCategoryList"});
            this.ckCategories.Location = new System.Drawing.Point(1340, 156);
            this.ckCategories.Name = "ckCategories";
            this.ckCategories.Size = new System.Drawing.Size(390, 148);
            this.ckCategories.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1320, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 131);
            this.button1.TabIndex = 9;
            this.button1.Text = "  Add ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddMedicine_Click);
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.AllowUserToAddRows = false;
            this.dtgMedicine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dtgMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicine.BackgroundColor = System.Drawing.Color.White;
            this.dtgMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMedicine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgMedicine.EnableHeadersVisualStyles = false;
            this.dtgMedicine.Location = new System.Drawing.Point(-3, 647);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgMedicine.RowHeadersWidth = 82;
            this.dtgMedicine.RowTemplate.Height = 41;
            this.dtgMedicine.Size = new System.Drawing.Size(1883, 505);
            this.dtgMedicine.TabIndex = 10;
            this.dtgMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMedicine_CellClick);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.Location = new System.Drawing.Point(1516, 390);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(179, 131);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update ";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.Update_Medicine_click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(1701, 390);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(179, 131);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete ";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.Delete_Medicine_click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel3.Location = new System.Drawing.Point(470, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 600);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(18, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(451, 47);
            this.label9.TabIndex = 11;
            this.label9.Text = "Search by Medicine Name";
            // 
            // txtSearchGuna
            // 
            this.txtSearchGuna.BorderRadius = 18;
            this.txtSearchGuna.CustomizableEdges = customizableEdges1;
            this.txtSearchGuna.DefaultText = "";
            this.txtSearchGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGuna.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGuna.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchGuna.IconLeft")));
            this.txtSearchGuna.IconLeftOffset = new System.Drawing.Point(5, 1);
            this.txtSearchGuna.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtSearchGuna.Location = new System.Drawing.Point(18, 84);
            this.txtSearchGuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchGuna.Name = "txtSearchGuna";
            this.txtSearchGuna.PasswordChar = '\0';
            this.txtSearchGuna.PlaceholderText = "Search Here";
            this.txtSearchGuna.SelectedText = "";
            this.txtSearchGuna.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.txtSearchGuna.Size = new System.Drawing.Size(441, 72);
            this.txtSearchGuna.TabIndex = 13;
            this.txtSearchGuna.TextChanged += new System.EventHandler(this.SearchTextBox1_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(430, 399);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // AddMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 1152);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearchGuna);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgMedicine);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckCategories);
            this.Controls.Add(this.dtExpiredate);
            this.Controls.Add(this.dtProducedate);
            this.Controls.Add(this.ckIsreceipt);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.nmSellprice);
            this.Controls.Add(this.nmCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMedicinename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddMedicineForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSellprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtMedicinename;
        private Label lblCost;
        private NumericUpDown nmCost;
        private Label label2;
        private NumericUpDown nmSellprice;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private Panel panel1;
        private ComboBox cmbFirms;
        private CheckBox ckIsreceipt;
        private Label label5;
        private DateTimePicker dtProducedate;
        private DateTimePicker dtExpiredate;
        private Label label7;
        private Label label6;
        private NumericUpDown nmCount;
        private Panel panel2;
        private Label label8;
        private ComboBox cmbCategories;
        private CheckedListBox ckCategories;
        private Button button1;
        private DataGridView dtgMedicine;
        private Button btn_update;
        private Button btn_Delete;
        private Panel panel3;
        private Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchGuna;
        private PictureBox pictureBox3;
    }
}
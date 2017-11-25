namespace SCM_System.Manager_Tools
{
    partial class stock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.staffCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAddNew = new System.Windows.Forms.GroupBox();
            this.bunifuDropdownStatus = new Bunifu.Framework.UI.BunifuDropdown();
            this.datePickerArrival = new Bunifu.Framework.UI.BunifuDatepicker();
            this.textBoxSignOff = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBoxMax = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBoxMin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBoxPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBoxQuan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBoxName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBoxID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusDropDown);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 525);
            this.panel1.TabIndex = 10;
            // 
            // statusDropDown
            // 
            this.statusDropDown.BackColor = System.Drawing.Color.Transparent;
            this.statusDropDown.BorderRadius = 3;
            this.statusDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.statusDropDown.ForeColor = System.Drawing.Color.White;
            this.statusDropDown.Items = new string[] {
        "In Stock",
        "Out of Stock",
        "Re-Ordered",
        "Pending"};
            this.statusDropDown.Location = new System.Drawing.Point(19, 125);
            this.statusDropDown.Name = "statusDropDown";
            this.statusDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.statusDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.statusDropDown.selectedIndex = 0;
            this.statusDropDown.Size = new System.Drawing.Size(259, 35);
            this.statusDropDown.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtName.BorderThickness = 3;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(19, 74);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 44);
            this.txtName.TabIndex = 11;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtID
            // 
            this.txtID.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtID.BorderThickness = 3;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.isPassword = false;
            this.txtID.Location = new System.Drawing.Point(19, 22);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(259, 44);
            this.txtID.TabIndex = 10;
            this.txtID.Text = "Order ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // searchBtn
            // 
            this.searchBtn.ActiveBorderThickness = 1;
            this.searchBtn.ActiveCornerRadius = 20;
            this.searchBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.ActiveForecolor = System.Drawing.Color.White;
            this.searchBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.ButtonText = "Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.IdleBorderThickness = 1;
            this.searchBtn.IdleCornerRadius = 20;
            this.searchBtn.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.IdleForecolor = System.Drawing.Color.White;
            this.searchBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.Location = new System.Drawing.Point(19, 168);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(259, 45);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffCheck});
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(298, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(638, 423);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // staffCheck
            // 
            this.staffCheck.DataPropertyName = "staffCheck";
            this.staffCheck.HeaderText = "staffCheck";
            this.staffCheck.Name = "staffCheck";
            this.staffCheck.ReadOnly = true;
            // 
            // groupBoxAddNew
            // 
            this.groupBoxAddNew.BackColor = System.Drawing.Color.White;
            this.groupBoxAddNew.Controls.Add(this.bunifuDropdownStatus);
            this.groupBoxAddNew.Controls.Add(this.datePickerArrival);
            this.groupBoxAddNew.Controls.Add(this.textBoxSignOff);
            this.groupBoxAddNew.Controls.Add(this.textBoxMax);
            this.groupBoxAddNew.Controls.Add(this.textBoxMin);
            this.groupBoxAddNew.Controls.Add(this.textBoxPrice);
            this.groupBoxAddNew.Controls.Add(this.textBoxQuan);
            this.groupBoxAddNew.Controls.Add(this.textBoxName);
            this.groupBoxAddNew.Controls.Add(this.textBoxID);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel5);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel12);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel14);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel6);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel8);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel10);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel1);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel2);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel3);
            this.groupBoxAddNew.Controls.Add(this.bunifuCustomLabel4);
            this.groupBoxAddNew.Location = new System.Drawing.Point(460, 116);
            this.groupBoxAddNew.Name = "groupBoxAddNew";
            this.groupBoxAddNew.Size = new System.Drawing.Size(323, 378);
            this.groupBoxAddNew.TabIndex = 16;
            this.groupBoxAddNew.TabStop = false;
            this.groupBoxAddNew.Visible = false;
            // 
            // bunifuDropdownStatus
            // 
            this.bunifuDropdownStatus.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownStatus.BorderRadius = 3;
            this.bunifuDropdownStatus.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownStatus.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdownStatus.Items = new string[] {
        "In Stock",
        "Out of Stock",
        "Re-Ordered",
        "Pending"};
            this.bunifuDropdownStatus.Location = new System.Drawing.Point(123, 88);
            this.bunifuDropdownStatus.Name = "bunifuDropdownStatus";
            this.bunifuDropdownStatus.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdownStatus.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdownStatus.selectedIndex = 0;
            this.bunifuDropdownStatus.Size = new System.Drawing.Size(120, 27);
            this.bunifuDropdownStatus.TabIndex = 14;
            // 
            // datePickerArrival
            // 
            this.datePickerArrival.BackColor = System.Drawing.Color.SeaGreen;
            this.datePickerArrival.BorderRadius = 0;
            this.datePickerArrival.ForeColor = System.Drawing.Color.White;
            this.datePickerArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerArrival.FormatCustom = "";
            this.datePickerArrival.Location = new System.Drawing.Point(123, 228);
            this.datePickerArrival.Name = "datePickerArrival";
            this.datePickerArrival.Size = new System.Drawing.Size(188, 26);
            this.datePickerArrival.TabIndex = 14;
            this.datePickerArrival.Value = new System.DateTime(2017, 11, 25, 0, 0, 0, 0);
            // 
            // textBoxSignOff
            // 
            this.textBoxSignOff.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textBoxSignOff.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSignOff.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textBoxSignOff.BorderThickness = 3;
            this.textBoxSignOff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSignOff.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxSignOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSignOff.isPassword = false;
            this.textBoxSignOff.Location = new System.Drawing.Point(123, 339);
            this.textBoxSignOff.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSignOff.Name = "textBoxSignOff";
            this.textBoxSignOff.Size = new System.Drawing.Size(120, 25);
            this.textBoxSignOff.TabIndex = 43;
            this.textBoxSignOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textBoxMax.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMax.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textBoxMax.BorderThickness = 3;
            this.textBoxMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMax.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMax.isPassword = false;
            this.textBoxMax.Location = new System.Drawing.Point(123, 305);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(120, 25);
            this.textBoxMax.TabIndex = 42;
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxMin
            // 
            this.textBoxMin.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textBoxMin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMin.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textBoxMin.BorderThickness = 3;
            this.textBoxMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMin.isPassword = false;
            this.textBoxMin.Location = new System.Drawing.Point(123, 265);
            this.textBoxMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(120, 25);
            this.textBoxMin.TabIndex = 41;
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textBoxPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPrice.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textBoxPrice.BorderThickness = 3;
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPrice.isPassword = false;
            this.textBoxPrice.Location = new System.Drawing.Point(123, 193);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(120, 25);
            this.textBoxPrice.TabIndex = 39;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxQuan
            // 
            this.textBoxQuan.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textBoxQuan.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuan.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textBoxQuan.BorderThickness = 3;
            this.textBoxQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuan.isPassword = false;
            this.textBoxQuan.Location = new System.Drawing.Point(123, 156);
            this.textBoxQuan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuan.Name = "textBoxQuan";
            this.textBoxQuan.Size = new System.Drawing.Size(120, 25);
            this.textBoxQuan.TabIndex = 38;
            this.textBoxQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textBoxName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textBoxName.BorderThickness = 3;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.isPassword = false;
            this.textBoxName.Location = new System.Drawing.Point(123, 122);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 25);
            this.textBoxName.TabIndex = 37;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textBoxID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxID.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textBoxID.BorderThickness = 3;
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxID.isPassword = false;
            this.textBoxID.Location = new System.Drawing.Point(123, 56);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(120, 25);
            this.textBoxID.TabIndex = 14;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(22, 60);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(25, 16);
            this.bunifuCustomLabel5.TabIndex = 35;
            this.bunifuCustomLabel5.Text = "ID:";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(22, 308);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(76, 16);
            this.bunifuCustomLabel12.TabIndex = 25;
            this.bunifuCustomLabel12.Text = "Maximum:";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(22, 344);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(95, 16);
            this.bunifuCustomLabel14.TabIndex = 26;
            this.bunifuCustomLabel14.Text = "Staff Sign Off:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(22, 196);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(44, 16);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Price:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(22, 232);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(56, 16);
            this.bunifuCustomLabel8.TabIndex = 20;
            this.bunifuCustomLabel8.Text = "Arrival:";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(22, 270);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(72, 16);
            this.bunifuCustomLabel10.TabIndex = 21;
            this.bunifuCustomLabel10.Text = "Minimum:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(165, 25);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Add New Item:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 126);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(83, 16);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Item Name:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(22, 160);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 16);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Quantity:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 93);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(50, 16);
            this.bunifuCustomLabel4.TabIndex = 15;
            this.bunifuCustomLabel4.Text = "Status:";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(306, 49);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(143, 45);
            this.bunifuThinButton21.TabIndex = 14;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Delete";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(788, 49);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(143, 45);
            this.bunifuThinButton22.TabIndex = 17;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Visible = false;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click_1);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddNew);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stock";
            this.Size = new System.Drawing.Size(936, 525);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAddNew.ResumeLayout(false);
            this.groupBoxAddNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private Bunifu.Framework.UI.BunifuThinButton2 searchBtn;
        private Bunifu.Framework.UI.BunifuDropdown statusDropDown;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCheck;
        private System.Windows.Forms.GroupBox groupBoxAddNew;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxSignOff;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxMax;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxMin;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxPrice;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxQuan;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxName;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxID;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerArrival;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownStatus;
    }
}

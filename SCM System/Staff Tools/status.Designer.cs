namespace SCM_System.Staff_Tools
{
    partial class status
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(status));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblItem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblQuantity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.databaseDataSet = new SCM_System.databaseDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new SCM_System.databaseDataSetTableAdapters.StaffTableAdapter();
            this.fKStockStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new SCM_System.databaseDataSetTableAdapters.StockTableAdapter();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblMinimum = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblArrival = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMax = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblStaff = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStockStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuThinButton21.ButtonText = "Search";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(19, 127);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(259, 45);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 525);
            this.panel1.TabIndex = 9;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel12);
            this.groupBoxResult.Controls.Add(this.lblMax);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel14);
            this.groupBoxResult.Controls.Add(this.lblStaff);
            this.groupBoxResult.Controls.Add(this.lblMinimum);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel6);
            this.groupBoxResult.Controls.Add(this.lblPrice);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel8);
            this.groupBoxResult.Controls.Add(this.lblArrival);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel10);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel1);
            this.groupBoxResult.Controls.Add(this.lblStatus);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel2);
            this.groupBoxResult.Controls.Add(this.lblItem);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel3);
            this.groupBoxResult.Controls.Add(this.lblQuantity);
            this.groupBoxResult.Controls.Add(this.bunifuCustomLabel4);
            this.groupBoxResult.Location = new System.Drawing.Point(304, 17);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(259, 350);
            this.groupBoxResult.TabIndex = 11;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(77, 25);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(96, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 19);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "NULL";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 88);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(40, 16);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Item:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(97, 88);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 17);
            this.lblItem.TabIndex = 17;
            this.lblItem.Text = "NULL";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 122);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 16);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Quantity:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(97, 122);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(38, 17);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "NULL";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(23, 55);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(50, 16);
            this.bunifuCustomLabel4.TabIndex = 15;
            this.bunifuCustomLabel4.Text = "Status:";
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
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.databaseDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // fKStockStaffBindingSource
            // 
            this.fKStockStaffBindingSource.DataMember = "FK_Stock_Staff";
            this.fKStockStaffBindingSource.DataSource = this.staffBindingSource;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(298, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(638, 66);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.Location = new System.Drawing.Point(97, 232);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMinimum.Size = new System.Drawing.Size(38, 17);
            this.lblMinimum.TabIndex = 24;
            this.lblMinimum.Text = "NULL";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(23, 158);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(44, 16);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(97, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 17);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "NULL";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(23, 194);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(56, 16);
            this.bunifuCustomLabel8.TabIndex = 20;
            this.bunifuCustomLabel8.Text = "Arrival:";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(97, 194);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(38, 17);
            this.lblArrival.TabIndex = 22;
            this.lblArrival.Text = "NULL";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(23, 232);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(72, 16);
            this.bunifuCustomLabel10.TabIndex = 21;
            this.bunifuCustomLabel10.Text = "Minimum:";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(23, 270);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(76, 16);
            this.bunifuCustomLabel12.TabIndex = 25;
            this.bunifuCustomLabel12.Text = "Maximum:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(97, 270);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(38, 17);
            this.lblMax.TabIndex = 29;
            this.lblMax.Text = "NULL";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(23, 306);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(95, 16);
            this.bunifuCustomLabel14.TabIndex = 26;
            this.bunifuCustomLabel14.Text = "Staff Sign Off:";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(124, 306);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(38, 17);
            this.lblStaff.TabIndex = 28;
            this.lblStaff.Text = "NULL";
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "status";
            this.Size = new System.Drawing.Size(936, 525);
            this.panel1.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStockStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private databaseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel lblItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQuantity;
        private System.Windows.Forms.BindingSource fKStockStaffBindingSource;
        private databaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMax;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStaff;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMinimum;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArrival;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
    }
}

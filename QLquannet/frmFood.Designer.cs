namespace QLquannet
{
    partial class frmFood
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.cboZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.Label();
            this.lbCom = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cboCom);
            this.panel1.Controls.Add(this.cboZone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbStaff);
            this.panel1.Controls.Add(this.lbCom);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 85);
            this.panel1.TabIndex = 0;
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(952, 32);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(101, 21);
            this.cboCom.TabIndex = 9;
            this.cboCom.SelectedIndexChanged += new System.EventHandler(this.cboCom_SelectedIndexChanged);
            // 
            // cboZone
            // 
            this.cboZone.FormattingEnabled = true;
            this.cboZone.Location = new System.Drawing.Point(741, 32);
            this.cboZone.Name = "cboZone";
            this.cboZone.Size = new System.Drawing.Size(101, 21);
            this.cboZone.TabIndex = 8;
            this.cboZone.SelectedIndexChanged += new System.EventHandler(this.cboZone_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(860, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(636, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn Zone";
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.ForeColor = System.Drawing.Color.White;
            this.lbStaff.Location = new System.Drawing.Point(1053, 33);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(0, 20);
            this.lbStaff.TabIndex = 5;
            this.lbStaff.Visible = false;
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCom.ForeColor = System.Drawing.Color.White;
            this.lbCom.Location = new System.Drawing.Point(630, 36);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(0, 20);
            this.lbCom.TabIndex = 4;
            this.lbCom.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(343, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 60);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(225, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 60);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm món";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Menu đồ ăn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.lbTongtien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 585);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 75);
            this.panel2.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(633, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 52);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(730, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 52);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.Color.White;
            this.lbTongtien.Location = new System.Drawing.Point(947, 22);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(54, 25);
            this.lbTongtien.TabIndex = 1;
            this.lbTongtien.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(832, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền:";
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryPanel.AutoScroll = true;
            this.CategoryPanel.Location = new System.Drawing.Point(12, 101);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(93, 404);
            this.CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Location = new System.Drawing.Point(111, 138);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(516, 441);
            this.ProductPanel.TabIndex = 3;
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID,
            this.FoodName,
            this.Qty,
            this.Price,
            this.Amount});
            this.dgvFoodList.Location = new System.Drawing.Point(633, 101);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowHeadersVisible = false;
            this.dgvFoodList.RowHeadersWidth = 62;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(420, 478);
            this.dgvFoodList.TabIndex = 4;
            this.dgvFoodList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodList_CellValueChanged);
            this.dgvFoodList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFoodList_RowsAdded);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "STT";
            this.No.MinimumWidth = 40;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 30;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.HeaderText = "Tên món";
            this.FoodName.MinimumWidth = 80;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Qty.HeaderText = "Số lượng";
            this.Qty.MinimumWidth = 30;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 80;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.HeaderText = "Đơn giá";
            this.Price.MinimumWidth = 100;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.HeaderText = "Thành tiên";
            this.Amount.MinimumWidth = 100;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFood.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearchFood.Location = new System.Drawing.Point(111, 101);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(246, 26);
            this.txtSearchFood.TabIndex = 5;
            this.txtSearchFood.Text = "Tìm kiếm";
            this.txtSearchFood.Click += new System.EventHandler(this.txtSearchFood_Click);
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(12, 511);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(83, 21);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 660);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
       
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.ComboBox cboZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}
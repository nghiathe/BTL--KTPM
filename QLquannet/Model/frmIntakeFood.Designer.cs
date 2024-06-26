namespace QLquannet.Model
{
    partial class frmIntakeFood
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbFood = new System.Windows.Forms.Label();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 89);
            this.panel1.TabIndex = 28;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::QLquannet.Properties.Resources.close__1_;
            this.btnExit.Location = new System.Drawing.Point(810, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intake Food";
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(28, 371);
            this.dgvFood.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(788, 370);
            this.dgvFood.TabIndex = 31;
            this.dgvFood.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellValueChanged);
            this.dgvFood.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvFood_DataError);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lbTongTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 761);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 85);
            this.panel2.TabIndex = 32;
            // 
            // cboCat
            // 
            this.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(204, 107);
            this.cboCat.Margin = new System.Windows.Forms.Padding(4);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(135, 24);
            this.cboCat.TabIndex = 36;
            this.cboCat.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // cboFood
            // 
            this.cboFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(469, 107);
            this.cboFood.Margin = new System.Windows.Forms.Padding(4);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(133, 24);
            this.cboFood.TabIndex = 37;
            this.cboFood.SelectedIndexChanged += new System.EventHandler(this.cboFood_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.Black;
            this.lbCategory.Location = new System.Drawing.Point(46, 106);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(150, 25);
            this.lbCategory.TabIndex = 38;
            this.lbCategory.Text = "Chọn loại hàng:";
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = true;
            this.lbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.ForeColor = System.Drawing.Color.Black;
            this.lbFood.Location = new System.Drawing.Point(359, 106);
            this.lbFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(102, 25);
            this.lbFood.TabIndex = 39;
            this.lbFood.Text = "Tên hàng:";
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFood.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearchFood.Location = new System.Drawing.Point(51, 145);
            this.txtSearchFood.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(551, 30);
            this.txtSearchFood.TabIndex = 40;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReset.Location = new System.Drawing.Point(649, 106);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 69);
            this.btnReset.TabIndex = 73;
            this.btnReset.Text = "Làm mới bộ lọc";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHang.ForeColor = System.Drawing.Color.Black;
            this.lbMaHang.Location = new System.Drawing.Point(84, 279);
            this.lbMaHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(95, 25);
            this.lbMaHang.TabIndex = 75;
            this.lbMaHang.Text = "Mã hàng:";
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.ForeColor = System.Drawing.Color.Black;
            this.lbTenHang.Location = new System.Drawing.Point(79, 237);
            this.lbTenHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(102, 25);
            this.lbTenHang.TabIndex = 77;
            this.lbTenHang.Text = "Tên hàng:";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lbSoLuong.Location = new System.Drawing.Point(82, 318);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(96, 25);
            this.lbSoLuong.TabIndex = 79;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(204, 282);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(398, 22);
            this.txtMaHang.TabIndex = 80;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(204, 320);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(398, 22);
            this.txtSoLuong.TabIndex = 81;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(204, 240);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(398, 22);
            this.txtTenHang.TabIndex = 82;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnClear.Location = new System.Drawing.Point(649, 197);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 65);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Làm mới dữ liệu";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnConfirm.Location = new System.Drawing.Point(649, 282);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(167, 61);
            this.btnConfirm.TabIndex = 84;
            this.btnConfirm.Text = "Xác nhận nhập hàng";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(204, 197);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(398, 22);
            this.txtMaHoaDon.TabIndex = 86;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.Black;
            this.lblMaHoaDon.Location = new System.Drawing.Point(59, 194);
            this.lblMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(122, 25);
            this.lblMaHoaDon.TabIndex = 85;
            this.lblMaHoaDon.Text = "Mã hoá đơn:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.White;
            this.lbTongTien.Location = new System.Drawing.Point(665, 27);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(67, 31);
            this.lbTongTien.TabIndex = 3;
            this.lbTongTien.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền:";
            // 
            // frmIntakeFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 846);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.lbMaHang);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.lbFood);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.cboFood);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIntakeFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIntakeFood";
            this.Load += new System.EventHandler(this.frmIntakeFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbFood;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label2;
    }
}
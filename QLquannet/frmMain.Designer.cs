namespace QLquannet
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMovable = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenubar = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnIntake = new System.Windows.Forms.Button();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.bthLogout = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlMovable.SuspendLayout();
            this.pnlMenubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMovable
            // 
            this.pnlMovable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMovable.Controls.Add(this.pnlStatus);
            this.pnlMovable.Controls.Add(this.panel2);
            this.pnlMovable.Controls.Add(this.button5);
            this.pnlMovable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMovable.Location = new System.Drawing.Point(0, 0);
            this.pnlMovable.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMovable.Name = "pnlMovable";
            this.pnlMovable.Size = new System.Drawing.Size(1591, 37);
            this.pnlMovable.TabIndex = 0;
            this.pnlMovable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMovable_MouseDown);
            this.pnlMovable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMovable_MouseMove);
            this.pnlMovable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMovable_MouseUp);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Location = new System.Drawing.Point(80, 37);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1511, 57);
            this.pnlStatus.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(79, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1512, 62);
            this.panel2.TabIndex = 2;
            // 
            // pnlMenubar
            // 
            this.pnlMenubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenubar.Controls.Add(this.btnIntake);
            this.pnlMenubar.Controls.Add(this.btnMaintain);
            this.pnlMenubar.Controls.Add(this.bthLogout);
            this.pnlMenubar.Controls.Add(this.btnBill);
            this.pnlMenubar.Controls.Add(this.btnFood);
            this.pnlMenubar.Controls.Add(this.btnComputer);
            this.pnlMenubar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenubar.Location = new System.Drawing.Point(0, 37);
            this.pnlMenubar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenubar.Name = "pnlMenubar";
            this.pnlMenubar.Size = new System.Drawing.Size(171, 761);
            this.pnlMenubar.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMain.Location = new System.Drawing.Point(171, 37);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1420, 761);
            this.pnlMain.TabIndex = 4;
            // 
            // btnIntake
            // 
            this.btnIntake.FlatAppearance.BorderSize = 0;
            this.btnIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntake.ForeColor = System.Drawing.Color.White;
            this.btnIntake.Image = global::QLquannet.Properties.Resources.shopping_cart;
            this.btnIntake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntake.Location = new System.Drawing.Point(0, 557);
            this.btnIntake.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntake.Name = "btnIntake";
            this.btnIntake.Size = new System.Drawing.Size(171, 62);
            this.btnIntake.TabIndex = 5;
            this.btnIntake.Text = "Nhập hàng";
            this.btnIntake.UseVisualStyleBackColor = true;
            this.btnIntake.Click += new System.EventHandler(this.btnIntake_Click);
            // 
            // btnMaintain
            // 
            this.btnMaintain.FlatAppearance.BorderSize = 0;
            this.btnMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintain.ForeColor = System.Drawing.Color.White;
            this.btnMaintain.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintain.Image")));
            this.btnMaintain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintain.Location = new System.Drawing.Point(0, 457);
            this.btnMaintain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(171, 62);
            this.btnMaintain.TabIndex = 4;
            this.btnMaintain.Text = "Bảo trì";
            this.btnMaintain.UseVisualStyleBackColor = true;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // bthLogout
            // 
            this.bthLogout.FlatAppearance.BorderSize = 0;
            this.bthLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bthLogout.Image = ((System.Drawing.Image)(resources.GetObject("bthLogout.Image")));
            this.bthLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthLogout.Location = new System.Drawing.Point(0, 699);
            this.bthLogout.Margin = new System.Windows.Forms.Padding(4);
            this.bthLogout.Name = "bthLogout";
            this.bthLogout.Size = new System.Drawing.Size(171, 62);
            this.bthLogout.TabIndex = 3;
            this.bthLogout.Text = "Đăng xuất";
            this.bthLogout.UseVisualStyleBackColor = true;
            this.bthLogout.Click += new System.EventHandler(this.bthLogout_Click);
            // 
            // btnBill
            // 
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 346);
            this.btnBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(171, 62);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnFood
            // 
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.Image")));
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 235);
            this.btnFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(171, 62);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Thực đơn";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.FlatAppearance.BorderSize = 0;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.ForeColor = System.Drawing.Color.White;
            this.btnComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnComputer.Image")));
            this.btnComputer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputer.Location = new System.Drawing.Point(0, 124);
            this.btnComputer.Margin = new System.Windows.Forms.Padding(4);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(171, 62);
            this.btnComputer.TabIndex = 0;
            this.btnComputer.Text = "Đặt máy";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::QLquannet.Properties.Resources.close__1_;
            this.button5.Location = new System.Drawing.Point(1551, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 37);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1591, 798);
            this.Controls.Add(this.pnlMenubar);
            this.Controls.Add(this.pnlMovable);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnlMovable.ResumeLayout(false);
            this.pnlMenubar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMovable;
        private System.Windows.Forms.Panel pnlMenubar;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button bthLogout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnIntake;
    }
}
namespace QLquannet.FoodModel
{
    partial class AddFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmAddFood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtIntakePrice = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Food";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnConfirmAddFood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnConfirmAddFood
            // 
            this.btnConfirmAddFood.Location = new System.Drawing.Point(372, 3);
            this.btnConfirmAddFood.Name = "btnConfirmAddFood";
            this.btnConfirmAddFood.Size = new System.Drawing.Size(86, 44);
            this.btnConfirmAddFood.TabIndex = 0;
            this.btnConfirmAddFood.Text = "Xác nhận";
            this.btnConfirmAddFood.UseVisualStyleBackColor = true;
            this.btnConfirmAddFood.Click += new System.EventHandler(this.btnConfirmAddFood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trong kho:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ảnh:";
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(161, 262);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 24);
            this.cboCategory.TabIndex = 8;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại món:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(161, 120);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(121, 22);
            this.txtFoodName.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(161, 158);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // txtIntakePrice
            // 
            this.txtIntakePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntakePrice.Location = new System.Drawing.Point(161, 196);
            this.txtIntakePrice.Name = "txtIntakePrice";
            this.txtIntakePrice.Size = new System.Drawing.Size(121, 22);
            this.txtIntakePrice.TabIndex = 12;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(161, 227);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(121, 22);
            this.txtInventory.TabIndex = 13;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(161, 296);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(121, 24);
            this.btnAddImage.TabIndex = 14;
            this.btnAddImage.Text = "Chọn ảnh";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::QLquannet.Properties.Resources.close__1_;
            this.button5.Location = new System.Drawing.Point(437, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtIntakePrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFood";
            this.Text = "AddFood";
            this.Load += new System.EventHandler(this.AddFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmAddFood;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtIntakePrice;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button button5;
    }
}
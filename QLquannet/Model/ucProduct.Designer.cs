namespace QLquannet
{
    partial class ucProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbPname);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 216);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(124, 54);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(178, 128);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(4, 162);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(98, 29);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "30000 đ";
            // 
            // lbPname
            // 
            this.lbPname.AutoSize = true;
            this.lbPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPname.Location = new System.Drawing.Point(4, 26);
            this.lbPname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPname.Name = "lbPname";
            this.lbPname.Size = new System.Drawing.Size(136, 25);
            this.lbPname.TabIndex = 1;
            this.lbPname.Text = "Product Name";
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(333, 215);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPname;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

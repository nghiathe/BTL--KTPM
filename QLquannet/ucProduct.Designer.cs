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
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPname = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbPname);
            this.panel1.Controls.Add(this.txtImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 176);
            this.panel1.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(3, 117);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(77, 24);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "30000 đ";
            // 
            // lbPname
            // 
            this.lbPname.AutoSize = true;
            this.lbPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPname.Location = new System.Drawing.Point(3, 30);
            this.lbPname.Name = "lbPname";
            this.lbPname.Size = new System.Drawing.Size(110, 20);
            this.lbPname.TabIndex = 1;
            this.lbPname.Text = "Product Name";
            // 
            // txtImage
            // 
            this.txtImage.Image = global::QLquannet.Properties.Resources.images;
            this.txtImage.Location = new System.Drawing.Point(119, 30);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(118, 111);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 0;
            this.txtImage.TabStop = false;
            this.txtImage.Click += new System.EventHandler(this.txtImage_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(250, 175);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPname;
        private System.Windows.Forms.PictureBox txtImage;
        private System.Windows.Forms.Label lbPrice;
    }
}

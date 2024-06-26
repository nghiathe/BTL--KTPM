namespace QLquannet.Model
{
    partial class frmPrintRecipe
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
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.btnPrintRecipe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBilling
            // 
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(79, 129);
            this.dgvBilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersVisible = false;
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilling.Size = new System.Drawing.Size(699, 482);
            this.dgvBilling.TabIndex = 0;
            // 
            // btnPrintRecipe
            // 
            this.btnPrintRecipe.Location = new System.Drawing.Point(679, 644);
            this.btnPrintRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintRecipe.Name = "btnPrintRecipe";
            this.btnPrintRecipe.Size = new System.Drawing.Size(169, 49);
            this.btnPrintRecipe.TabIndex = 2;
            this.btnPrintRecipe.Text = "In hóa đơn";
            this.btnPrintRecipe.UseVisualStyleBackColor = true;
            this.btnPrintRecipe.Click += new System.EventHandler(this.btnPrintRecipe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 89);
            this.panel1.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::QLquannet.Properties.Resources.close__1_;
            this.button5.Location = new System.Drawing.Point(840, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 37);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "In hóa đơn";
            // 
            // frmPrintRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrintRecipe);
            this.Controls.Add(this.dgvBilling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrintRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.Button btnPrintRecipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}
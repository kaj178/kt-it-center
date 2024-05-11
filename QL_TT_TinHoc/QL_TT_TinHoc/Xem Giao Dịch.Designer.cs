namespace QL_TT_TinHoc
{
    partial class Xem_Giao_Dịch
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
            this.data_gd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_gd)).BeginInit();
            this.SuspendLayout();
            // 
            // data_gd
            // 
            this.data_gd.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gd.Location = new System.Drawing.Point(3, 3);
            this.data_gd.Name = "data_gd";
            this.data_gd.RowHeadersWidth = 51;
            this.data_gd.RowTemplate.Height = 24;
            this.data_gd.Size = new System.Drawing.Size(1321, 483);
            this.data_gd.TabIndex = 115;
            // 
            // Xem_Giao_Dịch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 491);
            this.Controls.Add(this.data_gd);
            this.Name = "Xem_Giao_Dịch";
            this.Text = "Xem_Giao_Dịch";
            this.Load += new System.EventHandler(this.Xem_Giao_Dịch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_gd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_gd;
    }
}
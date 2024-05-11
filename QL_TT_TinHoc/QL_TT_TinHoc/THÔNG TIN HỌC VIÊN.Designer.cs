namespace QL_TT_TinHoc
{
    partial class THÔNG_TIN_HỌC_VIÊN
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
            this.data_hv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_hv)).BeginInit();
            this.SuspendLayout();
            // 
            // data_hv
            // 
            this.data_hv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_hv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hv.Location = new System.Drawing.Point(-1, 2);
            this.data_hv.Name = "data_hv";
            this.data_hv.RowHeadersWidth = 51;
            this.data_hv.RowTemplate.Height = 24;
            this.data_hv.Size = new System.Drawing.Size(952, 429);
            this.data_hv.TabIndex = 113;
            // 
            // THÔNG_TIN_HỌC_VIÊN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 434);
            this.Controls.Add(this.data_hv);
            this.Name = "THÔNG_TIN_HỌC_VIÊN";
            this.Text = "THÔNG TIN HỌC VIÊN";
            this.Load += new System.EventHandler(this.THÔNG_TIN_HỌC_VIÊN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_hv;
    }
}
namespace QL_TT_TinHoc
{
    partial class Thông_Tin_Lớp_Học
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
            this.data_lophoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_lophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // data_lophoc
            // 
            this.data_lophoc.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_lophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_lophoc.Location = new System.Drawing.Point(1, 2);
            this.data_lophoc.Name = "data_lophoc";
            this.data_lophoc.RowHeadersWidth = 51;
            this.data_lophoc.RowTemplate.Height = 24;
            this.data_lophoc.Size = new System.Drawing.Size(1027, 489);
            this.data_lophoc.TabIndex = 114;
            // 
            // Thông_Tin_Lớp_Học
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 491);
            this.Controls.Add(this.data_lophoc);
            this.Name = "Thông_Tin_Lớp_Học";
            this.Text = "Thông_Tin_Lớp_Học";
            this.Load += new System.EventHandler(this.Thông_Tin_Lớp_Học_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_lophoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_lophoc;
    }
}
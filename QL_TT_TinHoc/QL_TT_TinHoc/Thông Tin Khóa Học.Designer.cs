namespace QL_TT_TinHoc
{
    partial class Thông_Tin_Khóa_Học
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
            this.data_kh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // data_kh
            // 
            this.data_kh.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_kh.Location = new System.Drawing.Point(0, 3);
            this.data_kh.Name = "data_kh";
            this.data_kh.RowHeadersWidth = 51;
            this.data_kh.RowTemplate.Height = 24;
            this.data_kh.Size = new System.Drawing.Size(609, 282);
            this.data_kh.TabIndex = 115;
            // 
            // Thông_Tin_Khóa_Học
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 290);
            this.Controls.Add(this.data_kh);
            this.Name = "Thông_Tin_Khóa_Học";
            this.Text = "Thông_Tin_Khóa_Học";
            this.Load += new System.EventHandler(this.Thông_Tin_Khóa_Học_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_kh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_kh;
    }
}
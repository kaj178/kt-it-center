namespace QL_TT_TinHoc
{
    partial class Thông_Tin_Giảng_Viên
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
            this.data_gv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // data_gv
            // 
            this.data_gv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv.Location = new System.Drawing.Point(3, 5);
            this.data_gv.Name = "data_gv";
            this.data_gv.RowHeadersWidth = 51;
            this.data_gv.RowTemplate.Height = 24;
            this.data_gv.Size = new System.Drawing.Size(871, 433);
            this.data_gv.TabIndex = 114;
            // 
            // Thông_Tin_Giảng_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 444);
            this.Controls.Add(this.data_gv);
            this.Name = "Thông_Tin_Giảng_Viên";
            this.Text = "Thông_Tin_Giảng_Viên";
            this.Load += new System.EventHandler(this.Thông_Tin_Giảng_Viên_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_gv;
    }
}
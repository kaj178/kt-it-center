namespace QL_TT_TinHoc
{
    partial class Tk
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
            this.dtkhoang = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.data_tk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_tk)).BeginInit();
            this.SuspendLayout();
            // 
            // dtkhoang
            // 
            this.dtkhoang.Location = new System.Drawing.Point(553, 57);
            this.dtkhoang.Name = "dtkhoang";
            this.dtkhoang.Size = new System.Drawing.Size(100, 22);
            this.dtkhoang.TabIndex = 11;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(294, 72);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 22);
            this.date2.TabIndex = 10;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(294, 28);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 22);
            this.date1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Doanh thu trong khoảng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // data_tk
            // 
            this.data_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tk.Location = new System.Drawing.Point(12, 113);
            this.data_tk.Name = "data_tk";
            this.data_tk.RowHeadersWidth = 51;
            this.data_tk.RowTemplate.Height = 24;
            this.data_tk.Size = new System.Drawing.Size(891, 324);
            this.data_tk.TabIndex = 12;
            // 
            // Tk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.data_tk);
            this.Controls.Add(this.dtkhoang);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.button2);
            this.Name = "Tk";
            this.Text = "Tk";
            this.Load += new System.EventHandler(this.Tk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_tk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dtkhoang;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView data_tk;
    }
}
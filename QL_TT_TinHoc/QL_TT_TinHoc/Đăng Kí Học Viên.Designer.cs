namespace QL_TT_TinHoc
{
    partial class Đăng_Kí_Học_Viên
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
            this.data_dkhv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_gioitinh = new System.Windows.Forms.ComboBox();
            this.date_ngaydk = new System.Windows.Forms.DateTimePicker();
            this.txt_mahv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenhv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_tenkh = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_dkhv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_dkhv
            // 
            this.data_dkhv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_dkhv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dkhv.Location = new System.Drawing.Point(2, 295);
            this.data_dkhv.Name = "data_dkhv";
            this.data_dkhv.RowHeadersWidth = 51;
            this.data_dkhv.RowTemplate.Height = 24;
            this.data_dkhv.Size = new System.Drawing.Size(1321, 483);
            this.data_dkhv.TabIndex = 114;
            this.data_dkhv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dkhv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbo_tenkh);
            this.panel1.Controls.Add(this.cbo_gioitinh);
            this.panel1.Controls.Add(this.date_ngaydk);
            this.panel1.Controls.Add(this.txt_mahv);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_tenhv);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tx);
            this.panel1.Controls.Add(this.txt_sdt);
            this.panel1.Controls.Add(this.txt_diachi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_tuoi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 231);
            this.panel1.TabIndex = 116;
            // 
            // cbo_gioitinh
            // 
            this.cbo_gioitinh.FormattingEnabled = true;
            this.cbo_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioitinh.Location = new System.Drawing.Point(619, 146);
            this.cbo_gioitinh.Name = "cbo_gioitinh";
            this.cbo_gioitinh.Size = new System.Drawing.Size(121, 24);
            this.cbo_gioitinh.TabIndex = 99;
            // 
            // date_ngaydk
            // 
            this.date_ngaydk.Location = new System.Drawing.Point(160, 185);
            this.date_ngaydk.Name = "date_ngaydk";
            this.date_ngaydk.Size = new System.Drawing.Size(200, 22);
            this.date_ngaydk.TabIndex = 98;
            // 
            // txt_mahv
            // 
            this.txt_mahv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mahv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mahv.Location = new System.Drawing.Point(160, 27);
            this.txt_mahv.Name = "txt_mahv";
            this.txt_mahv.Size = new System.Drawing.Size(156, 22);
            this.txt_mahv.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(490, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 97;
            this.label8.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(619, 104);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(156, 22);
            this.txt_email.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "Mã Học Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(490, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Giới Tính:";
            // 
            // txt_tenhv
            // 
            this.txt_tenhv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_tenhv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenhv.Location = new System.Drawing.Point(160, 82);
            this.txt_tenhv.Name = "txt_tenhv";
            this.txt_tenhv.Size = new System.Drawing.Size(156, 22);
            this.txt_tenhv.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(490, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 94;
            this.label7.Text = "SĐT:";
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tx.ForeColor = System.Drawing.Color.Black;
            this.tx.Location = new System.Drawing.Point(26, 85);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(52, 16);
            this.tx.TabIndex = 87;
            this.tx.Text = "Họ Tên";
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sdt.Location = new System.Drawing.Point(619, 65);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(156, 22);
            this.txt_sdt.TabIndex = 93;
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diachi.Location = new System.Drawing.Point(160, 135);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(156, 22);
            this.txt_diachi.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(490, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tuổi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "Ngày Đăng Kí:";
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_tuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tuoi.Location = new System.Drawing.Point(619, 24);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(156, 22);
            this.txt_tuoi.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 89;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(490, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 97;
            this.label9.Text = "Tên Khóa Học:";
            // 
            // cbo_tenkh
            // 
            this.cbo_tenkh.FormattingEnabled = true;
            this.cbo_tenkh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_tenkh.Location = new System.Drawing.Point(619, 190);
            this.cbo_tenkh.Name = "cbo_tenkh";
            this.cbo_tenkh.Size = new System.Drawing.Size(121, 24);
            this.cbo_tenkh.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(821, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 101;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Đăng_Kí_Học_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_dkhv);
            this.Name = "Đăng_Kí_Học_Viên";
            this.Text = "Đăng_Kí_Học_Viên";
            this.Load += new System.EventHandler(this.Đăng_Kí_Học_Viên_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dkhv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_dkhv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_gioitinh;
        private System.Windows.Forms.DateTimePicker date_ngaydk;
        private System.Windows.Forms.TextBox txt_mahv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenhv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_tenkh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}
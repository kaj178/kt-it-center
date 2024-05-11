namespace QL_TT_TinHoc
{
    partial class mainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainAdmin));
            this.qUẢNLÍToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qUẢNLÍToolStripMenuItem
            // 
            this.qUẢNLÍToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qUẢNLÍToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.qUẢNLÍToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qUẢNLÍToolStripMenuItem.Image")));
            this.qUẢNLÍToolStripMenuItem.Name = "qUẢNLÍToolStripMenuItem";
            this.qUẢNLÍToolStripMenuItem.Size = new System.Drawing.Size(208, 27);
            this.qUẢNLÍToolStripMenuItem.Text = "QUẢN LÍ NHÂN VIÊN";
            this.qUẢNLÍToolStripMenuItem.Click += new System.EventHandler(this.qUẢNLÍToolStripMenuItem_Click);
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.đĂNGXUẤTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đĂNGXUẤTToolStripMenuItem.Image")));
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.đĂNGXUẤTToolStripMenuItem.Text = "THỐNG KÊ";
            this.đĂNGXUẤTToolStripMenuItem.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUẢNLÍToolStripMenuItem,
            this.đĂNGXUẤTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1535, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "ĐĂNG XUẤT";
            // 
            // mainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 735);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainAdmin";
            this.Text = "mainAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem qUẢNLÍToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
namespace QLDA_Nhom5.FormDesign
{
    partial class FrmQuanlyttin
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
            this.TLPnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.MnThongtin = new System.Windows.Forms.MenuStrip();
            this.MnuSvth = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGvhd = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTailieu = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlView = new System.Windows.Forms.Panel();
            this.TLPnlTop.SuspendLayout();
            this.MnThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPnlTop
            // 
            this.TLPnlTop.ColumnCount = 4;
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLPnlTop.Controls.Add(this.MnThongtin, 2, 0);
            this.TLPnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPnlTop.Location = new System.Drawing.Point(0, 0);
            this.TLPnlTop.Name = "TLPnlTop";
            this.TLPnlTop.RowCount = 1;
            this.TLPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlTop.Size = new System.Drawing.Size(1055, 35);
            this.TLPnlTop.TabIndex = 0;
            // 
            // MnThongtin
            // 
            this.MnThongtin.Dock = System.Windows.Forms.DockStyle.None;
            this.MnThongtin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnThongtin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSvth,
            this.MnuGvhd,
            this.MnuDoan,
            this.MnuTailieu});
            this.MnThongtin.Location = new System.Drawing.Point(263, 0);
            this.MnThongtin.Name = "MnThongtin";
            this.MnThongtin.Size = new System.Drawing.Size(782, 35);
            this.MnThongtin.TabIndex = 0;
            this.MnThongtin.Text = "MenuThongtin";
            // 
            // MnuSvth
            // 
            this.MnuSvth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuSvth.Name = "MnuSvth";
            this.MnuSvth.Size = new System.Drawing.Size(209, 31);
            this.MnuSvth.Text = "Sinh viên thực hiện";
            this.MnuSvth.Click += new System.EventHandler(this.MnuSvth_Click);
            // 
            // MnuGvhd
            // 
            this.MnuGvhd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuGvhd.Name = "MnuGvhd";
            this.MnuGvhd.Size = new System.Drawing.Size(236, 31);
            this.MnuGvhd.Text = "Giảng viên hướng dẫn";
            this.MnuGvhd.Click += new System.EventHandler(this.MnuGvhd_Click);
            // 
            // MnuDoan
            // 
            this.MnuDoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuDoan.Name = "MnuDoan";
            this.MnuDoan.Size = new System.Drawing.Size(85, 31);
            this.MnuDoan.Text = "Đồ Án";
            this.MnuDoan.Click += new System.EventHandler(this.MnuDoan_Click);
            // 
            // MnuTailieu
            // 
            this.MnuTailieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuTailieu.Name = "MnuTailieu";
            this.MnuTailieu.Size = new System.Drawing.Size(94, 31);
            this.MnuTailieu.Text = "Tài liệu";
            this.MnuTailieu.Click += new System.EventHandler(this.MnuTailieu_Click);
            // 
            // PnlView
            // 
            this.PnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlView.Location = new System.Drawing.Point(0, 35);
            this.PnlView.Name = "PnlView";
            this.PnlView.Size = new System.Drawing.Size(1055, 657);
            this.PnlView.TabIndex = 2;
            // 
            // FrmQuanlyttin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 692);
            this.Controls.Add(this.PnlView);
            this.Controls.Add(this.TLPnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MnThongtin;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanlyttin";
            this.TLPnlTop.ResumeLayout(false);
            this.TLPnlTop.PerformLayout();
            this.MnThongtin.ResumeLayout(false);
            this.MnThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPnlTop;
        private System.Windows.Forms.MenuStrip MnThongtin;
        private System.Windows.Forms.ToolStripMenuItem MnuDoan;
        private System.Windows.Forms.ToolStripMenuItem MnuSvth;
        private System.Windows.Forms.ToolStripMenuItem MnuGvhd;
        private System.Windows.Forms.ToolStripMenuItem MnuTailieu;
        private System.Windows.Forms.Panel PnlView;
    }
}
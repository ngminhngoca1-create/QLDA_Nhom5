namespace QLDA_Nhom5.FormDesign
{
    partial class FrmNguoiquanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiquanly));
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.LblTop = new System.Windows.Forms.Label();
            this.TLPnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAccount = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnManage = new System.Windows.Forms.Button();
            this.BtnLogo = new System.Windows.Forms.Button();
            this.TLPnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.PnlNav = new System.Windows.Forms.Label();
            this.PnlFill = new System.Windows.Forms.Panel();
            this.PnlPage = new System.Windows.Forms.Panel();
            this.TLPnlMenu.SuspendLayout();
            this.TLPnlTop.SuspendLayout();
            this.PnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(1017, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(48, 48);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximize.Image")));
            this.BtnMaximize.Location = new System.Drawing.Point(969, 0);
            this.BtnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(48, 48);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.Location = new System.Drawing.Point(921, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(48, 48);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // LblTop
            // 
            this.LblTop.AutoSize = true;
            this.LblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTop.ForeColor = System.Drawing.Color.White;
            this.LblTop.Location = new System.Drawing.Point(0, 0);
            this.LblTop.Margin = new System.Windows.Forms.Padding(0);
            this.LblTop.Name = "LblTop";
            this.LblTop.Size = new System.Drawing.Size(400, 48);
            this.LblTop.TabIndex = 3;
            this.LblTop.Text = "HỆ THỐNG QUẢN LÝ ĐỒ ÁN";
            this.LblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TLPnlMenu
            // 
            this.TLPnlMenu.ColumnCount = 1;
            this.TLPnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlMenu.Controls.Add(this.BtnAccount, 0, 5);
            this.TLPnlMenu.Controls.Add(this.BtnReport, 0, 4);
            this.TLPnlMenu.Controls.Add(this.BtnManage, 0, 3);
            this.TLPnlMenu.Controls.Add(this.BtnLogo, 0, 0);
            this.TLPnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TLPnlMenu.Location = new System.Drawing.Point(0, 0);
            this.TLPnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.TLPnlMenu.Name = "TLPnlMenu";
            this.TLPnlMenu.RowCount = 7;
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlMenu.Size = new System.Drawing.Size(135, 750);
            this.TLPnlMenu.TabIndex = 8;
            // 
            // BtnAccount
            // 
            this.BtnAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAccount.FlatAppearance.BorderSize = 0;
            this.BtnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccount.ForeColor = System.Drawing.Color.White;
            this.BtnAccount.Image = ((System.Drawing.Image)(resources.GetObject("BtnAccount.Image")));
            this.BtnAccount.Location = new System.Drawing.Point(0, 430);
            this.BtnAccount.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Size = new System.Drawing.Size(135, 125);
            this.BtnAccount.TabIndex = 6;
            this.BtnAccount.Text = "Tài khoản";
            this.BtnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAccount.UseVisualStyleBackColor = true;
            this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.Location = new System.Drawing.Point(0, 305);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(0);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(135, 125);
            this.BtnReport.TabIndex = 5;
            this.BtnReport.Text = "Báo cáo";
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnManage
            // 
            this.BtnManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnManage.FlatAppearance.BorderSize = 0;
            this.BtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManage.ForeColor = System.Drawing.Color.White;
            this.BtnManage.Image = ((System.Drawing.Image)(resources.GetObject("BtnManage.Image")));
            this.BtnManage.Location = new System.Drawing.Point(0, 180);
            this.BtnManage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(135, 125);
            this.BtnManage.TabIndex = 4;
            this.BtnManage.Text = "Quản lý";
            this.BtnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnManage.UseVisualStyleBackColor = true;
            this.BtnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // BtnLogo
            // 
            this.BtnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLogo.FlatAppearance.BorderSize = 0;
            this.BtnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogo.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogo.Image")));
            this.BtnLogo.Location = new System.Drawing.Point(0, 0);
            this.BtnLogo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogo.Name = "BtnLogo";
            this.TLPnlMenu.SetRowSpan(this.BtnLogo, 2);
            this.BtnLogo.Size = new System.Drawing.Size(135, 150);
            this.BtnLogo.TabIndex = 3;
            this.BtnLogo.UseVisualStyleBackColor = true;
            // 
            // TLPnlTop
            // 
            this.TLPnlTop.ColumnCount = 5;
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLPnlTop.Controls.Add(this.BtnMinimize, 2, 0);
            this.TLPnlTop.Controls.Add(this.LblTop, 0, 0);
            this.TLPnlTop.Controls.Add(this.BtnMaximize, 3, 0);
            this.TLPnlTop.Controls.Add(this.BtnExit, 4, 0);
            this.TLPnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPnlTop.Location = new System.Drawing.Point(135, 0);
            this.TLPnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.TLPnlTop.Name = "TLPnlTop";
            this.TLPnlTop.RowCount = 1;
            this.TLPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlTop.Size = new System.Drawing.Size(1065, 48);
            this.TLPnlTop.TabIndex = 9;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.White;
            this.PnlNav.Location = new System.Drawing.Point(7, 181);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(7, 105);
            this.PnlNav.TabIndex = 10;
            // 
            // PnlFill
            // 
            this.PnlFill.Controls.Add(this.PnlPage);
            this.PnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFill.Location = new System.Drawing.Point(135, 48);
            this.PnlFill.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFill.Name = "PnlFill";
            this.PnlFill.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.PnlFill.Size = new System.Drawing.Size(1065, 702);
            this.PnlFill.TabIndex = 11;
            // 
            // PnlPage
            // 
            this.PnlPage.BackColor = System.Drawing.Color.White;
            this.PnlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPage.Location = new System.Drawing.Point(0, 0);
            this.PnlPage.Margin = new System.Windows.Forms.Padding(0);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(1055, 692);
            this.PnlPage.TabIndex = 0;
            // 
            // FrmNguoiquanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.PnlFill);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.TLPnlTop);
            this.Controls.Add(this.TLPnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNguoiquanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TLPnlMenu.ResumeLayout(false);
            this.TLPnlTop.ResumeLayout(false);
            this.TLPnlTop.PerformLayout();
            this.PnlFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Label LblTop;
        private System.Windows.Forms.TableLayoutPanel TLPnlMenu;
        private System.Windows.Forms.TableLayoutPanel TLPnlTop;
        private System.Windows.Forms.Button BtnLogo;
        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnManage;
        private System.Windows.Forms.Label PnlNav;
        private System.Windows.Forms.Panel PnlFill;
        private System.Windows.Forms.Panel PnlPage;
    }
}
namespace QLDA_Nhom5.FormDesign
{
    partial class FrmTaikhoan
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
            this.PnlTieude = new System.Windows.Forms.Panel();
            this.LblTtinnguoidung = new System.Windows.Forms.Label();
            this.PnlThongtin = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTentk = new System.Windows.Forms.TextBox();
            this.TxtMatk = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTentk = new System.Windows.Forms.Label();
            this.LblMatk = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.BtnDangxuat = new System.Windows.Forms.Button();
            this.GrpDoimatkhau = new System.Windows.Forms.GroupBox();
            this.CBoxShowpassword = new System.Windows.Forms.CheckBox();
            this.BtnHuy = new System.Windows.Forms.Button();
            this.BtnXacnhan = new System.Windows.Forms.Button();
            this.TxtXacnhanmk = new System.Windows.Forms.TextBox();
            this.LblXacnhanmk = new System.Windows.Forms.Label();
            this.TxtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.LblMatkhaumoi = new System.Windows.Forms.Label();
            this.TxtMatkhaucu = new System.Windows.Forms.TextBox();
            this.LblMatkhaucu = new System.Windows.Forms.Label();
            this.BtnDoimatkhau = new System.Windows.Forms.Button();
            this.PnlTieude.SuspendLayout();
            this.PnlThongtin.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            this.GrpDoimatkhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTieude
            // 
            this.PnlTieude.Controls.Add(this.LblTtinnguoidung);
            this.PnlTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTieude.Location = new System.Drawing.Point(0, 0);
            this.PnlTieude.Name = "PnlTieude";
            this.PnlTieude.Size = new System.Drawing.Size(1055, 66);
            this.PnlTieude.TabIndex = 0;
            // 
            // LblTtinnguoidung
            // 
            this.LblTtinnguoidung.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTtinnguoidung.Location = new System.Drawing.Point(86, 26);
            this.LblTtinnguoidung.Name = "LblTtinnguoidung";
            this.LblTtinnguoidung.Size = new System.Drawing.Size(376, 37);
            this.LblTtinnguoidung.TabIndex = 0;
            this.LblTtinnguoidung.Text = "THÔNG TIN NGƯỜI DÙNG";
            this.LblTtinnguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlThongtin
            // 
            this.PnlThongtin.Controls.Add(this.TxtEmail);
            this.PnlThongtin.Controls.Add(this.TxtTentk);
            this.PnlThongtin.Controls.Add(this.TxtMatk);
            this.PnlThongtin.Controls.Add(this.LblEmail);
            this.PnlThongtin.Controls.Add(this.LblTentk);
            this.PnlThongtin.Controls.Add(this.LblMatk);
            this.PnlThongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlThongtin.Location = new System.Drawing.Point(0, 66);
            this.PnlThongtin.Name = "PnlThongtin";
            this.PnlThongtin.Size = new System.Drawing.Size(1055, 170);
            this.PnlThongtin.TabIndex = 1;
            this.PnlThongtin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(263, 124);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(321, 38);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtTentk
            // 
            this.TxtTentk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTentk.Location = new System.Drawing.Point(263, 67);
            this.TxtTentk.Name = "TxtTentk";
            this.TxtTentk.Size = new System.Drawing.Size(321, 38);
            this.TxtTentk.TabIndex = 4;
            // 
            // TxtMatk
            // 
            this.TxtMatk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatk.Location = new System.Drawing.Point(263, 14);
            this.TxtMatk.Name = "TxtMatk";
            this.TxtMatk.Size = new System.Drawing.Size(321, 38);
            this.TxtMatk.TabIndex = 3;
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(87, 126);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(146, 35);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            // 
            // LblTentk
            // 
            this.LblTentk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTentk.Location = new System.Drawing.Point(87, 72);
            this.LblTentk.Name = "LblTentk";
            this.LblTentk.Size = new System.Drawing.Size(161, 35);
            this.LblTentk.TabIndex = 1;
            this.LblTentk.Text = "Tên tài khoản";
            // 
            // LblMatk
            // 
            this.LblMatk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatk.Location = new System.Drawing.Point(87, 23);
            this.LblMatk.Name = "LblMatk";
            this.LblMatk.Size = new System.Drawing.Size(161, 35);
            this.LblMatk.TabIndex = 0;
            this.LblMatk.Text = "Mã tài khoản";
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.BtnDangxuat);
            this.PnlBottom.Controls.Add(this.GrpDoimatkhau);
            this.PnlBottom.Controls.Add(this.BtnDoimatkhau);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBottom.Location = new System.Drawing.Point(0, 236);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Padding = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.PnlBottom.Size = new System.Drawing.Size(1055, 456);
            this.PnlBottom.TabIndex = 2;
            // 
            // BtnDangxuat
            // 
            this.BtnDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnDangxuat.FlatAppearance.BorderSize = 0;
            this.BtnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDangxuat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDangxuat.ForeColor = System.Drawing.Color.White;
            this.BtnDangxuat.Location = new System.Drawing.Point(86, 146);
            this.BtnDangxuat.Name = "BtnDangxuat";
            this.BtnDangxuat.Size = new System.Drawing.Size(167, 51);
            this.BtnDangxuat.TabIndex = 2;
            this.BtnDangxuat.Text = "Đăng xuất";
            this.BtnDangxuat.UseVisualStyleBackColor = false;
            this.BtnDangxuat.Click += new System.EventHandler(this.BtnDangxuat_Click);
            // 
            // GrpDoimatkhau
            // 
            this.GrpDoimatkhau.Controls.Add(this.CBoxShowpassword);
            this.GrpDoimatkhau.Controls.Add(this.BtnHuy);
            this.GrpDoimatkhau.Controls.Add(this.BtnXacnhan);
            this.GrpDoimatkhau.Controls.Add(this.TxtXacnhanmk);
            this.GrpDoimatkhau.Controls.Add(this.LblXacnhanmk);
            this.GrpDoimatkhau.Controls.Add(this.TxtMatkhaumoi);
            this.GrpDoimatkhau.Controls.Add(this.LblMatkhaumoi);
            this.GrpDoimatkhau.Controls.Add(this.TxtMatkhaucu);
            this.GrpDoimatkhau.Controls.Add(this.LblMatkhaucu);
            this.GrpDoimatkhau.Location = new System.Drawing.Point(286, 20);
            this.GrpDoimatkhau.Name = "GrpDoimatkhau";
            this.GrpDoimatkhau.Size = new System.Drawing.Size(546, 270);
            this.GrpDoimatkhau.TabIndex = 1;
            this.GrpDoimatkhau.TabStop = false;
            this.GrpDoimatkhau.Text = "Đổi Mật khẩu";
            this.GrpDoimatkhau.Visible = false;
            // 
            // CBoxShowpassword
            // 
            this.CBoxShowpassword.AutoSize = true;
            this.CBoxShowpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxShowpassword.Location = new System.Drawing.Point(375, 170);
            this.CBoxShowpassword.Name = "CBoxShowpassword";
            this.CBoxShowpassword.Size = new System.Drawing.Size(160, 32);
            this.CBoxShowpassword.TabIndex = 14;
            this.CBoxShowpassword.Text = "Hiện mật khẩu";
            this.CBoxShowpassword.UseVisualStyleBackColor = true;
            this.CBoxShowpassword.CheckedChanged += new System.EventHandler(this.CBoxShowpassword_CheckedChanged);
            // 
            // BtnHuy
            // 
            this.BtnHuy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnHuy.FlatAppearance.BorderSize = 0;
            this.BtnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHuy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHuy.ForeColor = System.Drawing.Color.Black;
            this.BtnHuy.Location = new System.Drawing.Point(134, 211);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Size = new System.Drawing.Size(116, 43);
            this.BtnHuy.TabIndex = 13;
            this.BtnHuy.Text = "Huỷ";
            this.BtnHuy.UseVisualStyleBackColor = false;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // BtnXacnhan
            // 
            this.BtnXacnhan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnXacnhan.FlatAppearance.BorderSize = 0;
            this.BtnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXacnhan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXacnhan.ForeColor = System.Drawing.Color.White;
            this.BtnXacnhan.Location = new System.Drawing.Point(283, 211);
            this.BtnXacnhan.Name = "BtnXacnhan";
            this.BtnXacnhan.Size = new System.Drawing.Size(131, 43);
            this.BtnXacnhan.TabIndex = 12;
            this.BtnXacnhan.Text = "Xác nhận";
            this.BtnXacnhan.UseVisualStyleBackColor = false;
            this.BtnXacnhan.Click += new System.EventHandler(this.BtnXacnhan_Click);
            // 
            // TxtXacnhanmk
            // 
            this.TxtXacnhanmk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtXacnhanmk.Location = new System.Drawing.Point(260, 130);
            this.TxtXacnhanmk.Name = "TxtXacnhanmk";
            this.TxtXacnhanmk.Size = new System.Drawing.Size(279, 38);
            this.TxtXacnhanmk.TabIndex = 11;
            this.TxtXacnhanmk.TextChanged += new System.EventHandler(this.TxtXacnhanmk_TextChanged);
            // 
            // LblXacnhanmk
            // 
            this.LblXacnhanmk.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblXacnhanmk.Location = new System.Drawing.Point(19, 136);
            this.LblXacnhanmk.Name = "LblXacnhanmk";
            this.LblXacnhanmk.Size = new System.Drawing.Size(248, 35);
            this.LblXacnhanmk.TabIndex = 10;
            this.LblXacnhanmk.Text = "Nhập lại mật khẩu mới";
            // 
            // TxtMatkhaumoi
            // 
            this.TxtMatkhaumoi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatkhaumoi.Location = new System.Drawing.Point(260, 72);
            this.TxtMatkhaumoi.Name = "TxtMatkhaumoi";
            this.TxtMatkhaumoi.Size = new System.Drawing.Size(279, 38);
            this.TxtMatkhaumoi.TabIndex = 9;
            this.TxtMatkhaumoi.TextChanged += new System.EventHandler(this.TxtMatkhaumoi_TextChanged);
            // 
            // LblMatkhaumoi
            // 
            this.LblMatkhaumoi.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatkhaumoi.Location = new System.Drawing.Point(19, 78);
            this.LblMatkhaumoi.Name = "LblMatkhaumoi";
            this.LblMatkhaumoi.Size = new System.Drawing.Size(167, 35);
            this.LblMatkhaumoi.TabIndex = 8;
            this.LblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // TxtMatkhaucu
            // 
            this.TxtMatkhaucu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatkhaucu.Location = new System.Drawing.Point(260, 14);
            this.TxtMatkhaucu.Name = "TxtMatkhaucu";
            this.TxtMatkhaucu.Size = new System.Drawing.Size(279, 38);
            this.TxtMatkhaucu.TabIndex = 7;
            this.TxtMatkhaucu.TextChanged += new System.EventHandler(this.TxtMatkhaucu_TextChanged);
            // 
            // LblMatkhaucu
            // 
            this.LblMatkhaucu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatkhaucu.Location = new System.Drawing.Point(19, 20);
            this.LblMatkhaucu.Name = "LblMatkhaucu";
            this.LblMatkhaucu.Size = new System.Drawing.Size(145, 35);
            this.LblMatkhaucu.TabIndex = 6;
            this.LblMatkhaucu.Text = "Mật khẩu cũ";
            // 
            // BtnDoimatkhau
            // 
            this.BtnDoimatkhau.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnDoimatkhau.FlatAppearance.BorderSize = 0;
            this.BtnDoimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoimatkhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoimatkhau.ForeColor = System.Drawing.Color.White;
            this.BtnDoimatkhau.Location = new System.Drawing.Point(86, 57);
            this.BtnDoimatkhau.Name = "BtnDoimatkhau";
            this.BtnDoimatkhau.Size = new System.Drawing.Size(167, 51);
            this.BtnDoimatkhau.TabIndex = 0;
            this.BtnDoimatkhau.Text = "Đổi mật khẩu";
            this.BtnDoimatkhau.UseVisualStyleBackColor = false;
            this.BtnDoimatkhau.Click += new System.EventHandler(this.BtnDoimatkhau_Click);
            // 
            // FrmTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 692);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlThongtin);
            this.Controls.Add(this.PnlTieude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaikhoan";
            this.Text = "1";
            this.Load += new System.EventHandler(this.FrmTaikhoan_Load);
            this.PnlTieude.ResumeLayout(false);
            this.PnlThongtin.ResumeLayout(false);
            this.PnlThongtin.PerformLayout();
            this.PnlBottom.ResumeLayout(false);
            this.GrpDoimatkhau.ResumeLayout(false);
            this.GrpDoimatkhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTieude;
        private System.Windows.Forms.Label LblTtinnguoidung;
        private System.Windows.Forms.Panel PnlThongtin;
        private System.Windows.Forms.Label LblMatk;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTentk;
        private System.Windows.Forms.TextBox TxtMatk;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTentk;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Button BtnDoimatkhau;
        private System.Windows.Forms.GroupBox GrpDoimatkhau;
        private System.Windows.Forms.TextBox TxtXacnhanmk;
        private System.Windows.Forms.Label LblXacnhanmk;
        private System.Windows.Forms.TextBox TxtMatkhaumoi;
        private System.Windows.Forms.Label LblMatkhaumoi;
        private System.Windows.Forms.TextBox TxtMatkhaucu;
        private System.Windows.Forms.Label LblMatkhaucu;
        private System.Windows.Forms.CheckBox CBoxShowpassword;
        private System.Windows.Forms.Button BtnHuy;
        private System.Windows.Forms.Button BtnXacnhan;
        private System.Windows.Forms.Button BtnDangxuat;
    }
}
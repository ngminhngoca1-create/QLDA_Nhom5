namespace QLDA_Nhom5.FormDesign
{
    partial class FrmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangnhap));
            this.PicHeader = new System.Windows.Forms.PictureBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.PicUserID = new System.Windows.Forms.PictureBox();
            this.PnlUserID = new System.Windows.Forms.Panel();
            this.PnlPassword = new System.Windows.Forms.Panel();
            this.PicPassword = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CBoxShowpassword = new System.Windows.Forms.CheckBox();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // PicHeader
            // 
            this.PicHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicHeader.Image = ((System.Drawing.Image)(resources.GetObject("PicHeader.Image")));
            this.PicHeader.Location = new System.Drawing.Point(0, 0);
            this.PicHeader.Name = "PicHeader";
            this.PicHeader.Size = new System.Drawing.Size(681, 132);
            this.PicHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicHeader.TabIndex = 0;
            this.PicHeader.TabStop = false;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblLogin.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblLogin.Location = new System.Drawing.Point(228, 178);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(194, 38);
            this.LblLogin.TabIndex = 1;
            this.LblLogin.Text = "ĐĂNG NHẬP";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicUserID
            // 
            this.PicUserID.Image = ((System.Drawing.Image)(resources.GetObject("PicUserID.Image")));
            this.PicUserID.Location = new System.Drawing.Point(135, 265);
            this.PicUserID.Name = "PicUserID";
            this.PicUserID.Size = new System.Drawing.Size(40, 40);
            this.PicUserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicUserID.TabIndex = 2;
            this.PicUserID.TabStop = false;
            // 
            // PnlUserID
            // 
            this.PnlUserID.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlUserID.Location = new System.Drawing.Point(136, 311);
            this.PnlUserID.Name = "PnlUserID";
            this.PnlUserID.Size = new System.Drawing.Size(400, 2);
            this.PnlUserID.TabIndex = 3;
            // 
            // PnlPassword
            // 
            this.PnlPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlPassword.Location = new System.Drawing.Point(137, 392);
            this.PnlPassword.Name = "PnlPassword";
            this.PnlPassword.Size = new System.Drawing.Size(400, 2);
            this.PnlPassword.TabIndex = 5;
            // 
            // PicPassword
            // 
            this.PicPassword.Image = ((System.Drawing.Image)(resources.GetObject("PicPassword.Image")));
            this.PicPassword.Location = new System.Drawing.Point(136, 342);
            this.PicPassword.Name = "PicPassword";
            this.PicPassword.Size = new System.Drawing.Size(40, 40);
            this.PicPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPassword.TabIndex = 4;
            this.PicPassword.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(135, 478);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(402, 49);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUserID
            // 
            this.TxtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserID.Location = new System.Drawing.Point(198, 274);
            this.TxtUserID.MaxLength = 50;
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(326, 27);
            this.TxtUserID.TabIndex = 7;
            this.TxtUserID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(198, 355);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(326, 27);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // CBoxShowpassword
            // 
            this.CBoxShowpassword.AutoSize = true;
            this.CBoxShowpassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxShowpassword.Location = new System.Drawing.Point(362, 412);
            this.CBoxShowpassword.Name = "CBoxShowpassword";
            this.CBoxShowpassword.Size = new System.Drawing.Size(174, 29);
            this.CBoxShowpassword.TabIndex = 9;
            this.CBoxShowpassword.Text = "Hiển thị mật khẩu";
            this.CBoxShowpassword.UseVisualStyleBackColor = true;
            this.CBoxShowpassword.CheckedChanged += new System.EventHandler(this.CBoxShowpassword_CheckedChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(135, 550);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(402, 45);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 636);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.CBoxShowpassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserID);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PnlPassword);
            this.Controls.Add(this.PicPassword);
            this.Controls.Add(this.PnlUserID);
            this.Controls.Add(this.PicUserID);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.PicHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangnhap";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmDangnhap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PicHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicHeader;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.PictureBox PicUserID;
        private System.Windows.Forms.Panel PnlUserID;
        private System.Windows.Forms.Panel PnlPassword;
        private System.Windows.Forms.PictureBox PicPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox CBoxShowpassword;
        private System.Windows.Forms.Button BtnExit;
    }
}
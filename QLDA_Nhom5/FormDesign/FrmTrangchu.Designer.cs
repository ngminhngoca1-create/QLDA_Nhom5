namespace QLDA_Nhom5.FormDesign
{
    partial class FrmTrangchu
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
            this.TLPnlTimkiem = new System.Windows.Forms.TableLayoutPanel();
            this.LblTimkiem = new System.Windows.Forms.Label();
            this.CmbNganh = new System.Windows.Forms.ComboBox();
            this.CmbNam = new System.Windows.Forms.ComboBox();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.LblNganh = new System.Windows.Forms.Label();
            this.LblNam = new System.Windows.Forms.Label();
            this.PnlDanhsach = new System.Windows.Forms.Panel();
            this.GridDanhsach = new System.Windows.Forms.DataGridView();
            this.TxtTimkiem = new System.Windows.Forms.TextBox();
            this.TLPnlTimkiem.SuspendLayout();
            this.PnlDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPnlTimkiem
            // 
            this.TLPnlTimkiem.ColumnCount = 9;
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TLPnlTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TLPnlTimkiem.Controls.Add(this.LblTimkiem, 1, 0);
            this.TLPnlTimkiem.Controls.Add(this.TxtTimkiem, 1, 1);
            this.TLPnlTimkiem.Controls.Add(this.CmbNam, 5, 1);
            this.TLPnlTimkiem.Controls.Add(this.LblNam, 5, 0);
            this.TLPnlTimkiem.Controls.Add(this.CmbNganh, 3, 1);
            this.TLPnlTimkiem.Controls.Add(this.LblNganh, 3, 0);
            this.TLPnlTimkiem.Controls.Add(this.BtnTimkiem, 7, 1);
            this.TLPnlTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPnlTimkiem.Location = new System.Drawing.Point(0, 0);
            this.TLPnlTimkiem.Name = "TLPnlTimkiem";
            this.TLPnlTimkiem.RowCount = 2;
            this.TLPnlTimkiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlTimkiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.TLPnlTimkiem.Size = new System.Drawing.Size(1055, 104);
            this.TLPnlTimkiem.TabIndex = 0;
            // 
            // LblTimkiem
            // 
            this.LblTimkiem.AutoSize = true;
            this.LblTimkiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblTimkiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimkiem.Location = new System.Drawing.Point(153, 17);
            this.LblTimkiem.Name = "LblTimkiem";
            this.LblTimkiem.Size = new System.Drawing.Size(315, 31);
            this.LblTimkiem.TabIndex = 4;
            this.LblTimkiem.Text = "Tìm kiếm";
            this.LblTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbNganh
            // 
            this.CmbNganh.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CmbNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbNganh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNganh.FormattingEnabled = true;
            this.CmbNganh.Location = new System.Drawing.Point(486, 51);
            this.CmbNganh.Name = "CmbNganh";
            this.CmbNganh.Size = new System.Drawing.Size(241, 36);
            this.CmbNganh.TabIndex = 1;
            // 
            // CmbNam
            // 
            this.CmbNam.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CmbNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbNam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNam.FormattingEnabled = true;
            this.CmbNam.Location = new System.Drawing.Point(747, 51);
            this.CmbNam.Name = "CmbNam";
            this.CmbNam.Size = new System.Drawing.Size(120, 36);
            this.CmbNam.TabIndex = 2;
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTimkiem.FlatAppearance.BorderSize = 0;
            this.BtnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimkiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimkiem.ForeColor = System.Drawing.Color.White;
            this.BtnTimkiem.Location = new System.Drawing.Point(881, 51);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(70, 36);
            this.BtnTimkiem.TabIndex = 5;
            this.BtnTimkiem.Text = "Tìm";
            this.BtnTimkiem.UseVisualStyleBackColor = false;
            // 
            // LblNganh
            // 
            this.LblNganh.AutoSize = true;
            this.LblNganh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblNganh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNganh.Location = new System.Drawing.Point(486, 17);
            this.LblNganh.Name = "LblNganh";
            this.LblNganh.Size = new System.Drawing.Size(241, 31);
            this.LblNganh.TabIndex = 6;
            this.LblNganh.Text = "Ngành";
            this.LblNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNam
            // 
            this.LblNam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblNam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNam.Location = new System.Drawing.Point(747, 20);
            this.LblNam.Name = "LblNam";
            this.LblNam.Size = new System.Drawing.Size(120, 28);
            this.LblNam.TabIndex = 7;
            this.LblNam.Text = "Năm";
            this.LblNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlDanhsach
            // 
            this.PnlDanhsach.Controls.Add(this.GridDanhsach);
            this.PnlDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDanhsach.Location = new System.Drawing.Point(0, 104);
            this.PnlDanhsach.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDanhsach.Name = "PnlDanhsach";
            this.PnlDanhsach.Padding = new System.Windows.Forms.Padding(60, 0, 60, 45);
            this.PnlDanhsach.Size = new System.Drawing.Size(1055, 588);
            this.PnlDanhsach.TabIndex = 1;
            // 
            // GridDanhsach
            // 
            this.GridDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridDanhsach.Location = new System.Drawing.Point(60, 53);
            this.GridDanhsach.Name = "GridDanhsach";
            this.GridDanhsach.RowHeadersWidth = 51;
            this.GridDanhsach.RowTemplate.Height = 24;
            this.GridDanhsach.Size = new System.Drawing.Size(935, 490);
            this.GridDanhsach.TabIndex = 0;
            // 
            // TxtTimkiem
            // 
            this.TxtTimkiem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtTimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtTimkiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimkiem.Location = new System.Drawing.Point(153, 51);
            this.TxtTimkiem.Name = "TxtTimkiem";
            this.TxtTimkiem.Size = new System.Drawing.Size(315, 34);
            this.TxtTimkiem.TabIndex = 8;
            // 
            // FrmTrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 692);
            this.Controls.Add(this.PnlDanhsach);
            this.Controls.Add(this.TLPnlTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTrangchu";
            this.Text = "FrmTrangchu";
            this.TLPnlTimkiem.ResumeLayout(false);
            this.TLPnlTimkiem.PerformLayout();
            this.PnlDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDanhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPnlTimkiem;
        private System.Windows.Forms.ComboBox CmbNganh;
        private System.Windows.Forms.ComboBox CmbNam;
        private System.Windows.Forms.Panel PnlDanhsach;
        private System.Windows.Forms.Label LblTimkiem;
        private System.Windows.Forms.DataGridView GridDanhsach;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.Label LblNganh;
        private System.Windows.Forms.Label LblNam;
        private System.Windows.Forms.TextBox TxtTimkiem;
    }
}
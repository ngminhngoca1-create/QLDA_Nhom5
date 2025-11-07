namespace QLDA_Nhom5.FormDesign
{
    partial class FrmXemtailieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXemtailieu));
            this.PnlView = new System.Windows.Forms.Panel();
            this.TLPnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PdfView = new AxAcroPDFLib.AxAcroPDF();
            this.PnlView.SuspendLayout();
            this.TLPnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PdfView)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlView
            // 
            this.PnlView.Controls.Add(this.TLPnlTop);
            this.PnlView.Controls.Add(this.PdfView);
            this.PnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlView.Location = new System.Drawing.Point(0, 0);
            this.PnlView.Margin = new System.Windows.Forms.Padding(0);
            this.PnlView.Name = "PnlView";
            this.PnlView.Padding = new System.Windows.Forms.Padding(10);
            this.PnlView.Size = new System.Drawing.Size(1055, 692);
            this.PnlView.TabIndex = 0;
            // 
            // TLPnlTop
            // 
            this.TLPnlTop.ColumnCount = 2;
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.43478F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.56522F));
            this.TLPnlTop.Controls.Add(this.BtnBack, 0, 0);
            this.TLPnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPnlTop.Location = new System.Drawing.Point(10, 10);
            this.TLPnlTop.Name = "TLPnlTop";
            this.TLPnlTop.RowCount = 1;
            this.TLPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPnlTop.Size = new System.Drawing.Size(1035, 40);
            this.TLPnlTop.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(0, 0);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(107, 40);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Trở về";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PdfView
            // 
            this.PdfView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PdfView.Enabled = true;
            this.PdfView.Location = new System.Drawing.Point(10, 10);
            this.PdfView.Name = "PdfView";
            this.PdfView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PdfView.OcxState")));
            this.PdfView.Size = new System.Drawing.Size(1035, 672);
            this.PdfView.TabIndex = 0;
            // 
            // FrmXemtailieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 692);
            this.Controls.Add(this.PnlView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmXemtailieu";
            this.Text = "FrmXemtailieu";
            this.PnlView.ResumeLayout(false);
            this.TLPnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PdfView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlView;
        private AxAcroPDFLib.AxAcroPDF PdfView;
        private System.Windows.Forms.TableLayoutPanel TLPnlTop;
        private System.Windows.Forms.Button BtnBack;
    }
}
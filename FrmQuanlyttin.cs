using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDA_Nhom5.FormDesign
{
    public partial class FrmQuanlyttin : Form
    {
        public FrmQuanlyttin()
        {
            InitializeComponent();
        }

        // Quản lý giáo viên hướng dẫn
        private void MnuGvhd_Click(object sender, EventArgs e)
        {
            PnlView.Controls.Clear();
            FrmQlyGVHD frmtch = new FrmQlyGVHD();
            frmtch.TopLevel = false;
            frmtch.Dock = DockStyle.Fill;
            PnlView.Controls.Add(frmtch);
            frmtch.BringToFront();
            frmtch.Show();
        }

        // Quản lý đồ án
        private void MnuDoan_Click(object sender, EventArgs e)
        {
            PnlView.Controls.Clear();
            FrmQlyTailieu frmdoc = new FrmQlyTailieu();
            frmdoc.TopLevel = false;
            frmdoc.Dock = DockStyle.Fill;
            PnlView.Controls.Add(frmdoc);
            frmdoc.BringToFront();
            frmdoc.Show();
        }

        // Quản lý tài liệu
        private void MnuTailieu_Click(object sender, EventArgs e)
        {
            PnlView.Controls.Clear();
            FrmQlyDoan frmprj = new FrmQlyDoan();
            frmprj.TopLevel = false;
            frmprj.Dock = DockStyle.Fill;
            PnlView.Controls.Add(frmprj);
            frmprj.BringToFront();
            frmprj.Show();
        }

        // Quản lý sinh viên thực hiện
        private void MnuSvth_Click(object sender, EventArgs e)
        {
            PnlView.Controls.Clear();
            FrmQlySVTH frmstd = new FrmQlySVTH();
            frmstd.TopLevel = false;
            frmstd.Dock = DockStyle.Fill;
            PnlView.Controls.Add(frmstd);
            frmstd.BringToFront();
            frmstd.Show();
        }
    }
}

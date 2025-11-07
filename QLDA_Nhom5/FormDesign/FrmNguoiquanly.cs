using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA_Nhom5.FormDesign
{
    public partial class FrmNguoiquanly : Form
    {
        //khai báo biến lưu tên người dùng, mã người dùng và vai trò
        private string Ma;
        private string Tennguoidung;
        private int Vaitro;

        public FrmNguoiquanly(string Ma, string Tennguoidung, int Vaitro)
        {
            InitializeComponent();
            this.Ma = Ma;
            this.Tennguoidung = Tennguoidung;
            this.Vaitro = Vaitro;

            //Phân quyền hiển thị nút Báo cáo
            if (Vaitro == 2)
            {
                BtnReport.Visible = false;
            }
            else if (Vaitro == 1)
            {
                BtnReport.Visible = true;
            }
        }

        private Form activeForm;
        private void ActivateButton(object btnSender)
        {

        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            { activeForm.Close(); }
            ActivateButton(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            PnlPage.Controls.Add(childform);
            PnlPage.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnManage.Height - 20;
            PnlNav.Top = BtnManage.Top;
            PnlNav.Location = new Point(7, 181);
            OpenChildForm(new FrmQuanlyttin(), sender);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnReport.Height - 20;
            PnlNav.Top = BtnReport.Top;
            PnlNav.Location = new Point(7, 306);
            OpenChildForm(new FrmBaocao(), sender);
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAccount.Height - 20;
            PnlNav.Top = BtnAccount.Top;
            PnlNav.Location = new Point(7, 431);
            //Mở form tài khoản và truyền tên người dùng
            OpenChildForm(new FrmTaikhoan(Tennguoidung), sender);
        }
    }
}

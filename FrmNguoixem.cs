using QLDA_Nhom5.FormDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA_Nhom5
{
    public partial class FrmNguoixem : Form
    {

        //khai báo biến lưu tên người dùng và mã người dùng
        private string Ma;
        private string Tennguoidung;

        public FrmNguoixem(string Ma, string Tennguoidung)
        {
            InitializeComponent();
            //this.Tennguoidung là thuộc tính của lớp FrmNguoixem
            this.Ma = Ma;
            this.Tennguoidung = Tennguoidung;
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHome.Height - 20;
            PnlNav.Top = BtnHome.Top;
            PnlNav.Location = new Point(7, 181);
            OpenChildForm(new FrmTrangchu(), sender);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnInfo.Height -20;
            PnlNav.Top = BtnInfo.Top;
            PnlNav.Location = new Point(7, 306);
            OpenChildForm(new FrmLienhe(), sender);
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAccount.Height -20;
            PnlNav.Top = BtnAccount.Top;
            PnlNav.Location = new Point(7, 431);
            OpenChildForm(new FrmTaikhoan(Tennguoidung), sender);
        }
    }
}

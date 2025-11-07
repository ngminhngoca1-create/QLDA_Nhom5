using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLDA_Nhom5.Data; // để dùng DBHelper

namespace QLDA_Nhom5.FormDesign
{
    public partial class FrmTaikhoan : Form
    {
        private string TenNguoidung; // tên đăng nhập hiện tại

        public FrmTaikhoan(string Tennguoidung)
        {
            InitializeComponent();
            this.TenNguoidung = Tennguoidung;  // gán giá trị cho biến thành viên
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Đăng xuất
        private void BtnDangxuat_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Khởi động lại ứng dụng
        }

        //Hiển thị nhóm đổi mật khẩu
        private void BtnDoimatkhau_Click(object sender, EventArgs e)
        {
            GrpDoimatkhau.Visible = true;
        }

        //Khởi động form
        private void FrmTaikhoan_Load(object sender, EventArgs e)
        {
            GrpDoimatkhau.Visible = false;
            CBoxShowpassword.Checked = false;
            TxtMatkhaucu.UseSystemPasswordChar = true;
            TxtMatkhaumoi.UseSystemPasswordChar = true;
            TxtXacnhanmk.UseSystemPasswordChar = true;
        }

        //Hủy đổi mật khẩu
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            GrpDoimatkhau.Visible = false;
            TxtMatkhaucu.Clear();
            TxtMatkhaumoi.Clear();
            TxtXacnhanmk.Clear();
        }

        //Hiển thị hoặc ẩn mật khẩu khi checkbox được chọn hoặc bỏ chọn
        private void CBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxShowpassword.Checked == true)
            {
                TxtMatkhaucu.UseSystemPasswordChar = false;
                TxtMatkhaumoi.UseSystemPasswordChar = false;
                TxtXacnhanmk.UseSystemPasswordChar = false;
            }
            else
            {
                TxtMatkhaucu.UseSystemPasswordChar = true;
                TxtMatkhaumoi.UseSystemPasswordChar = true;
                TxtXacnhanmk.UseSystemPasswordChar = true;
            }
        }

        //Đổi mật khẩu
        private void BtnXacnhan_Click(object sender, EventArgs e)
        {
            string Mkcu = TxtMatkhaucu.Text;
            string Mkmoi = TxtMatkhaumoi.Text;
            string Mkxacnhan = TxtXacnhanmk.Text;

            if (string.IsNullOrWhiteSpace(Mkcu) || string.IsNullOrWhiteSpace(Mkmoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (Mkmoi != Mkxacnhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!");
                return;
            }
            //Kiểm tra mật khẩu cũ trong SQL
            string checkQuery = "SELECT COUNT(*) FROM NguoiDung WHERE TenNguoiDung=@u AND MatKhau=@p";
            SqlParameter[] checkParam =
            {
                new SqlParameter("@u", TenNguoidung),
                new SqlParameter("@p", Mkcu)
            };

            //Thực thi câu truy vấn và lấy kết quả
            object result = DBHelper.ExecuteScalar(checkQuery, checkParam);
            int count = Convert.ToInt32(result);

            //Nếu tìm thấy tài khoản với mật khẩu cũ
            if (count == 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            //Cập nhật mật khẩu mới
            string updateQuery = "UPDATE NguoiDung SET MatKhau=@newPass WHERE TenNguoiDung=@u";
            SqlParameter[] updateParam =
            {
                new SqlParameter("@newPass", Mkmoi),
                new SqlParameter("@u", TenNguoidung)
            };

            int rows = DBHelper.ExecuteNonQuery(updateQuery, updateParam);
            if (rows > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                GrpDoimatkhau.Visible = false;
                TxtMatkhaucu.Clear();
                TxtMatkhaumoi.Clear();
                TxtXacnhanmk.Clear();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi đổi mật khẩu!");
            }
        }

        private void TxtMatkhaucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMatkhaumoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtXacnhanmk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

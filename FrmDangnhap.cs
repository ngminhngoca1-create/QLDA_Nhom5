using QLDA_Nhom5.Data; // để dùng DBHelper
using System.Data.SqlClient;
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
    public partial class FrmDangnhap : Form
    {
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Hiển thị hoặc ẩn mật khẩu khi checkbox được chọn hoặc bỏ chọn
        private void CBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(CBoxShowpassword.Checked == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        // Xử lý sự kiện khi nhấn nút Đăng nhập
        //Trim() để loại bỏ khoảng trắng thừa
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Ma = TxtUserID.Text.Trim();
            string Mkhau = TxtPassword.Text.Trim();

            // Kiểm tra trống
            if(string.IsNullOrEmpty(Ma) || string.IsNullOrEmpty(Mkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã người dùng và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện đăng nhập
            try
            {
                // Câu truy vấn kiểm tra tài khoản
                string sql = "SELECT VaiTro, TenNguoiDung FROM NguoiDung WHERE MaNguoiDung = @ma AND MatKhau = @mk";

                // Tham số truy vấn là SqlParameter để tránh SQL Injection
                //SqlParameter giúp truyền tham số an toàn vào câu lệnh SQL
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ma", Ma),
                    new SqlParameter("@mk", Mkhau)
                };

                //DataTable là bảng dữ liệu tạm thời trong bộ nhớ để lưu trữ kết quả truy vấn SQL
                DataTable dt = DBHelper.ExecuteQuery(sql, parameters);

                // Kiểm tra kết quả truy vấn 
                // dt == null: lỗi kết nối CSDL
                //MessageBoxButtons.OK: nút OK trong hộp thoại
                //MessageBoxIcon.Error: biểu tượng lỗi trong hộp thoại
                if (dt == null)
                {
                    MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu không có dòng nào trả về, nghĩa là sai tài khoản hoặc mật khẩu
                // Rows.Count: đếm số dòng trong DataTable
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sai mã người dùng hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đăng nhập thành công
                // Lấy thông tin người dùng từ DataTable
                // Chuyển đổi kiểu dữ liệu nếu cần thiết, ví dụ Convert.ToInt32 là chuyển chuỗi sang số nguyên để so sánh vai trò
                string Tennguoidung = dt.Rows[0]["TenNguoiDung"].ToString();
                int Vaitro = Convert.ToInt32(dt.Rows[0]["VaiTro"]);

                MessageBox.Show($"Xin chào {Tennguoidung}!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ẩn form đăng nhập
                this.Hide();

                // Phân quyền hiển thị form
                if (Vaitro == 1 || Vaitro == 2)
                {
                    FrmNguoiquanly f = new FrmNguoiquanly(Ma, Tennguoidung, Vaitro);
                    f.ShowDialog();
                }
                else if (Vaitro == 3)
                {
                    FrmNguoixem f = new FrmNguoixem(Ma, Tennguoidung);
                    f.ShowDialog();
                }

                // Khi form con đóng, thoát chương trình
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Xử lý sự kiện khi nhấn phím Enter để chuyển sang điều khiển tiếp theo
        private void FrmDangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDA_Nhom5.FormDesign; // Đảm bảo namespace đúng để truy cập FrmDangnhap

namespace QLDA_Nhom5
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Khởi chạy form đăng nhập đầu tiên
            Application.Run(new FrmDangnhap());
        }
    }
}

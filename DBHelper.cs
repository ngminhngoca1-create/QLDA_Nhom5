using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QLDA_Nhom5.Data
{
    public static class DBHelper
    {
        // Chuỗi kết nối — bạn chỉ cần chỉnh tên server hoặc database ở đây
        private static readonly string connectionString =
            @"Data Source = DESKTOP-P6P85M2; Initial Catalog = QLDA_Nhom5; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";

        // Kiểm tra kết nối
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogError("Lỗi kiểm tra kết nối: " + ex.Message);
                return false;
            }
        }

        // Hàm lấy kết nối nội bộ
        private static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // SELECT → trả về DataTable
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                LogError($"ExecuteQuery lỗi: {ex.Message}\nSQL: {query}");
                return null;
            }
        }

        // INSERT / UPDATE / DELETE
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LogError($"ExecuteNonQuery lỗi: {ex.Message}\nSQL: {query}");
                return -1;
            }
        }

        // SELECT 1 giá trị duy nhất (COUNT, MAX, …)
        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                LogError($"ExecuteScalar lỗi: {ex.Message}\nSQL: {query}");
                return null;
            }
        }

        // Ghi lỗi ra file log trong thư mục chạy chương trình
        private static void LogError(string message)
        {
            string logPath = Path.Combine(Application.StartupPath, "error_log.txt");
            string logMsg = $"[{DateTime.Now:dd/MM/yyyy HH:mm:ss}] {message}\n";
            File.AppendAllText(logPath, logMsg);
        }
    }
}

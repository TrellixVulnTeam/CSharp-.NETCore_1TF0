﻿using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            // kết nối với SQL SERVER

            // chuỗi kết nối
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder["Server"] = "DESKTOP-3VODAHR";
            sqlStringBuilder["Database"] = "xtlab";
            sqlStringBuilder["UID"] = "sa";
            sqlStringBuilder["PWD"] = "123456789";

            Console.WriteLine(sqlStringBuilder.ToString());

            /*

            string sqlStringConn = "Server=127.0.0.1; Initial Catalog = xtlab; User ID = sa; Password = 123456789";  // chuối kết nối
            using var conn = new SqlConnection(sqlStringConn);
            Console.WriteLine(conn.State); //trạng thái của conn
            conn.Open();
            Console.WriteLine(conn.State); //trạng thái của conn
            */

            using var conn = new SqlConnection(sqlStringBuilder.ToString());
            conn.Open();

            // truy vấn (cần sử dụng từ khóa using để có thể tự động giải phóng tài nguyên)

            using DbCommand command = new SqlCommand();
            command.Connection = conn; // Thiết lập kết nối là gì 
            command.CommandText = "SELECT TOP (5) * FROM SanPham "; // Lây s5 sản phẩm đầu tiên

            // truy vấn và lấy dữ liệu về
            command.ExecuteReader();
            var dataReader = command.ExecuteReader();
            while (dataReader.Read()) // đọc các trường dữ liệu, trả về TRUE thì đọc được, ngược lại không đọc được
            {
                Console.WriteLine($"{dataReader["Ténanpham"],10}");
            }

            conn.Close();

            // KẾT NỐI VỚI MYSQL


        }
    }
}
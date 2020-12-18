using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class About
    {
        public static void Information()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine(" Đồ án NMLT");
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine(" Viết phần mềm quản lý cửa hàng với các chức năng sau:");
            Console.WriteLine(" - Thêm, xóa, sửa và tìm kiếm các mặt hàng (mã, tên hàng, hạn dùng, công ty sản xuất, năm sản xuất, loại hàng).");
            Console.WriteLine(" - Thêm, xóa, sửa và tìm kiếm các loại hàng.");
            Console.WriteLine(" * Chú ý:");
            Console.WriteLine("    - Làm với giao diện console hoặc windows form");
            Console.WriteLine("    - Các dữ liệu không cần lưu trữ lại");
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine(" Author : Lê Thành Trung");
            Console.WriteLine(" 20880106");
            Console.WriteLine("__________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 15;
            Console.WriteLine("Home [ESC]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            bool loop = true;
            while (loop)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    loop = false;

                }
            }
            Console.Clear();
            Console.CursorVisible = false;
            Program.AppMain();

        }
    }
}

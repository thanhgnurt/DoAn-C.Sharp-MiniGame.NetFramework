using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class Tittle
    {
        //--Tiêu đề
        public static void TieuDe()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
           // Console.WriteLine("                            |");
            Console.WriteLine(" Lê Thành Trung             |");
            Console.WriteLine(" MSSV: 20880106             |");
            Console.WriteLine("____________________________|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 32;
            Console.WriteLine(" Lựa chọn [UP/DOWN/LEFT/RIGHT] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 66;
            Console.WriteLine(" Select [ENTER] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 85;
            Console.WriteLine(" Exit [ESC] ");
            Console.CursorTop = 27;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            TenPhanMem();
            Console.ForegroundColor = ConsoleColor.Black;
           // Console.WriteLine("____________________________");
        }
        static void TenPhanMem()
        {
            int left = 45;
            Console.CursorTop = 2;
            Console.CursorLeft = left;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                             ");
            Console.CursorTop = 3;
            Console.CursorLeft = left;
            Console.WriteLine("  PHẦN MỀM QUẢN LÝ HÀNG HÓA  ");
            Console.CursorTop = 4;
            Console.CursorLeft = left;
            Console.WriteLine("                             ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}

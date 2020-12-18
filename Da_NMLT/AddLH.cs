using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class AddLH
    {
        // sửa lại thêm laoij hang
        public static void ThemLoaiHang(ref ArrayList ArrayLH, ref ArrayList ArrayHH)
        {
            Console.CursorVisible = false;
            Form.FormLoaiHang("THÊM LOẠI HÀNG");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.WriteLine("THÊM LOẠI HÀNG |");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Console.CursorTop = 0;
            Console.CursorLeft =37;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Nhập [ENTER] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 56;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Home [ESC] ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            if (input.Key == ConsoleKey.Escape)
            {
                Program.AppMain();
            } else
            {
                Console.CursorVisible = true;
                Console.CursorTop = 0;
                Console.CursorLeft = 37;
                Console.WriteLine("               ");
                Console.CursorTop = 0;
                Console.CursorLeft = 56;
                Console.WriteLine("                ");
                Struct.LOAIHANG LH;
                Add.InputHH(1, 2, "");
                LH.MaLH = Console.ReadLine();
                Add.InputHH(2, 2, "");
                LH.TenLH = Console.ReadLine();
                Add.InputHH(3, 2, "");
                LH.MotaLH = Console.ReadLine();
                bool flag;
                flag = Form.FormXacNhan(10, 40, 5, 40, "Save LH");
                if (flag)
                {
                    ArrayLH.Add(LH);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bạn đã lưu thành công!");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 4);

                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    ThemLoaiHang(ref ArrayLH, ref ArrayHH);
                }


            }





        }
    }
}

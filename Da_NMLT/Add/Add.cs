using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Add
    {
       
        // -- nhập ngày tháng
        static void NhapNgayThangNam(ref int ngay, ref int thang, ref int nam, int top, int left)
        {
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorTop = top * 4 - 2;
            Console.CursorLeft = 1;
            Console.WriteLine("Hạn sử dụng:");
            Console.CursorTop = top * 4-1 ;
            Console.CursorLeft = 2;
            Console.WriteLine("Ngày:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = top * 4-1;
            Console.CursorLeft = 8;
            Console.WriteLine("-------------");
            Console.CursorLeft = 8;
            Console.WriteLine("             ");
            Console.CursorLeft = 8;
            Console.WriteLine("             ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = 9;
            ngay = NhapInt(ngay, "Ngày", 12, 9);
            Console.CursorTop = top * 4-1;
            Console.CursorLeft = 24;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tháng:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = top * 4 - 1;
            Console.CursorLeft = 31;
            Console.WriteLine("--------------");
            Console.CursorLeft = 31;
            Console.WriteLine("              ");
            Console.CursorLeft = 31;
            Console.WriteLine("              ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = 32;
            thang = NhapInt(thang, "Tháng", 12, 32);
            Console.CursorTop = top * 4-1;
            Console.CursorLeft = 49;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("Năm:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = top * 4 - 1;
            Console.CursorLeft = 54;
            Console.WriteLine("--------------");
            Console.CursorLeft = 54;
            Console.WriteLine("              ");
            Console.CursorLeft = 54;
            Console.WriteLine("              ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = 55;
            nam = NhapInt(nam,"Năm", 12, 55);


        }
        //-- nhập dữ liệu, int = 1, string = 0
        static int NhapInt(int intBN, string DoiTuong, int top, int left)
        {
            int flag = 1;
            for(; ; )
            {
                try
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    intBN = int.Parse(Console.ReadLine());
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.CursorLeft = 0;
                    Console.CursorTop = 27;
                    Console.Write("                                                         ");
                    return intBN;
                }
                catch
                {
                    Console.CursorTop = top;
                    Console.CursorLeft = left;
                    if (left > 5)
                    {
                        Console.Write("         ");
                    }
                    else
                    {
                        Console.Write("                                                   ");
                    }
                    if (flag == 3)
                    {
                        flag = 0;
                    }
                    flag++;
                    Console.CursorLeft = 0;
                    Console.CursorTop = 27;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("  ");
                    Console.CursorLeft = 2;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" Bạn nhập sai định dạng ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" {0} ", DoiTuong);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" vui lòng nhập số!     ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorTop = top;
                    Console.CursorLeft = left;

                }
            }
        }
        // điều hướng
        public static void DieuHuong(ref ArrayList ArrayHH, ref ArrayList ArrayLH)
        {
            
            Console.CursorTop = 5;
            Console.CursorLeft = 40;
            Console.WriteLine("Để quay lại trang chính chọn BACKSPACE");
            Console.CursorTop = 6;
            Console.CursorLeft = 40;
            Console.WriteLine("Để thêm sản phẩm mới chọn ENTER");
            Console.CursorTop = 7;
            Console.CursorLeft = 40;
            Console.WriteLine("Để thoát chon ESC");
            Console.CursorTop = 8;
            Console.CursorLeft = 40;
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Enter:
                    Console.CursorVisible = true;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    ThemHangHoa(ref ArrayHH, ref ArrayLH);
                    break;
                case ConsoleKey.Backspace:
                    Console.CursorVisible = false;
                    Console.Clear();
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH,ref ArrayLH, 0);
                    break;
                default:
                    Console.CursorVisible = false;
                    DieuHuong(ref ArrayHH, ref ArrayLH);
                    break;
            }

        }

        //  input
        public static void InputHH(int top, int left, string header)
        {
            //first top 4 left 1
            Console.CursorTop = top * 4 -2;
            Console.CursorLeft = 0;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" {0}",header);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                                                                    ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = left;

        }

        
        public static void ThemHangHoa(ref ArrayList ArrayHH, ref ArrayList ArrayLH)
        {
            Console.CursorVisible = false;
            Form.FormHangHoa("THÊM HÀNG HÓA");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.WriteLine(" THÊM HÀNG HÓA |");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Console.CursorTop = 0;
            Console.CursorLeft = 37;
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
                Console.WriteLine("                 ");
                Console.CursorTop = 0;
                Console.CursorLeft = 56;
                Console.WriteLine("                  ");
                Struct.HOANGHOA SP;
                InputHH(1, 2, "Mã hàng hóa:");
                SP.MaHH = Console.ReadLine();
                InputHH(2, 2, "Tên hàng hóa:");
                SP.TenHH = Console.ReadLine();
                int ngay = 0, thang = 0, nam = 0;
                NhapNgayThangNam(ref ngay, ref thang, ref nam, 3, 1);
                SP.HanDung.Ngay = ngay;
                SP.HanDung.Nam = nam;
                SP.HanDung.Thang = thang;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                InputHH(4, 2, "Công ty sản xuất:                               ");
                SP.CtySX = Console.ReadLine();
                InputHH(5, 1, "Năm xản xuât");
                int namSX = 0;
                Console.CursorLeft = 2;
                SP.NamSX = NhapInt(namSX, "Năm Sản Xuất", 20, 2);
                Add.InputHH(6, 2, "Loại hàng hóa:      ");
                SP.LoaiHang = Console.ReadLine();
                bool flag;
                flag = Form.FormXacNhan(10, 40, 5, 40, "Save HH");
                if (flag)
                {
                    ArrayHH.Add(SP);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bạn đã lưu thành công!");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 0);

                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    ThemHangHoa(ref ArrayHH, ref ArrayLH);
                }
            }


        }
    }
}

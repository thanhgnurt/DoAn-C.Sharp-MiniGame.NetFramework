using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
namespace DoAn_NMLT_20880106
{
    public class DeleteLH
    {


        // function main
        public static void XoaLoaiHang(ref ArrayList ArrayLH, ref ArrayList ArrayHH, int index)
        {
            //---back main
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 15;
            Console.WriteLine("Lựa chọn [UP/DOWN]");
            Console.CursorTop = 0;
            Console.CursorLeft = 35;
            Console.WriteLine("Xóa [ENTER]");
            Console.CursorTop = 0;
            Console.CursorLeft = 50;
            Console.WriteLine("Home [ESC]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            if (ArrayHH.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Kho hàng hóa của bạn đang trống.");
            }
            else
            {
                Show.HienThiLoaiHang(ref ArrayLH, ref ArrayHH, "Delete LH", index);


            }

        }
        //










        //
        public static void XoaLH(ref ArrayList ArrayLH, ref ArrayList ArrayHH, string ChucNang, int index, int selected)
        {
        
            Console.WriteLine(" Nhấn ESC để về màn hình chính! ");
            bool flagSave;
            flagSave = Form.FormXacNhan(10, 40, 5, 40, ChucNang);
            if (flagSave)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                ArrayLH.RemoveAt(index);
                XoaLoaiHang(ref ArrayLH, ref ArrayHH, 1);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                XoaLoaiHang(ref ArrayLH, ref ArrayHH, 1);
            }


        }


        //
    





    }
}

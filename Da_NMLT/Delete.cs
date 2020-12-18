using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public class Delete
    {
        // function second
        public static void XoaHH(ref ArrayList ArrayHH, ref ArrayList ArrayLH, string ChucNang, int index)
        {
            bool flag;
            flag = Form.FormXacNhan(10, 40, 5, 40, ChucNang);
            if (flag)
            {
                ArrayHH.RemoveAt(index);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.CursorTop = 0;
                Console.CursorLeft = 94;
                Console.WriteLine(" Sản phẩm xóa thành công! ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
            
                //
                XoaHangHoa(ref ArrayHH, ref ArrayLH);
               

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                XoaHangHoa(ref ArrayHH, ref ArrayHH);
                Console.Read();
            }

        }
        //function main
        public static void XoaHangHoa(ref ArrayList ArrayHH, ref ArrayList ArrayLH)
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
            if (ArrayHH.Count==0)
            {
                Console.Clear();
                Console.WriteLine("Kho hàng hóa của bạn đang trống.");
            } else
            {
                Show.HienThiHangHoa(ref ArrayHH,ref ArrayLH, "Delete HH");


            }

        }
    }
}

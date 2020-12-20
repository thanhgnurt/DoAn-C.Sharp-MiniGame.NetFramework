using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
namespace DoAn_NMLT_20880106
{
    public class Find
    {
        public static void TimKiemHangHoa(ArrayList ArrayHH, ArrayList ArrayLH)
        {
            Console.CursorVisible = true;
            string keySearch = " ";
            ArrayList ArrayFind = new ArrayList();
            ArrayFind.Clear();
            Form.FormTimKiem("TÌM KIẾM HÀNG HÓA!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 4;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            keySearch = Console.ReadLine();
            ArrayFind = FindHH(ArrayHH, keySearch);
            HienThiHangHoaTimKiem(ArrayFind,ArrayLH, "Danh sách hàng hóa");
            Console.CursorTop = 4;
            Console.CursorLeft = 2;
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Escape:

                    Console.CursorVisible = false;
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 0);
                    break;
                case ConsoleKey.Enter:
                    Console.CursorVisible = false;
                    Console.Clear();
                    TimKiemHangHoa(ArrayHH,ArrayLH);
                    break;

            }


        }
        //--function tim kiem hang hoa
        static ArrayList FindHH(ArrayList ArrayHH, string keySearch)
        {
            ArrayList ArrayFind = new ArrayList();
           
            ArrayFind.Clear();
            for(int i=0; i<ArrayHH.Count; i++)
            {
                Struct.HOANGHOA item = (Struct.HOANGHOA)ArrayHH[i];
                string tenHH = item.TenHH.Trim().ToLower();
                keySearch = keySearch.Trim().ToLower();
                if (tenHH.Contains(keySearch))
                {
                    ArrayFind.Add(item);
                }
                
            }
          
            return ArrayFind;
        }


        public static void HienThiHangHoaTimKiem(ArrayList ArrayHH, ArrayList ArrayLH, string ChucNang)
        {
            // Struct.HOANGHOA hh = (Struct.HOANGHOA)ArrayHH[1];

            int top = 6;
            int stt = 1;
            int select = 0;
            Console.CursorTop = 0;
            Console.CursorLeft = 38;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" Sửa/Xóa [ENTER] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 56;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" Home [ESC] ");
            Console.CursorTop = 6;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.CursorTop = 6;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("                      " + ChucNang + "                          ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Show.HienThi(ArrayHH, stt, select, top);
            Show.inputSeclectFind(ArrayHH, ArrayLH, stt, select, "Find HH");


        }























    }
}

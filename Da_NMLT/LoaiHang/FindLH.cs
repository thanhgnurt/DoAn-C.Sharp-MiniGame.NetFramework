using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
namespace DoAn_NMLT_20880106
{
    public class FindLH
    {
        public static void TimKiemLoaiHang(ArrayList ArrayLH, ArrayList ArrayHH)
        {
            Console.CursorVisible = true;
            string keySearch = " ";
            ArrayList ArrayFind = new ArrayList();
            ArrayFind.Clear();
            Form.FormTimKiem("TÌM KIẾM LOẠI HÀNG!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 4;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            keySearch = Console.ReadLine();
            ArrayFind = TimKiemLH(ArrayLH, keySearch);
            HienThiLoaiHangTimKiem(ArrayFind, ArrayHH, "Danh sách loại hàng");
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
                    Console.CursorVisible = true;
                    Console.Clear();
                    TimKiemLoaiHang(ArrayHH, ArrayLH);
                    break;

            }


        }
        //--function tim kiem hang hoa
        static ArrayList TimKiemLH(ArrayList ArrayLH, string keySearch)
        {
            ArrayList ArrayFind = new ArrayList();
            ArrayFind.Clear();
            for (int i = 0; i < ArrayLH.Count; i++)
            {
                Struct.LOAIHANG item = (Struct.LOAIHANG)ArrayLH[i];
                string tenHH = item.TenLH.Trim().ToLower();
                keySearch = keySearch.Trim().ToLower();
                if (tenHH.Contains(keySearch))
                {
                    ArrayFind.Add(item);
                }

            }

            return ArrayFind;
        }

        public static void HienThiLoaiHangTimKiem(ArrayList ArrayLH, ArrayList ArrayHH, string ChucNang)
        {
            // Struct.HOANGHOA hh = (Struct.HOANGHOA)ArrayHH[1];

            int top = 6;
            int stt = 1;
            int select = 0;
            Console.CursorTop = 0;
            Console.CursorLeft = 25;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Sửa/Xóa [ENTER]");
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
            Show.HienThiLH(ArrayLH, stt, select, top);
            inputSeclectFindLH(ArrayLH, ArrayHH, stt, select, "Find LH");

        }


        public static void inputSeclectFindLH(ArrayList ArrayLH, ArrayList ArrayHH, int stt, int select, string ChucNang)
        {

            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            int top = 0;
            if (ChucNang == "Find HH" || ChucNang == "Find LH" || ChucNang == "Find")
            {
                top = 6;
            }
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (select == 0)
                    {

                        Show.HienThiLH(ArrayLH, stt, select, top);
                        Show.inputSeclectLH(ref ArrayLH, ref ArrayHH, stt, select, ChucNang);
                    }
                    else
                    {
                        select--;
                        Show.HienThiLH(ArrayLH, stt, select, top);
                        Show.inputSeclectLH(ref ArrayLH, ref ArrayHH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.DownArrow:
                    if (select == ArrayLH.Count - 1)
                    {
                        Show.HienThiLH(ArrayLH, stt, select, top);
                        Show.inputSeclectLH(ref ArrayLH, ref ArrayHH, stt, select, ChucNang);

                    }
                    else
                    {
                        select++;
                        Show.HienThiLH(ArrayLH, stt, select, top);
                        Show.inputSeclectLH(ref ArrayLH, ref ArrayHH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.Enter:
                    switch (ChucNang)
                    {
                        case "Delete LH":
                            Console.CursorVisible = false;
                            Delete.XoaHH(ref ArrayLH, ref ArrayHH, ChucNang, select);
                            return;
                        case "Edit LH":
                            Console.CursorVisible = true;
                            Console.Clear();
                            Edit.SuaHH(ref ArrayLH, ref ArrayHH, ChucNang, select, 1);
                            return;
                        case "Find LH":
                            Console.CursorVisible = true;
                            Form.FormCommonFind("Loại Hàng", select);
                            return;
                    }
                    return;
                case ConsoleKey.Escape:
                    Console.CursorVisible = false;
                    Tittle.TieuDe();
                    ArrayHH = Program.DuLieuMauHangHoa();
                    ArrayLH = Program.DuLieuMauLoaiHang();
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 7);
                    break;
                default:
                    Show.inputSeclectLH(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    break;
            }
        }
        //






















    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
namespace DoAn_NMLT_20880106
{
    public class Edit
    {


        // function main
        public static void SuaHangHoa(ref ArrayList ArrayHH, ref ArrayList ArrayLH)
        {
            //---back main
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 18;
            Console.WriteLine(" Lựa chọn [UP/DOWN] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 40;
            Console.WriteLine(" Select [ENTER] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 58;
            Console.WriteLine(" Home [ESC] ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            if (ArrayHH.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Kho hàng hóa của bạn đang trống.");
            }
            else
            {
                Show.HienThiHangHoa(ref ArrayHH, ref ArrayLH, "Edit HH");


            }

        }
        //
        static void FormEditItem(int selected, Struct.HOANGHOA item)
        {
            //-ten hang hoa-1
            if (selected == 1)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 4;
            Console.CursorLeft = 2;
            Console.WriteLine(item.TenHH);
            //-ma hang hoa-2
            if (selected == 2)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 8;
            Console.CursorLeft = 2;
            Console.WriteLine(item.MaHH);
            //han dung -ngay-3
            if (selected == 3)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 12;
            Console.CursorLeft = 10;
            Console.WriteLine(item.HanDung.Ngay);
            //han dung - thang-4
            if (selected == 4)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 12;
            Console.CursorLeft = 33;
            Console.WriteLine(item.HanDung.Thang);
            //han dung - nam-5
            if (selected == 5)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 12;
            Console.CursorLeft = 56;
            Console.WriteLine(item.HanDung.Nam);
            //cong ty san xuat-6
            if (selected == 6)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 16;
            Console.CursorLeft = 2;
            Console.WriteLine(item.CtySX);
            //nam san xuat-7
            if (selected == 7)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 20;
            Console.CursorLeft = 2;
            Console.WriteLine(item.NamSX);
            //loại hang hoa-8
            if (selected == 8)
            {
                BgSelected();
            }
            else
            {
                BgNormal();
            }
            Console.CursorTop = 24;
            Console.CursorLeft = 2;
            Console.WriteLine(item.LoaiHang);
            //------
        }
        // background edit selected
        static void BgSelected()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        static void BgNormal()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        //function second- hien thi item sua
        public static void SuaHH(ref ArrayList ArrayHH, ref ArrayList ArrayLH, string ChucNang, int index, int selected)
        {
            Struct.HOANGHOA item = (Struct.HOANGHOA)ArrayHH[index];
            Form.FormHangHoa("SỬA HÀNG HÓA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 18;
            Console.WriteLine(" Lựa chọn [UP/DOWN] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 40;
            Console.WriteLine(" Select [ENTER] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 58;
            Console.WriteLine(" Home [ESC] ");
            Console.CursorTop = 27;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Crt + S để lưu lại.");
            FormEditItem(selected, item);
            bool loop = true;
            while (loop)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if ((input.Modifiers & ConsoleModifiers.Control) != 0 && input.Key == ConsoleKey.S)
                {
                    bool flagSave;
                    flagSave = Form.FormXacNhan(10, 40, 5, 40, ChucNang);
                    if (flagSave)
                    {
                        loop = false;
                        ArrayHH.RemoveAt(index);
                        ArrayHH.Insert(index, item);
                        Console.Clear();
                        Edit.SuaHangHoa(ref ArrayHH, ref ArrayLH);
                        return;

                    } else
                    {
                        loop = false;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        SuaHH(ref ArrayHH, ref ArrayLH, ChucNang, index, selected);
                    }
                }
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selected == 1)
                        {
                            selected = 8;
                        }
                        else
                        {
                            selected--;

                        }
                        BgSelectedItem(selected, ref item);
                        break;
                    case ConsoleKey.DownArrow:
                        if (selected == 8)
                        {
                            selected = 1;
                        }
                        else
                        {
                            selected++;
                        }
                        BgSelectedItem(selected, ref item);
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        item = EditItem(selected, ref item);
                        selected++;
                        BgSelectedItem(selected, ref item);
                        break;
                    case ConsoleKey.Escape:
                        loop = false;
                        Console.CursorVisible = false;
                        Tittle.TieuDe();
                        Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 0);
                        break;
                    default:
                        break;
                }

            }



        }

        //---backgound select item- in lại item
        static void BgSelectedItem(int selected, ref Struct.HOANGHOA item)
        {
            switch (selected)
            {
                case 1:
                    BgSelected();
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.TenHH);
                    BgNormal();
                    Console.CursorTop = 24;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.LoaiHang);
                    BgNormal();
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MaHH);
                    break;
                case 2:
                    BgSelected();
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MaHH);
                    BgNormal();
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.TenHH);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 10;
                    Console.WriteLine(item.HanDung.Ngay);
                    break;
                case 3:
                    BgSelected();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 10;
                    Console.WriteLine(item.HanDung.Ngay);
                    BgNormal();
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MaHH);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 33;
                    Console.WriteLine(item.HanDung.Thang);
                    break;
                case 4:
                    BgSelected();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 33;
                    Console.WriteLine(item.HanDung.Thang);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 10;
                    Console.WriteLine(item.HanDung.Ngay);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 56;
                    Console.WriteLine(item.HanDung.Nam);
                    break;
                case 5:
                    BgSelected();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 56;
                    Console.WriteLine(item.HanDung.Nam);
                    BgNormal();
                    Console.CursorTop = 16;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.CtySX);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 33;
                    Console.WriteLine(item.HanDung.Thang);
                    break;
                case 6:
                    BgSelected();
                    Console.CursorTop = 16;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.CtySX);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 56;
                    Console.WriteLine(item.HanDung.Nam);
                    BgNormal();
                    Console.CursorTop = 20;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.NamSX);
                    break;
                case 7:
                    BgSelected();
                    Console.CursorTop = 20;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.NamSX);
                    BgNormal();
                    Console.CursorTop = 16;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.CtySX);
                    BgNormal();
                    Console.CursorTop = 24;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.LoaiHang);
                    break;
                case 8:
                    BgSelected();
                    Console.CursorTop = 24;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.LoaiHang);
                    BgNormal();
                    Console.CursorTop = 20;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.NamSX);
                    BgNormal();
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.TenHH);
                    break;

            }
            switch (selected)
            {
                case 1:
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    break;
                case 2:
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    break;
                case 3:
                    Console.CursorTop = 12;
                    Console.CursorLeft = 10;
                    break;
                case 4:
                    Console.CursorTop = 12;
                    Console.CursorLeft = 33;
                    break;
                case 5:
                    Console.CursorTop = 12;
                    Console.CursorLeft = 56;
                    break;
                case 6:
                    Console.CursorTop = 16;
                    Console.CursorLeft = 2;
                    break;
                case 7:
                    Console.CursorTop = 20;
                    Console.CursorLeft = 2;
                    break;
                case 8:
                    Console.CursorTop = 24;
                    Console.CursorLeft = 2;
                    break;


            }


        }



        //from sua
        static Struct.HOANGHOA EditItem(int index, ref Struct.HOANGHOA item)
        {

            switch (index)
            {
                case 1:
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine("                            ");
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    item.TenHH = InputEditString();
                    break;
                case 2:
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine("                            ");
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    item.MaHH = InputEditString();
                    break;
                case 3:
                    Console.CursorTop = 12;
                    Console.CursorLeft = 10;
                    Console.WriteLine("         ");
                    Console.CursorTop = 12;
                    Console.CursorLeft = 10;
                    item.HanDung.Ngay = InputEditInt(12, 10, "Ngày");
                    break;
                case 4:
                    Console.CursorTop = 12;
                    Console.CursorLeft = 33;
                    Console.WriteLine("        ");
                    Console.CursorTop = 12;
                    Console.CursorLeft = 33;
                    item.HanDung.Thang = InputEditInt(12, 33, "Tháng");
                    break;
                case 5:
                    Console.CursorTop = 12;
                    Console.CursorLeft = 56;
                    Console.WriteLine("       ");
                    Console.CursorTop = 12;
                    Console.CursorLeft = 56;
                    item.HanDung.Nam = InputEditInt(12, 56, "Năm");
                    break;
                case 6:
                    Console.CursorTop = 16;
                    Console.CursorLeft = 2;
                    Console.WriteLine("                            ");
                    Console.CursorTop = 16;
                    Console.CursorLeft = 2;
                    item.CtySX = InputEditString();
                    break;
                case 7:
                    Console.CursorTop = 20;
                    Console.CursorLeft = 2;
                    Console.WriteLine("                            ");
                    Console.CursorTop = 20;
                    Console.CursorLeft = 2;
                    item.NamSX = InputEditInt(20, 2, "Năm sản xuất");
                    break;
                case 8:
                    Console.CursorTop = 24;
                    Console.CursorLeft = 2;
                    Console.WriteLine("                            ");
                    Console.CursorTop = 24;
                    Console.CursorLeft = 2;
                    item.LoaiHang = InputEditString();
                    break;

            }
            return item;
        }

        // input edit
        static string InputEditString()
        {
            //Console.Write("w"); 
            string inputEdit = Console.ReadLine();
            return inputEdit;
        }
        static int InputEditInt(int top, int left, string note)
        {
            int inputEdit = 0;
            inputEdit = NhapInt(inputEdit, note, top, left);
            return inputEdit;
        }
        static int NhapInt(int intBN, string DoiTuong, int top, int left)
        {
            int flag = 1;
            for (; ; )
            {
                try
                {


                    Console.BackgroundColor = ConsoleColor.White;
                    intBN = int.Parse(Console.ReadLine());
                    Console.CursorLeft = 0;
                    Console.CursorTop = 27;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("                                                        ");
                    return intBN;

                }
                catch
                {
                    Console.CursorTop = top;
                    Console.CursorLeft = left;
                    if(left > 5) { 
                        Console.Write("         ");
                    } else
                    {
                        Console.Write("                                                       ");
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


    }
}

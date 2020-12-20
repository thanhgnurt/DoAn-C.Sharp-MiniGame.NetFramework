using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
namespace DoAn_NMLT_20880106
{
    public class EditLH
    {


        // function main
        public static void SuaLoaiHang(ref ArrayList ArrayHH, ref ArrayList ArrayLH, int index)
        {
            //---back main
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 15;
            Console.WriteLine("Lựa chọn [UP/DOWN]");
            Console.CursorTop = 0;
            Console.CursorLeft = 35;
            Console.WriteLine("Select [ENTER]");
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
                Show.HienThiLoaiHang(ref ArrayHH, ref ArrayLH, "Edit LH", index);


            }

        }
        //
      
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
       
        //---backgound select item- in lại item
        static void BgSelectedItem(int selected, ref Struct.LOAIHANG item)
        {
            switch (selected)
            {
                case 1:
                    BgSelected();
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MaLH);
                    BgNormal();
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.TenLH);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MotaLH);
                    break;
                case 2:
                    BgSelected();
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.TenLH);
                    BgNormal();
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MaLH);
                    BgNormal();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MotaLH);
                    break;
                case 3:
                    BgSelected();
                    Console.CursorTop = 12;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MotaLH);
                    BgNormal();
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.MaLH);
                    BgNormal();
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine(item.TenLH);
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
                    Console.CursorLeft = 2;
                    break;



            }


        }



        //from sua
        static Struct.LOAIHANG EditItem(int index, ref Struct.LOAIHANG item)
        {

            switch (index)
            {
                case 1:
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    Console.WriteLine("                            ");
                    Console.CursorTop = 4;
                    Console.CursorLeft = 2;
                    item.MaLH = InputEditString();
                    break;
                case 2:
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    Console.WriteLine("                            ");
                    Console.CursorTop = 8;
                    Console.CursorLeft = 2;
                    item.TenLH = InputEditString();
                    break;
                case 3:
                    Console.CursorTop = 12;
                    Console.CursorLeft = 2;
                    Console.WriteLine("         ");
                    Console.CursorTop = 12;
                    Console.CursorLeft = 2;
                    item.MotaLH = InputEditString();
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

  
        //
        public static void SuaLH(ref ArrayList ArrayLH, ref ArrayList ArrayHH, string ChucNang, int index, int selected)
        {
            Struct.LOAIHANG item = (Struct.LOAIHANG)ArrayLH[index];
            Form.FormLoaiHang("SỬA LOẠI HÀNG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 20;
            Console.WriteLine("Lựa chọn [UP/DOWN]");
            Console.CursorTop = 0;
            Console.CursorLeft = 40;
            Console.WriteLine("Select [ENTER]");
            Console.CursorTop = 0;
            Console.CursorLeft = 58;
            Console.WriteLine("Home [ESC]");

            Console.CursorTop = 27;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Crt + S để lưu lại.");
            FormEditItemLH(selected, item);
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
                        ArrayLH.RemoveAt(index);
                        ArrayLH.Insert(index, item);
                        Console.Clear();
                        SuaLoaiHang(ref ArrayLH, ref ArrayHH,index);
                        return;

                    }
                    else
                    {
                        loop = false;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        SuaLH(ref ArrayLH, ref ArrayHH, ChucNang, index, selected);
                    }
                }
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selected == 1)
                        {
                            selected = 3;
                        }
                        else
                        {
                            selected--;

                        }
                       BgSelectedItem(selected, ref item);
                        break;
                    case ConsoleKey.DownArrow:
                        if (selected == 3)
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


        //
        static void FormEditItemLH(int selected, Struct.LOAIHANG item)
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
            Console.WriteLine(item.MaLH);
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
            Console.WriteLine(item.TenLH);
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
            Console.CursorLeft = 2;
            Console.WriteLine(item.MotaLH);
            //han dung - thang-4
     
            //------
        }






    }
}

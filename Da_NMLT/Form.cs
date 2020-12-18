using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Form
    {
        public static void FormHangHoa(string tittle)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.WriteLine(" {0} |", tittle);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Add.InputHH(1, 2, "Mã hàng hóa:");
            Add.InputHH(2, 2, "Tên hàng hóa:");
            int top = 3;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Add.InputHH(4, 2, "Công ty sản xuất:                               ");
            Add.InputHH(5, 1, "Năm xản xuât");
            Console.CursorLeft = 2;
            Add.InputHH(6, 2, "Loại hàng hóa:      ");
            //SP.LoaiHang = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorTop = top * 4 - 2;
            Console.CursorLeft = 1;
            Console.WriteLine("Hạn sử dụng:");
            Console.CursorTop = top * 4 - 1;
            Console.CursorLeft = 2;
            Console.WriteLine("Ngày:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = top * 4 - 1;
            Console.CursorLeft = 8;
            Console.WriteLine("-------------");
            Console.CursorLeft = 8;
            Console.WriteLine("             ");
            Console.CursorLeft = 8;
            Console.WriteLine("             ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = 9;
            // ngay
            Console.CursorTop = top * 4 - 1;
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
            // thang 
            Console.CursorTop = top * 4 - 1;
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
            // nam 
        }


        public static void FormLoaiHang(string Tittle)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.WriteLine("{0} |", Tittle);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Add.InputHH(1, 2, "Hãy nhập mã loại hàng:");
            Add.InputHH(2, 2, "Hãy nhập tên loại hóa");
            Add.InputHH(3, 2, "Mô tả về loại hàng:                              ");

        }
        //form xac nhan yes/no
        public static void YesNoSelected(int cot, int top, int left, bool flag)
        {
            if (flag)
            {

                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
                Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorTop = top + 5;
            Console.CursorLeft = left + 5;
            Console.Write("          ");
            Console.CursorTop = top + 6;
            Console.CursorLeft = left + 5;
            Console.Write("   YES    ");
            Console.CursorTop = top + 7;
            Console.CursorLeft = left + 5;
            Console.Write("          ");
            //
            if (!flag)
            {

                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
                Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorTop = top + 5;
            Console.CursorLeft = cot + left - 15;
            Console.Write("          ");
            Console.CursorTop = top + 6;
            Console.CursorLeft = cot + left - 15;
            Console.Write("    NO    ");
            Console.CursorTop = top + 7;
            Console.CursorLeft = cot + left - 15;
            Console.Write("          ");
        }
        public static bool FormXacNhan(int hang, int cot, int top, int left, string ChucNang)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            string blank = " ";
            string boder = "|";

            for (int i=1; i < hang; i++)
            {
                
                if (i==1||i==2 || i==3)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;

                } else
                {
                    Console.BackgroundColor = ConsoleColor.White;

                }
                
                Console.CursorTop = top+i-1;
                Console.CursorLeft = left-1;
                Console.Write(boder);
                for(int j=1; j< cot; j++)
                {
                    
                    Console.CursorTop = top+i-1;
                    Console.CursorLeft = left+j-1;
                    Console.Write(blank);
                    
                }
                Console.Write(boder);
                Console.WriteLine();
               
            }
            Console.CursorTop = top + 1;
            Console.CursorLeft = left + 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Do you want to {0}?", ChucNang);
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Để thoát chon ESC");

            //

            bool flag = true;
            //
            YesNoSelected(cot, top, left, flag);

            //
            while (true)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.LeftArrow:
                        flag = true;
                        YesNoSelected(cot, top, left, flag);
                        break;
                    case ConsoleKey.RightArrow:
                        flag = false;
                        YesNoSelected(cot, top, left, flag);
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = false;
                        return flag;
                    case ConsoleKey.Escape:
                        Console.CursorVisible = false;
                        Console.CursorVisible = false;
                        Program.AppMain();
                        return false;
                }
            }


        }

        //form tim kiem
        public static void FormTimKiem(string Tittle)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.WriteLine("{0}  |", Tittle);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Add.InputHH(1, 2, "Nhập từ khóa tìm kiếm....");

        }
        // form propestise find
        public static void FormCommonFind(string Tittle, int index)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            string blank = " ";
            string boder = "|";
            int hang = 10;
            int cot = 25;
            int left = 40;
            int top = 5;

            for (int i = 1; i < hang; i++)
            {

                if (i == 1 || i == 2 || i == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;

                }

                Console.CursorTop = top + i - 1;
                Console.CursorLeft = left - 1;
                Console.Write(boder);
                for (int j = 1; j < cot; j++)
                {

                    Console.CursorTop = top + i - 1;
                    Console.CursorLeft = left + j - 1;
                    Console.Write(blank);

                }
                Console.Write(boder);
                Console.WriteLine();

            }
            Console.CursorTop = top + 1;
            Console.CursorLeft = left + 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write("{0}?", Tittle);
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Để thoát chon ESC");

            // chuc năng trong tim kiem
            Arch_HH(1);
            ArrayList ArrayHH = Program.DuLieuMauHangHoa();
            ArrayList ArrayLH = Program.DuLieuMauLoaiHang();
            int selected = OptionFind();
            if (Tittle=="Hàng Hóa")
            {
                if (selected == 1)
                {
                    //sửa
                    Console.Clear();
                    Edit.SuaHH(ref ArrayHH, ref ArrayLH, "Edit HH", selected, 1);
                }
                if (selected == 2)
                {
                    //xóa
                    Console.Clear();
                    Delete.XoaHH(ref ArrayHH, ref ArrayLH, "Delete HH", selected);
                }
                if (selected == -1)
                {
                    //back main
                    Program.AppMain();
                }
            }
            if (Tittle=="Loại Hàng")
            {
                if (selected == 1)
                {
                    //sửa
                    Console.Clear();
                    EditLH.SuaLH(ref ArrayLH, ref ArrayHH, "Edit HH", selected, 1);
                }
                if (selected == 2)
                {
                    //xóa
                    Console.Clear();
                    DeleteLH.XoaLH(ref ArrayLH, ref ArrayHH, "Delete HH", selected,1);
                }
                if (selected == -1)
                {
                    //back main
                    Program.AppMain();
                }
            }

           
            // lựa chon chưc nang
           
        }
        //Lua chon 2 option sử dung top dowwn
        static int OptionFind()
        {
            int flag = 1;
            while (true)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.DownArrow:
                        flag = 2;
                        Arch_HH(flag);
                        break;
                    case ConsoleKey.UpArrow:
                        flag = 1;
                        Arch_HH(flag);
                        break;
                    case ConsoleKey.Enter:
                        return flag;
                    case ConsoleKey.Escape:
                        return -1;
                }
            }
      
        }

        static void WriteBlank(int quality, string name)
        {
            name = name.Trim();
            if (name == "")
            {

                for(int i = 0; i< quality-1; i++)
                {
                    Console.Write(" ");
                }
            } else
            {
                int lengthName = name.Length;
                for (int i = 0; i< quality-lengthName; i++)
                {
                    if ( i== (quality - lengthName) / 2)
                    {
                        Console.Write(name);
                    } else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        // thuộc tính trong tim kiem
        public static void Arch_HH(int flag)
        {
            int cot = 25;
            int left = 40;
            int top = 5;
            if (flag == 1)
            {

                Console.BackgroundColor = ConsoleColor.Blue;

            }
            else
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorTop = top + 3;
                Console.CursorLeft = left;
                WriteBlank(cot, "");
                Console.CursorTop = top + 4;
                Console.CursorLeft = left;
                WriteBlank(cot, "Sửa");
                Console.CursorTop = top + 5;
                Console.CursorLeft = left;
                WriteBlank(cot, "");

           

            //
            if (flag == 2)
            {

                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
                Console.BackgroundColor = ConsoleColor.Gray;

                Console.CursorTop = top + 6;
                Console.CursorLeft = left;
                WriteBlank(cot, "");
                Console.CursorTop = top + 7;
                Console.CursorLeft = left;
                WriteBlank(cot, "Xóa");
                Console.CursorTop = top + 8;
                Console.CursorLeft = left;
                WriteBlank(cot, "");

            //



        }
        //from chuc nang trong tim kiem

 


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Select
    {
        //----điều hướng 
        static void DieuHuong(int select, ref ArrayList ArrayHH, ref ArrayList ArrayLH)
        {
            switch (select)
            {
                case 0:
                    Add.ThemHangHoa(ref ArrayHH, ref ArrayLH);
                    return;
                case 1:
                    Console.CursorVisible = false;
                    Edit.SuaHangHoa(ref ArrayHH, ref ArrayLH);
                    return;
                case 2:
                    Console.CursorVisible = false;
                    Delete.XoaHangHoa(ref ArrayHH, ref ArrayLH);
                    return;
                case 3:
                    Find.TimKiemHangHoa(ArrayHH, ArrayLH);
                    return;
                case 4:
                    AddLH.ThemLoaiHang(ref ArrayLH, ref ArrayHH);
                    return;
                case 5:
                    Console.CursorVisible = false;
                    EditLH.SuaLoaiHang(ref ArrayLH, ref ArrayHH, 0);
                    return;
                case 6:
                    Console.CursorVisible = false;
                    DeleteLH.XoaLoaiHang(ref ArrayLH, ref ArrayHH, 0);
                    return;
                case 7:
                    FindLH.TimKiemLoaiHang(ArrayLH, ArrayHH);
                    return;
                case 8:
                    Console.CursorVisible = false;
                    //Caculator.PageMainCacu();
                    FappyBird.FontGameFB();
                   
                    return;
                case 9:
                    Console.CursorVisible = false;
                    MiniGame.SelectLevelGame();
                    return;
                case 10:
                    Console.CursorVisible = false;
                    About.Information();
                    return;
                case 11:
                    Console.CursorVisible = false;
                    Console.Clear();
                    return;
            }

        }

        //---thoongg báo  trạng thái
        static void ThongBaoTrangThai(int index, string[] Menus)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = 100;
            Console.CursorTop = 0;
            Console.WriteLine(Menus[index]);
        }
    
        // thực đơn chính
        static void ThucDonChinh(int luaChon, string[] ThucDon)
        {
           
            int topRow1 = 7;
            int topRow2 = topRow1;
            int topRow3 = topRow1;
            Console.CursorTop = topRow1;
            for (int i=0;i< ThucDon.Length; i++)
            {
                int left = 30;
                if (i > 3 && i<=7)
                {
                    left = 50;
                    Console.CursorTop = topRow2;
                    topRow2 += 5;

                }
                if (i > 7)
                {
                    left = 70;
                    Console.CursorTop = topRow3;
                    topRow3 += 5;

                }

                if (luaChon == i)
                {
                    Console.CursorLeft = left;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.CursorLeft = left;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("   ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.WriteLine("                |");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorLeft = left;
                    Console.WriteLine(ThucDon[i]);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorLeft = left;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("                ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("   |");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.CursorLeft = left;
                    Console.WriteLine("___________________|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                } else
                {
                   // Console.BackgroundColor = ConsoleColor.Green;
                    
                         switch (i) {
                             case 0: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                             case 1: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                             case 2: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                             case 3: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                             case 4: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                             case 5: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                             case 6: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                             case 7: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                             case 8: Console.BackgroundColor = ConsoleColor.Magenta; break;
                             case 9: Console.BackgroundColor = ConsoleColor.Magenta; break;
                             case 10: Console.BackgroundColor = ConsoleColor.Magenta; break;
                             case 11: Console.BackgroundColor = ConsoleColor.Magenta; break;
                            
                         }
                    
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine(ThucDon[i]);
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine("___________________|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

        }
        public static void LuaChonChinh(ref ArrayList ArrayHH, ref ArrayList ArrayLH, int select)
        {
            
            string ThemHangHoa = " Thêm hàng hóa     |";
            string SuaHangHoa = " Sửa hàng hóa      |";
            string XoaHangHoa = " Xóa hàng hóa      |";
            string TimKiemHangHoa = " Tìm kiếm hàng hóa |";
            string ThemLoaiHang = " Thêm Loại Hàng    |";
            string SuaLoaiHang = " Sửa Loại Hàng     |";
            string XoaLoaiHang = " Xóa Loại Hàng     |";
            string TimKiemLoaiHang = " Tìm Kiếm Loại Hàng|";
            string KhoHang = " Game Fappy Brid   |";
            string Game = " Game Snake        |";
            string About = " About             |";
            string Thoat = " Thoat(ESC)        |";
            string[] ThucDon = new string[12] { ThemHangHoa,SuaHangHoa,XoaHangHoa,TimKiemHangHoa,
                ThemLoaiHang, SuaLoaiHang, XoaLoaiHang, TimKiemLoaiHang, KhoHang, Game, About, Thoat};
            //Tittle.TieuDe();
            ThongBaoTrangThai(select, ThucDon);
            ThucDonChinh(select, ThucDon);
            Console.CursorTop = 0;
            Console.CursorLeft = 1;
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            switch (input.Key)
                {
                case ConsoleKey.DownArrow:
                    if (select == ThucDon.Length-1)
                    {
                        LuaChonChinh(ref ArrayHH,ref ArrayLH, select);
                                

                    } else
                    {
                        select++;
                        LuaChonChinh(ref ArrayHH,ref ArrayLH, select);

                    }
                    return;
                case ConsoleKey.UpArrow:
                    if (select == 0)
                    {
                        LuaChonChinh(ref ArrayHH, ref ArrayLH, select);
                    } else
                    {
                        select--;
                        LuaChonChinh(ref ArrayHH, ref ArrayLH, select);
                    }
                    return;
                case ConsoleKey.RightArrow:
                    if (select <ThucDon.Length-4)
                    {
                        select += 4;
                        LuaChonChinh(ref ArrayHH, ref ArrayLH, select);

                    } else
                    {
                        LuaChonChinh(ref ArrayHH, ref ArrayLH, select);
                    }

                    return;
                case ConsoleKey.LeftArrow:
                    if (select >=4)
                    {
                        select -= 4;
                        LuaChonChinh(ref ArrayHH, ref ArrayLH, select);

                    }
                    else
                    {
                        LuaChonChinh(ref ArrayHH, ref ArrayLH, select);
                    }
                    return;
                case ConsoleKey.Enter:
                    Console.CursorVisible = false;
                    Console.CursorVisible = true;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;      
                    Console.Clear();
                    DieuHuong(select, ref ArrayHH, ref ArrayLH);
                    return;
                case ConsoleKey.Escape:
                    Console.Clear();
                    return;
                default:
                    Console.CursorVisible = false;
                    Program.AppMain();
                    return;
                }

       
        }
    }
}

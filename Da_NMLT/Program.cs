using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public class Program
    {
        //tạo dữ liễu mẫu
    

        public static ArrayList DuLieuMauHangHoa()
        {
            ArrayList ArraySP = new ArrayList();
            Struct.HOANGHOA hh1, hh2, hh3, hh4;
            //hang hoa 1
            hh1.MaHH = "4215";
            hh1.TenHH = "Galaxy note p20";
            hh1.HanDung.Ngay = 20;
            hh1.HanDung.Thang = 5;
            hh1.HanDung.Nam = 2025;
            hh1.NamSX = 2019;
            hh1.CtySX = "SamSung";
            hh1.LoaiHang = "Điện tử";
            //hang hóa 2
            hh2.MaHH = "1256";
            hh2.TenHH = "Nước khoáng Aquafina";
            hh2.HanDung.Ngay = 15;
            hh2.HanDung.Thang = 5;
            hh2.HanDung.Nam = 2023;
            hh2.NamSX = 2019;
            hh2.CtySX = "Pepsi";
            hh2.LoaiHang = "Đồ uống";
            //hang hoa 3
            hh3.MaHH = "g125";
            hh3.TenHH = "Iphone";
            hh3.HanDung.Ngay = 05;
            hh3.HanDung.Thang = 07;
            hh3.HanDung.Nam = 2030;
            hh3.NamSX = 2020;
            hh3.CtySX = "Apple";
            hh3.LoaiHang = "Điện tử";
            //hang hoa 4
            hh4.MaHH = "M125";
            hh4.TenHH = "Rượu vang";
            hh4.HanDung.Ngay = 10;
            hh4.HanDung.Thang = 02;
            hh4.HanDung.Nam = 2023;
            hh4.NamSX = 2019;
            hh4.CtySX = "ABC";
            hh4.LoaiHang = "Đồ uống có cồn";
            //
            ArraySP.Add(hh1);
            ArraySP.Add(hh2);
            ArraySP.Add(hh3);
            ArraySP.Add(hh4);

            return ArraySP;

        }

        public static ArrayList DuLieuMauLoaiHang()
        {
            ArrayList ArrayLH = new ArrayList();
            Struct.LOAIHANG lh1, lh2, lh3, lh4;
            //hang hoa 1
            lh1.MaLH = "T125";
            lh1.TenLH = "Thực phẩm";
            lh1.MotaLH = "";
            //hang hóa 2
            lh2.MaLH = "D127";
            lh2.TenLH = "Điện Tử";
            lh2.MotaLH = "";
            //hang hoa 3
            lh3.MaLH = "Q128";
            lh3.TenLH = "Đồ uống có cồn";
            lh3.MotaLH = "";
            //hang hoa 4
            lh4.MaLH = "T125";
            lh4.TenLH = "Đồ uống";
            lh4.MotaLH = "";
            //
            ArrayLH.Add(lh1);
            ArrayLH.Add(lh2);
            ArrayLH.Add(lh3);
            ArrayLH.Add(lh4);
            return ArrayLH;

        }


        public static void AppMain() {
            Console.CursorVisible = false;
            ArrayList ArrayHH = DuLieuMauHangHoa();
            ArrayList ArrayLH = DuLieuMauLoaiHang();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Tittle.TieuDe();
            Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 0);
        }



        //----------------------------------------------Main------------------------------------
        public static void Main(string[] args)
        {
            AppMain();

        }
    }
}

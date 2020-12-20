using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class Caculator
    {
        public static void PageMainCacu()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("Bảng tính đang được cập nhật.......");
            Console.CursorTop = 7;
            Console.CursorLeft = 40;
            Console.WriteLine("Home [ESC]");

            bool loop = true;
            while (loop)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    loop = false;

                }
            }
            Console.Clear();
            Console.CursorVisible = false;
            Program.AppMain();

        }
    }
}

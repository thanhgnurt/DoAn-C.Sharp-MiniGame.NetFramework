using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public class FappyBird
    {
        public static int hightBird = 14;
        public static bool evenSpace = false;
        public static POINT[] pointBir = new POINT[2];
        public static int score = 0;
        public static bool gameOver = false;
        public static bool deleteShadow = true;
        public static int speedGame = 100;
        public static bool shadowOnChimney = false;
        public struct POINT
        {
            public int X;
            public int Y;

        }
        public  static void FontGameFB()
        {
            gameOver = false;
            score = 0;
            deleteShadow = true;
            hightBird = 14;
            pointBir = FappyBirdBird.pointBird();
            Console.BackgroundColor = ConsoleColor.Blue;
            FloorCeilingFB();
            PrintScore();
            Thread t1 = new Thread(FappyBirdChimneys.FappyBrid);
            Thread t2 = new Thread(()=>FappyBirdBird.ListenKey(true));
            FloorCeiling.MoveFloor(3);
            FloorCeiling.MoveCeiling(3);
            t1.Start(); 
            t2.Start();
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Fly Up [SPACEBAR] ");
            t1.Join();
            t2.Join();

            
            
        }

        
        //-- nền và trần game
        public static void FloorCeilingFB()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            int top = 2;
            int bottom = 26;
            int maxWidth = 120;
            Console.Clear();
            for (int i = 0; i< maxWidth; i++ )
            {

                for (int j = top; j <= bottom; j++)
                {
                    if (j!= top || j != bottom)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }

                }
            }
        }

        //--- print---
        public static void PrintScore()
        {
            Console.SetCursorPosition(55, 0);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" SCORE : "+ score+" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        //----Game over----
        public static void GameOverFB()
        {
            gameOver = true;
            speedGame = 100;
            score = 0;
            int g = 12;
            int a = 23;
            int m = 36;
            //
            int o = 57;
            int v = 69;
            int e = 82;
            int r = 92;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(g, 9);
            Console.WriteLine("              "); Console.SetCursorPosition(g, 10);
            Console.WriteLine("   ########   "); Console.SetCursorPosition(g, 11);
            Console.WriteLine("   #      #   "); Console.SetCursorPosition(g, 12);
            Console.WriteLine("   #          "); Console.SetCursorPosition(g, 13);
            Console.WriteLine("   #    ####  "); Console.SetCursorPosition(g, 14);
            Console.WriteLine("   #      #   "); Console.SetCursorPosition(g, 15);
            Console.WriteLine("   ########   "); Console.SetCursorPosition(g, 16);
            Console.WriteLine("              "); Console.SetCursorPosition(a, 9);
            //
            Console.WriteLine("               "); Console.SetCursorPosition(a, 10);
            Console.WriteLine("       #       "); Console.SetCursorPosition(a, 11);
            Console.WriteLine("      # #      "); Console.SetCursorPosition(a, 12);
            Console.WriteLine("     #   #     "); Console.SetCursorPosition(a, 13);
            Console.WriteLine("    #######    "); Console.SetCursorPosition(a, 14);
            Console.WriteLine("   #       #   "); Console.SetCursorPosition(a, 15);
            Console.WriteLine("  #         #  "); Console.SetCursorPosition(a, 16);
            Console.WriteLine("               "); Console.SetCursorPosition(m, 9);
            //
            Console.WriteLine("            "); Console.SetCursorPosition(m, 10);
            Console.WriteLine(" #       #  "); Console.SetCursorPosition(m, 11);
            Console.WriteLine(" # #   # #  "); Console.SetCursorPosition(m, 12);
            Console.WriteLine(" #   #   #  "); Console.SetCursorPosition(m, 13);
            Console.WriteLine(" #       #  "); Console.SetCursorPosition(m, 14);
            Console.WriteLine(" #       #  "); Console.SetCursorPosition(m, 15);
            Console.WriteLine(" #       #  "); Console.SetCursorPosition(m, 16);
            Console.WriteLine("            "); Console.SetCursorPosition(o-9, 9);
            //
            Console.WriteLine("         "); Console.SetCursorPosition(o - 9, 10);
            Console.WriteLine("         "); Console.SetCursorPosition(o - 9, 11);
            Console.WriteLine("         "); Console.SetCursorPosition(o - 9, 12);
            Console.WriteLine("         "); Console.SetCursorPosition(o - 9, 13);
            Console.WriteLine("         "); Console.SetCursorPosition(o - 9, 14);
            Console.WriteLine("         "); Console.SetCursorPosition(o - 9, 15);
            Console.WriteLine("         "); Console.SetCursorPosition(o - 9, 16);
            Console.WriteLine("         "); Console.SetCursorPosition(o, 9);
            //
            Console.WriteLine("              "); Console.SetCursorPosition(o, 10);
            Console.WriteLine("   ########   "); Console.SetCursorPosition(o, 11);
            Console.WriteLine("  #        #  "); Console.SetCursorPosition(o, 12);
            Console.WriteLine("  #        #  "); Console.SetCursorPosition(o, 13);
            Console.WriteLine("  #        #  "); Console.SetCursorPosition(o, 14);
            Console.WriteLine("  #        #  "); Console.SetCursorPosition(o, 15);
            Console.WriteLine("   ########   "); Console.SetCursorPosition(o, 16);
            Console.WriteLine("              "); Console.SetCursorPosition(v,9);
            //
            Console.WriteLine("               "); Console.SetCursorPosition(v, 10);
            Console.WriteLine("  #         #  "); Console.SetCursorPosition(v, 11);
            Console.WriteLine("   #       #   "); Console.SetCursorPosition(v, 12);
            Console.WriteLine("    #     #    "); Console.SetCursorPosition(v, 13);
            Console.WriteLine("     #   #     "); Console.SetCursorPosition(v, 14);
            Console.WriteLine("      # #      "); Console.SetCursorPosition(v, 15);
            Console.WriteLine("       #       "); Console.SetCursorPosition(v, 16);
            Console.WriteLine("               "); Console.SetCursorPosition(e, 9);
            //
            Console.WriteLine("           "); Console.SetCursorPosition(e, 10);
            Console.WriteLine(" ########  "); Console.SetCursorPosition(e, 11);
            Console.WriteLine(" #         "); Console.SetCursorPosition(e, 12);
            Console.WriteLine(" #         "); Console.SetCursorPosition(e, 13);
            Console.WriteLine(" ########  "); Console.SetCursorPosition(e, 14);
            Console.WriteLine(" #         "); Console.SetCursorPosition(e, 15);
            Console.WriteLine(" ########  "); Console.SetCursorPosition(e, 16);
            Console.WriteLine("           "); Console.SetCursorPosition(r, 9);
            //
            Console.WriteLine("              "); Console.SetCursorPosition(r, 10);
            Console.WriteLine("  ########    "); Console.SetCursorPosition(r, 11);
            Console.WriteLine("  #      #    "); Console.SetCursorPosition(r, 12);
            Console.WriteLine("  #      #    "); Console.SetCursorPosition(r, 13);
            Console.WriteLine("  ########    "); Console.SetCursorPosition(r, 14);
            Console.WriteLine("  # #         "); Console.SetCursorPosition(r, 15);
            Console.WriteLine("  #  ###      "); Console.SetCursorPosition(r, 16);
            Console.WriteLine("              "); Console.SetCursorPosition(r + 10, 15);
            Console.WriteLine(" R ");
            //---dieu huong
            Console.SetCursorPosition(17, 45);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_____________________");
            Console.CursorTop = 19;
            Console.CursorLeft = 45;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Play again  [ Double ENTER] ");
            Console.CursorTop = 20;
            Console.CursorLeft = 45;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Home           [Double ESC] ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            bool loop = true;
            while (loop)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.Escape:
                        Console.CursorVisible = false;
                        Console.Clear();
                        Program.AppMain();
                        return;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = false;
                        Console.Clear();
                        FontGameFB();
                        return;
                    default:
                        break;
                }

            }


        }
















    }
}

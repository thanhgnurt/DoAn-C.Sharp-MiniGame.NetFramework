using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class MiniGameOver
    {
        //Check collision
        public static bool CheckCollision(Struct.DIEM point)
        {

            if (point.x < 40 || point.x>90)
            {
                return true;
            }
            if(point.y < 2 || point.y > 27)
            {
                return true;
            }
            return false;

        }
        // check collision trailer
        public static bool CheckCollisionTrailer(List<Struct.DIEM> Snake, Struct.DIEM pointHeader)
        {
            List<Struct.DIEM> SnakeTrailer = new List<Struct.DIEM>();
            for (int i = 1; i< Snake.Count; i++)
            {
                SnakeTrailer.Add(Snake[i]);
            }

            int inS = SnakeTrailer.IndexOf(pointHeader);
            if (inS > 0)
            {
                return true;
            }
            else
                return false;
        }
        //Kiem tra an moi
        public static bool CheckEat(Struct.DIEM pointHeader, Struct.DIEM pointFood)
        {
            if (pointHeader.x==pointFood.x && pointHeader.y==pointFood.y)
            {
                Console.SetCursorPosition(pointHeader.x, pointHeader.y);
                Console.Write("X");
                return true;
            }
            return false;
        }
        //Game over
        public static void GameOver(int score)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("GAME OVER");
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Score: {0}", score);
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("__________________");

        }



    }
}

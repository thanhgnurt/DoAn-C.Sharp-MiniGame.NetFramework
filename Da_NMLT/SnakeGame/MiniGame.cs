using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class MiniGame
    {
        // countdown---
        public static void CountDown()
        {

        }
        //--select level game
        public static void SelectLevelGame()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.CursorTop = 0;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" Select [ENTER] ");
            Console.CursorTop = 0;
            Console.CursorLeft = 20;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" Home [ESC] ");
            Console.CursorTop = 4; 
            Console.CursorLeft = 50;
            Console.WriteLine("GAME SNAKE");
            Console.CursorTop = 5;
            Console.CursorLeft = 50;
            Console.WriteLine("_____________________");

            int selectLevel = 1;
            bool loop = true;
            string[] level = new string[10];
            for (int i = 0; i<10; i++)
            {
                level[i] = "Level " + (i+1);
            }
            for(int i = 0; i< level.Length; i++)
            {
                if(i == selectLevel - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.CursorTop = 7+i;
                Console.CursorLeft = 50;
                Console.WriteLine(level[i]);
            }
           
            while (loop)
            {


                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.Escape:
                        Console.CursorVisible = true;
                        selectLevel = -1;
                        loop = false;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.CursorTop = 6 + selectLevel;
                        Console.CursorLeft = 50;
                        Console.WriteLine(level[selectLevel - 1]);
                        if (selectLevel == 1)
                        {
                            selectLevel = 10;
                        } else
                        {
                            selectLevel--;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.CursorTop = 6 + selectLevel;
                        Console.CursorLeft = 50;
                        Console.WriteLine(level[selectLevel-1]);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.CursorTop = 6 + selectLevel;
                        Console.CursorLeft = 50;
                        Console.WriteLine(level[selectLevel - 1]);
                        if (selectLevel == 10)
                        {
                            selectLevel = 1;
                        }
                        else
                        {
                            selectLevel++;
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.CursorTop = 6 + selectLevel;
                        Console.CursorLeft = 50;
                        Console.WriteLine(level[selectLevel - 1]);
                        
                        break;
                    case ConsoleKey.Enter:
                        loop = false;
                        break;

                }
            }
            if (selectLevel == -1)
            {
                Program.AppMain();
            }
            if (selectLevel>0)
            {
                KhungGame(selectLevel);
            }


        }

        //khung game
        public static void KhungGame(int level)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Struct.DIEM TopLeft;
            TopLeft.x = 40;
            TopLeft.y = 2;
            Struct.DIEM TopRight;
            TopRight.x = 90;
            TopRight.y = TopLeft.y;
            Struct.DIEM BottomLeft;
            BottomLeft.x = TopLeft.x;
            BottomLeft.y = 27;
            Struct.DIEM BottomRight;
            BottomRight.x = TopRight.x;
            BottomRight.y = BottomLeft.y;
            List<Struct.DIEM> Snake = new List<Struct.DIEM>();
            Console.SetCursorPosition(20, 2);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" Score ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("   0   ");
            for (int i = TopLeft.y; i<= BottomLeft.y; i++)
            {
                
                
                for (int j = TopLeft.x; j<= TopRight.x; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" ");
                }
                Console.WriteLine("");


            }
            //--countdown
            var startTime = DateTime.UtcNow;
            bool loop = true;
            int count = 4;
            while (loop)
            {
                if (DateTime.UtcNow - startTime > TimeSpan.FromMilliseconds(2500))
                {
                    loop = false;
                }
                if(DateTime.UtcNow - startTime > TimeSpan.FromMilliseconds(500* (5-count)))
                {
                    Console.CursorTop = 8;
                    Console.CursorLeft = 65;
                    if(count == 0)
                    {
                        Console.Write(" ");
                    } else
                    {

                        Console.Write(count);
                    }
                    count--;
                }



            }
            if (!loop)
            {
                SnakePaint(level);
            }




        }


        //Check Collision

        // fragment snake
        static void FragmentSnake(Struct.DIEM point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write("O");
        }
        //---eating
        static void HeaderSnakeEatting(Struct.DIEM point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write("@");
        }
        //--Header snake
        static void HeaderSnake(Struct.DIEM point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write("X");
        }
        //---Delete trailer snake
        static void DeleteTrailerSnake(Struct.DIEM point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write(" ");
        }
        //random point panit
        static void RandomPointPanit(Struct.DIEM point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write("$");
        }
        // --- snake paint---
        static void SnakePaint(int level)
        {
            Struct.DIEM randomPoint;
            int score = 0;
            randomPoint.x = 0;
            randomPoint.y = 0;
            bool checkEat = true;
            List<Struct.DIEM> Snake = new List<Struct.DIEM>();
            Struct.DIEM Diem1;
            Diem1.x = 65;
            Diem1.y = 13;
            Struct.DIEM Diem2;
            Diem2.x = 65;
            Diem2.y = 14;
            Struct.DIEM Diem3;
            Diem3.x = 65;
            Diem3.y = 15;
            Struct.DIEM Diem4;
            Diem4.x = 65;
            Diem4.y = 16;
            Struct.DIEM Diem5;
            Diem5.x = 65;
            Diem5.y = 17;
            Struct.DIEM Diem6;
            Diem6.x = 65;
            Diem6.y = 18;
            Struct.DIEM Diem7; 
            Diem7.x = 65;
            Diem7.y = 19;
            Struct.DIEM Diem8;
            Diem8.x = 65;
            Diem8.y = 20;
            Snake.Add(Diem1);
            Snake.Add(Diem2);
            Snake.Add(Diem3);
           // Snake.Add(Diem4);
           // Snake.Add(Diem5);
           // Snake.Add(Diem6);
           // Snake.Add(Diem7);
           // Snake.Add(Diem8);

            for (int i =0; i< Snake.Count; i++)
            {
                FragmentSnake(Snake[i]);
            }
            
            string DirectionSnake = "UpArrow";
            bool loop = true;
            while (loop)
            {
                DirectionSnake = ControlSnake(level,Snake, DirectionSnake,ref randomPoint, ref checkEat, ref score);
                if (DirectionSnake == "GAMEOVER")
                {
                    loop = false;
                }
                if (DirectionSnake == "Escape")
                {
                    loop = false;
                    SelectLevelGame();
                }
            }
            Console.CursorTop = 8;
            Console.CursorLeft = 50;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Play again [ENTER]");
            Console.CursorTop = 9;
            Console.CursorLeft = 50;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Home [ESC]");
            loop = true;
            while (loop)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.Escape:
                        loop = false;
                        Console.CursorVisible = false;
                        Console.Clear();
                        Program.AppMain();
                        break;
                    case ConsoleKey.Enter:
                        loop = false;
                        Console.CursorVisible = false;
                        Console.Clear();
                        SelectLevelGame();
                        break;
                    default:
                        break;
                }

            }

        }

        // control snake 
        static string ControlSnake(int level,List<Struct.DIEM> Snake, string DirectionSnake, ref Struct.DIEM randomPoint, ref bool checkEat, ref int score)
        {
            Random randomXY = new Random();
            Struct.DIEM oldFood;
            oldFood.x = 0;
            oldFood.y = 0;
            ConsoleKeyInfo input;
            var startTime = DateTime.UtcNow;
            int count = 1;
            bool check = true;
            level = (11-level) * 25;
            int stage = randomXY.Next(6, 12);
            do
            {
                while (!Console.KeyAvailable)
                {
                    if (DateTime.UtcNow - startTime > TimeSpan.FromMilliseconds(level))
                    {
                        Snake = MoveSnake(Snake, DirectionSnake, score);
                        if(Snake.Count == 0)
                        {
                            return "GAMEOVER";
                        }
                        startTime = DateTime.UtcNow;
                        count++;
                    }
                   
                    if (count == stage && checkEat==true)
                    {
                        randomPoint.x = randomXY.Next(40, 90);
                        randomPoint.y = randomXY.Next(2, 27);
                        checkEat = false;
                        if (randomPoint.x != 0)
                        {
                            RandomPointPanit(randomPoint);
                        }
                        count = 1;
                    }
                    if (!checkEat && count%9==0)
                    {
                        if(randomPoint.x != 0)
                        {

                            RandomPointPanit(randomPoint);
                        }
                    }

                    if (MiniGameOver.CheckEat(Snake[0], randomPoint) && !checkEat)
                    {

                        oldFood.x = randomPoint.x;
                        oldFood.y = randomPoint.y;
                        checkEat = true;
                        Snake.Add(randomPoint);
                        score++;
                        Console.SetCursorPosition(23, 3);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(score);
                        count = 1;
                    }
                    
                    if (checkEat && randomPoint.x != 0)
                    {
                        
                            //FragmentSnake(randomPoint);
                            HeaderSnakeEatting(Snake[0]);
                            FragmentSnake(Snake[1]);

                    }
                  
                    
                
                }
                input = Console.ReadKey(true);
                if(input.Key == ConsoleKey.UpArrow || input.Key == ConsoleKey.LeftArrow)
                {
                   
                    check = false;
                }
                if (input.Key == ConsoleKey.DownArrow || input.Key == ConsoleKey.RightArrow)
                {
                   
                    check = false;
                }
                if (input.Key.ToString() == DirectionSnake)
                {
                    check = true;
                }
                if (input.Key == ConsoleKey.Escape)
                {
                    check = false;
                    break;
                } 
                switch (DirectionSnake)
                {
                    case "UpArrow":
                        if (input.Key.ToString() == "DownArrow" || input.Key.ToString()== "UpArrow")
                        {
                            check = true;
                        }
                        break;
                    case "DownArrow":
                        if (input.Key.ToString() == "UpArrow" || input.Key.ToString() == "DownArrow")
                        {
                            check = true;
                        }
                        break;
                    case "LeftArrow":
                        if (input.Key.ToString() == "RightArrow" || input.Key.ToString() == "LeftArrow")
                        {
                            check = true;
                        }
                        break;
                    case "RightArrow":
                        if (input.Key.ToString() == "LeftArrow" || input.Key.ToString() == "RightArrow")
                        {
                            check = true;
                        }
                        break;
                }
                
            } while ( check );
            return input.Key.ToString();
        }

        // move snake 
        static List<Struct.DIEM> MoveSnake(List<Struct.DIEM> Snake, string DirectionMove, int score)
        {
            Struct.DIEM newPoint;
            switch (DirectionMove)
            {
                case "LeftArrow":
                    newPoint.x = Snake[0].x - 1;
                    newPoint.y = Snake[0].y;
                    Snake.Insert(0, newPoint);
                    //Check collision
                    if (MiniGameOver.CheckCollision(newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    //Check collision trailer
                    if (MiniGameOver.CheckCollisionTrailer(Snake, newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    //ve lại snake
                    RePaintSnake(newPoint,Snake[1], Snake[Snake.Count - 1]);
                    Snake.RemoveAt(Snake.Count - 1);
                    return Snake;
                case "RightArrow":
                    newPoint.x = Snake[0].x + 1;
                    newPoint.y = Snake[0].y;
                    Snake.Insert(0, newPoint);
                    //Check collision
                    if (MiniGameOver.CheckCollision(newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    //Check collision trailer
                    if (MiniGameOver.CheckCollisionTrailer(Snake, newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    // ve lại snake
                    RePaintSnake(newPoint, Snake[1], Snake[Snake.Count - 1]);
                    Snake.RemoveAt(Snake.Count - 1);
                    return Snake;
                case "UpArrow":
                    newPoint.x = Snake[0].x;
                    newPoint.y = Snake[0].y - 1;
                    Snake.Insert(0, newPoint);
                    //Check collision
                    if (MiniGameOver.CheckCollision(newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    //Check collision trailer
                    if (MiniGameOver.CheckCollisionTrailer(Snake, newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    //ve lại snake
                    RePaintSnake(newPoint, Snake[1], Snake[Snake.Count - 1]);
                    Snake.RemoveAt(Snake.Count - 1);
                    return Snake;
                case "DownArrow":
                    newPoint.x = Snake[0].x;
                    newPoint.y = Snake[0].y + 1;
                    Snake.Insert(0, newPoint);
                    //Check collision
                    if (MiniGameOver.CheckCollision(newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    //Check collision trailer
                    if (MiniGameOver.CheckCollisionTrailer(Snake, newPoint))
                    {
                        MiniGameOver.GameOver(score);
                        Snake.Clear();
                        return Snake;
                    }
                    //ve lại snake
                    RePaintSnake(newPoint, Snake[1], Snake[Snake.Count - 1]);
                    Snake.RemoveAt(Snake.Count - 1);
                    return Snake;
            }
            return Snake;

        }
        //ve lại snake
        static void RePaintSnake(Struct.DIEM Header,Struct.DIEM Neck, Struct.DIEM Trailer)
        {
            HeaderSnake(Header);
            FragmentSnake(Neck);
            DeleteTrailerSnake(Trailer);
        }











     
        ///
    }
}

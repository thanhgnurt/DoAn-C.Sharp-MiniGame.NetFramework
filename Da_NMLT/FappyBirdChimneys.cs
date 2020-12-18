using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    
    public class FappyBirdChimneys:FappyBirdBird
    {
        
        //----function FB
        public static void FappyBrid()
        {

            List<POINT> PointChimneyLeftXY1 = new List<POINT>();
            List<POINT> PointChimneyRightXY1 = new List<POINT>();
            List<POINT> PointChimneyLeftXY2 = new List<POINT>();
            List<POINT> PointChimneyRightXY2 = new List<POINT>();
            List<POINT> PointChimneyLeftXY3 = new List<POINT>();
            List<POINT> PointChimneyRightXY3 = new List<POINT>();
            List<POINT> PointChimneyLeftXY4 = new List<POINT>();
            List<POINT> PointChimneyRightXY4 = new List<POINT>();
            int c1;
            int c2=150;
            int c3 = 180;
            int c4 = 210;
            int spaceC1 = 6;
            int spaceC2 = 6;
            int spaceC3 = 6;
            int spaceC4 = 6;
            int hChimney1 = 10;
            int hChimney2 = 10;
            int hChimney3 =10;
            int hChimney4 = 10;
            bool first = true;
            int rangeC1 = 35;
            int rangeC2 = 30;
            int rangeC3 = 30;
            //int rangeC4 = 30;
            string direction;
            int skip = 1;


            // int hight = hightBird;
            POINT[] bird = new POINT[2];
            for (int i = 120; i>=-9; i--)
            {
                // speed game
                Thread.Sleep(speedGame);
                //index first----
                c1 = i;
                if (first)
                {
                    c2 = c1 + rangeC1;
                    c3 = c2 + rangeC2;
                    c4 = c3 + rangeC2;
                    
                }
               
                //
                if (c1 >= (120-rangeC1)&& !first )
                {
                    c2 = rangeC1 -9 - 120 + c1;
                    c3 = c2 + rangeC2 + 1;
                    c4 = c3 + rangeC3 + 1;

                }
                if(c1<(120-rangeC1)&& !first )
                {
                    c2 = c1 + rangeC1 + 1;
                    c3 = c2 + rangeC2 + 1;
                    c4 = c3 + rangeC3 + 1;

                }

                if(c2 >= (120-rangeC2)&& !first)
                {
                    c3 = rangeC2 - 9 - 120 + c2 ;
                    c4 = c3 + rangeC3;
                }
                if (c2 < (120 - rangeC2) && !first)
                {
                    c3 = c2 + rangeC2 + 1;

                }

                if (c3 >= (120 - rangeC3) && !first)
                {
                    c4 = rangeC3 - 9 - 120 + c3;
                }

                if (c3 < (120 - rangeC3) && !first)
                {
                    c4 = c3 + rangeC3 + 1;

                }
                //



                //reandom h and space
                if (c1 == 120 )
                {
                    Random randomObj = new Random();
                    hChimney1 = randomObj.Next(4, 17);
                    if (score >= 10)
                    {
                        spaceC1 = randomObj.Next(5, 6);
                    } else
                    {

                        spaceC1 = randomObj.Next(7, 8);
                    } 
                }
                if (c2 == 120 )
                {
                    Random randomObj = new Random();
                    hChimney2 = randomObj.Next(4, 17);
                    if (score >= 15)
                    {
                        spaceC2 = randomObj.Next(5, 6);
                    }
                    else
                    {

                        spaceC2 = randomObj.Next(7, 8);
                    }
                }
                if (c3 ==120 )
                {
                    Random randomObj = new Random();
                    hChimney3 = randomObj.Next(4, 17);
                    if (score >= 10)
                    {
                        spaceC3 = randomObj.Next(5, 6);
                    }
                    else
                    {

                        spaceC3 = randomObj.Next(7, 8);
                    }
                }
                if (c4 == 120 )
                {
                    Random randomObj = new Random();
                    hChimney4 = randomObj.Next(4, 17);

                    if (score >= 5)
                    {
                        spaceC4 = randomObj.Next(5, 6);
                    }
                    else
                    {

                        spaceC4 = randomObj.Next(7, 8);
                    }
                }

                PointChimneyLeftXY1 = CreatePointChimneyLeft(hChimney1, spaceC1, c1);
                PointChimneyRightXY1 = CreatePointChimneyRight(hChimney1, spaceC1, c1 + 8);
                PointChimneyLeftXY2 = CreatePointChimneyLeft(hChimney2, spaceC2, c2);
                PointChimneyRightXY2 = CreatePointChimneyRight(hChimney2, spaceC2, c2 + 8);
                PointChimneyLeftXY3 = CreatePointChimneyLeft(hChimney3, spaceC3, c3);
                PointChimneyRightXY3 = CreatePointChimneyRight(hChimney3, spaceC3 , c3+ 8);
                PointChimneyLeftXY4 = CreatePointChimneyLeft(hChimney4, spaceC4, c4);
                PointChimneyRightXY4 = CreatePointChimneyRight(hChimney4, spaceC4, c4 + 8);
                WriteChimneyRight(PointChimneyRightXY1);
                WriteChimneyLeft(PointChimneyLeftXY1);
                WriteChimneyRight(PointChimneyRightXY2);
                WriteChimneyLeft(PointChimneyLeftXY2);
                WriteChimneyRight(PointChimneyRightXY3);
                WriteChimneyLeft(PointChimneyLeftXY3);
                WriteChimneyRight(PointChimneyRightXY4);
                WriteChimneyLeft(PointChimneyLeftXY4);
                if (c1 > 24 && c1 < 32)
                {

                    for(int k = 0; k< PointChimneyLeftXY1.Count; k++)
                    {
                        if (hightBird == PointChimneyLeftXY1[k].Y)
                        {
                            //===end game
                            i = -10;
                           
                        }
                    }
                  
                }
                if (c2 > 24 && c2 < 32)
                {
                    for (int k = 0; k < PointChimneyLeftXY2.Count; k++)
                    {
                        if (hightBird == PointChimneyLeftXY2[k].Y)
                        {
                            //===end game- dk thoat vong lap <-9
                          i = -10;
                        }
                    }
                   
                }
                if (c3 > 24 && c3 < 32)
                {
                    for (int k = 0; k < PointChimneyLeftXY3.Count; k++)
                    {
                        if (hightBird == PointChimneyLeftXY3[k].Y)
                        {
                            //===end game
                           i = -10;
                        }
                    }

                }
                if (c4 > 24 && c4 < 32)
                {
                    for (int k = 0; k < PointChimneyLeftXY4.Count; k++)
                    {
                        if (hightBird == PointChimneyLeftXY4[k].Y)
                        {
                            //===end game
                           i = -10;
                        }
                    }
                   
                }
                //--- count score----
                if (c4 == 22 || c3 ==22 || c2 == 22 || c1 == 22)
                {
                    score++;
                    if (speedGame == 20)
                    {
                        speedGame = speedGame - 10 ;
                    }
                    if (score%10 == 2)
                    {
                        speedGame = 80;
                    }
                    PrintScore();
                }
                if (hightBird < 2 || hightBird >= 26)
                {
                    //end game
                    i = -10;
                }
                pointBir[0].Y = hightBird;
                pointBir[1].Y = hightBird;
                bird = pointBir;
                if (evenSpace)
                {
                    direction = "MoveUp";
                } else
                {
                    direction = "MoveDown";
                }
            
              
                if (direction == "MoveUp")
                {
             
                    ActiveMoveBirdUp(bird);
                    direction = "MoveDown";
                    evenSpace = false;
                }
              
                if ( direction=="MoveDown" && !evenSpace)
                {
                    DeleteShadowDown(bird);
                }

                if (skip==2 || skip ==4 || skip ==6 || skip==8 || skip ==10 && speedGame > 40)
                {

                    hightBird++;
                }
                if (skip == 5 && speedGame<=40)
                {
                    hightBird++;
                }
                pointBir[0].Y = hightBird;
                pointBir[1].Y = hightBird;
                bird = pointBir;
                if (direction == "MoveDown" &&! evenSpace)
                {
                    WriteMoveBird(bird, "Down");
                }
                if (i == -9)
                {
                    i = 121;
                    first = false;
                }
                if(skip == 10)
                {
                    skip = 0;
                }
                skip++;

            }
            GameOverFB();

        }

        //---function create chimney XY left----
        public static List<POINT> CreatePointChimneyLeft(int heightChT, int spaceChs, int x)
        {
            int top = 2;
            int bottom = 26;
            int widthCh = 8;
            List<POINT> PointXY = new List<POINT>();
            POINT temp;
            //----chimneyX topleft---
            for (int i = top; i<=heightChT; i++)
            {
                if (i<heightChT-1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                if (i == heightChT-1)
                {
                    temp.X = x - 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                    temp.X = x ;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                //---head chimneyX---
                if (i == heightChT)
                {
                    for(int j = -1; j< widthCh-1; j++)
                    {
                        temp.X = x + j;
                        temp.Y = i;
                        PointXY.Add(temp);
                    }
                }
            }
            //----chimneyX bottomleft---
            for (int i = bottom; i >= (heightChT + spaceChs) ; i--)
            {
                if(i > heightChT + spaceChs + 1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                if (i == heightChT + spaceChs + 1)
                {
                    temp.X = x - 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                if(i== heightChT+ spaceChs)
                {
                    for(int j = -1; j<widthCh-1; j++)
                    {
                        temp.X = x + j;
                        temp.Y = i;
                        PointXY.Add(temp);
                    }
                }
            }

            return PointXY;
        }

        //--function create chimney XY right---
        public static List<POINT> CreatePointChimneyRight(int heightChT, int spaceChs, int x)
        {
            int top = 2;
            int bottom = 26;
            List<POINT> PointXY = new List<POINT>();
            POINT temp;
            //----chimneyX top right---
            for (int i = top; i <= heightChT; i++)
            {
                if (i < heightChT - 1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                else
                {
                    temp.X = x + 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
               
            }
            //----chimneyX bottomleft---
            for (int i = bottom; i >= (heightChT + spaceChs); i--)
            {
                if (i > heightChT + spaceChs + 1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                else
                {
                    temp.X = x + 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
            }

            return PointXY;

        }









        //----write chimney---
        static void WriteChimneyLeft(List<POINT> chimneys)
        {
            for (int i =0; i< chimneys.Count; i++)
            {
                if(chimneys[i].X< 120 && chimneys[i].X>=0)
                {
                    Console.SetCursorPosition(chimneys[i].X, chimneys[i].Y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
            }
        }
        //----write chimney---
        static void WriteChimneyRight(List<POINT> chimneys)
        {
            for (int i = 0; i < chimneys.Count; i++)
            {
                if(chimneys[i].X < 120 && chimneys[i].X >= 0)
                {
                    Console.SetCursorPosition(chimneys[i].X, chimneys[i].Y);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
                
            }
        }





        //end
    }
}

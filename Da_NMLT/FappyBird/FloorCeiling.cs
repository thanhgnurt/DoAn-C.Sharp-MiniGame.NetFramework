using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NMLT_20880106
{
    public class FloorCeiling
    {
        //move floor----
        public static void MoveFloor(int xMove1)
        {
            int shadow1 = DeductionIndex(xMove1);
            int shadow2 = DeductionIndex(shadow1);
            int xMove2 = DeductionIndex(shadow2);
            for (int i = 119; i>=0; i--)
            {
              
               
                Console.BackgroundColor = ConsoleColor.Gray;
                if(i % 8 == xMove1 || i%8== xMove2)
                {
                    
                    Console.SetCursorPosition(i, 27);
                    Console.Write(" ");
                    Console.SetCursorPosition(i, 28);
                    Console.Write(" ");
                    Console.SetCursorPosition(i, 0);
                  
                }
               
                if (i % 8 == shadow1|| i%8 ==shadow2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(i, 27);
                    Console.Write("=");
                    Console.SetCursorPosition(i, 28);
                    Console.Write(" ");
                    Console.SetCursorPosition(i, 0);
                }


            }
        }


        public static int DeductionIndex(int index)
        {
            if (index == 0)
            {
                return 7;
            }
            return index - 1;
        }

        //---ceiling floor---
        public static void MoveCeiling(int xMove)
        {
            for(int i = 119; i>=0; i--)
            {
                if (i % 8 == xMove)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(i, 1);
                    Console.Write(" ");

                }
                if (i%8 == DeductionIndex(xMove))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(i, 1);
                    Console.Write(" ");
                }
            }
        }
        
        //---the sun---
        public static void Author()
        {
            Console.SetCursorPosition(102, 0);
            Console.Write(" ---thanhgnurt--- ");
        }


        //end
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NMLT_20880106
{
    public class FappyBirdTrees
    {
        public static void WriteTrees(int xChimney1, int randomH)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            if (randomH<27)
            {
                TreeBig(xChimney1);
                TreeMedium(xChimney1 + 16);
            }
            if (randomH<36 && randomH>=27)
            {
                TreeSmall(xChimney1);
                TreeMedium(xChimney1 + 16);
            }
            if (randomH>=36)
            {
                TreeBig(xChimney1);
                TreeMedium(xChimney1 + 16);
                TreeSmall(xChimney1 - 16);
            }
  
        }
        public static void WriteTreesStart(int x)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            int xBig = x - 80;
            int xMedium2 = x - 100;
            int xSmall = x - 64;
            int xMedium = x - 56;
            int xBig2 = x - 30;
            int xSmall2 = x - 14;
            TreeMediumDinamic(xMedium2);
            TreeMedium(xMedium2);
            TreeBigDinamic(xBig);
            TreeBig(xBig);
            TreeMediumDinamic(xMedium);
            TreeMedium(xMedium);
            TreeSmallDinamic(xSmall);
            TreeSmall(xSmall);
            TreeBigDinamic(xBig2);
            TreeBig(xBig2);
            TreeSmallDinamic(xSmall2);
            TreeSmall(xSmall2);
        }
    
        static void TreeBig(int xTree)
        {
            int hightTree = 17;
            int[] treeBigLeft = { 6, 6, 0, 3, 6, 1, 4, 7, 9, 10 };
            int[] treeBigRight = { 9, 9, 16, 13, 10, 16, 13, 12, 12, 12 };
            for (int i = 0; i< treeBigLeft.Length; i++)
            {
                int index = treeBigLeft.Length - 1;
                int xLeft= xTree + treeBigLeft[index-i];
                if (xLeft>=0 && xLeft<120)
                {
                Console.SetCursorPosition(xLeft, hightTree + i);
                Console.WriteLine("*");

                }
                int xRight = xTree + treeBigRight[index-i] ;
                if (xRight >= 0 && xRight < 120)
                {
                    Console.SetCursorPosition(xRight, hightTree + i);
                    Console.WriteLine(" ");

                }
            }
            
        }
        //
        static void TreeMedium(int xTree)
        {
            int hightTree = 19;
            int[] treeMediumLeft = { 4, 0, 2, 4, 1, 4, 5, 5};
            int[] treeMediumRight = { 6, 14, 10, 8, 12, 9, 8, 7};
            for (int i = 0; i < treeMediumLeft.Length; i++)
            {
                int index = treeMediumLeft.Length - 1;
                int xLeft = xTree + treeMediumLeft[index - i];
                if (xLeft >= 0 && xLeft < 120)
                {
                    Console.SetCursorPosition(xLeft, hightTree + i);
                    Console.WriteLine("*");

                }
                int xRight = xTree + treeMediumRight[index - i];
                if (xRight >= 0 && xRight < 120)
                {

                    Console.SetCursorPosition(xRight, hightTree + i);
                    Console.WriteLine(" ");

                }
            }

        }
        //

        static void TreeSmall(int xTree)
        {
            int hightTree = 22;
            int[] treeSmallLeft = { 2, 0, 1, 2, 2 };
            int[] treeSmallRight = { 3, 5, 5, 4, 3 };
            for (int i = 0; i < treeSmallLeft.Length; i++)
            {
                int index = treeSmallLeft.Length - 1;
                int xLeft = xTree + treeSmallLeft[index - i];
                if (xLeft >= 0 && xLeft < 120)
                {
                    Console.SetCursorPosition(xLeft, hightTree + i);
                    Console.WriteLine("*");

                }
                int xRight = xTree + treeSmallRight[index - i];
                if (xRight >= 0 && xRight < 120)
                {

                    Console.SetCursorPosition(xRight, hightTree + i);
                    Console.WriteLine(" ");

                }
            }

        }

        static void TreeSmallDinamic(int xTree)
        {
            
            int hightTree = 26;
            if(xTree >= 0 && xTree <= 119)
            {

                Console.SetCursorPosition(xTree, hightTree - 4);
                Console.WriteLine("  *  "); Console.SetCursorPosition(xTree, hightTree - 3);
                Console.WriteLine("  ** "); Console.SetCursorPosition(xTree, hightTree - 2);
                Console.WriteLine(" **** "); Console.SetCursorPosition(xTree, hightTree -1);
                Console.WriteLine("***** "); Console.SetCursorPosition(xTree, hightTree );
                Console.WriteLine("  *  ");
            }



        }

        static void TreeBigDinamic(int xTree)
        {
            int hightTree = 26;
            if(xTree>=0 && xTree <= 119)
            {

                Console.SetCursorPosition(xTree, hightTree - 9);
                Console.WriteLine("          **     "); Console.SetCursorPosition(xTree, hightTree - 8);
                Console.WriteLine("         ***     "); Console.SetCursorPosition(xTree, hightTree - 7);
                Console.WriteLine("       *****     "); Console.SetCursorPosition(xTree, hightTree - 6);
                Console.WriteLine("    *********    "); Console.SetCursorPosition(xTree, hightTree - 5);
                Console.WriteLine(" *************** "); Console.SetCursorPosition(xTree, hightTree - 4);
                Console.WriteLine("      ****       "); Console.SetCursorPosition(xTree, hightTree - 3);
                Console.WriteLine("   **********    "); Console.SetCursorPosition(xTree, hightTree - 2);
                Console.WriteLine("**************** "); Console.SetCursorPosition(xTree, hightTree - 1);
                Console.WriteLine("      ***        "); Console.SetCursorPosition(xTree, hightTree);
                Console.WriteLine("      ***        ");
            }

        }


        static void TreeMediumDinamic(int xTree)
        {
            int hightTree = 26;
            if (xTree >= 0 && xTree <= 119)
            {

                Console.SetCursorPosition(xTree, hightTree - 7);
                Console.WriteLine("     **      "); Console.SetCursorPosition(xTree, hightTree - 6);
                Console.WriteLine("     ***     "); Console.SetCursorPosition(xTree, hightTree - 5);
                Console.WriteLine("    *****    "); Console.SetCursorPosition(xTree, hightTree - 4);
                Console.WriteLine(" *********** "); Console.SetCursorPosition(xTree, hightTree - 3);
                Console.WriteLine("    ****     "); Console.SetCursorPosition(xTree, hightTree - 2);
                Console.WriteLine("  ********   "); Console.SetCursorPosition(xTree, hightTree - 1);
                Console.WriteLine("************** "); Console.SetCursorPosition(xTree, hightTree );
                Console.WriteLine("    **        ");
            }


        }









        //end
    }
}

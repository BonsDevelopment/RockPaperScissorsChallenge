using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cMenu;

namespace RockPaperScissorsChallenge
{
    public class DisplayStuff
    {
        private static hMenuItemConfig hMenu1 = new hMenuItemConfig(ConsoleColor.Green,false,'|',ConsoleColor.White);
        private static bool loopFlag = true;
        public DisplayStuff()
        {
            hMenu1.AddList(new[] {"Rock","Paper","Scissors" });
            
        }

        public int InitializeMenu(bool SetFlag)
        {
            loopFlag = SetFlag;
            int returnString = 0;

            while (loopFlag)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        hMenu1.DecrementList();
                        break;

                    case ConsoleKey.DownArrow:
                        hMenu1.IncrementList();
                        break;

                    case ConsoleKey.Enter:
                        returnString = hMenu1.IndexOf(hMenu1[hMenu1.selectedItem]);
                        loopFlag = false;
                        break;
                      
                }
            }

            return returnString;
        }

    }
}


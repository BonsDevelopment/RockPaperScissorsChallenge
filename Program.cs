using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsChallenge
{
    class Program
    {
        enum Selection
        {
            Rock,
            Paper,
            Scissors
        }

        private static DisplayStuff displayObject = new DisplayStuff();
        private static Random rNumber = new Random();
        private const char bufferChar = '\n';

        static void Main(string[] args)
        {
            int playerSelection = displayObject.InitializeMenu(true);
            Result(playerSelection);
            Console.ReadLine();

        }

        private static int AiChoice()
        {
            return rNumber.Next(0, 2);
        }

        private static void Result(int playSel)
        {
            int aiTurn = AiChoice();
           
            Console.WriteLine(bufferChar);

            Console.WriteLine("AI: " + Enum.GetName(typeof(Selection),aiTurn));
            if ((Selection)aiTurn == (Selection)playSel)
            {
                Console.WriteLine("Tie!");
            }

            else if(aiTurn == (int)Selection.Rock)
            {
                 if((Selection)playSel == Selection.Paper)
                    Console.WriteLine("Paper beats rock! You won!");
                 if ((Selection)playSel == Selection.Scissors)
                    Console.WriteLine("Rock beats scissors! You lost!");
            }

            else if (aiTurn == (int)Selection.Paper)
            {
                if ((Selection)playSel == Selection.Rock)
                    Console.WriteLine("Paper beats rock! You lost!");
                if ((Selection)playSel == Selection.Scissors)
                    Console.WriteLine("Scissors beat paper! You won!");                   
            }

            else if (aiTurn == (int)Selection.Scissors)
            {
                if ((Selection)playSel == Selection.Rock)
                    Console.WriteLine("Rock beats scissors! You lost!");
                if ((Selection)playSel == Selection.Paper)
                    Console.WriteLine("Scissors beat paper! You lost!");
            }

            Main(new[] { "" });
        }

       
    }
}

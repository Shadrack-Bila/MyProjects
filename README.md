using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//Programmed by bila Shadrack

/*You're in a competition with another guy. You take turns hammering the nail. Whoever hits the last blow wins. The last blow means that the nail will be completely hammered.

Your input is the length of the nail (0 < l < 100). You can hit with different strengths: 1, 2 or 3 units of nail length at a time. Your opponent is stronger than you, and his hitting strength can be 2, 3 or 4 units, but you have a friend in judging who has excluded all hopeless initial l values for you. You make the first strike.

Return the strength of your current strike (1, 2 or 3), depending on the remaining length of the nail.

The tests will invoke your and your opponent's solutions with the remaining length of the nail, as long as l > 0. Then, if l <= 0 after your hit, you win the contest and pass the kata.

*/
namespace theNailGame
{
    internal class Program
    {
         static int nailLenght = 100 , counter =0;
       
        static void Main(string[] args)
        {
            mainMenu();
        }
        static void mainMenu()
        {
            int userOption;
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("             MAIN MENU          ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("(1)Launch game");
            Console.WriteLine("(2)Replay");
            Console.WriteLine("(3)Instructions");
            Console.WriteLine("(4)EXIT GAME");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nPlease selelct an option to continue");

            try
            {
                userOption = Convert.ToInt32(Console.ReadLine());

                switch(userOption)
                {
                    case 1:
                        startGame();
                        break;

                    case 2:
                        replay();
                        break;

                    case 3:
                        instructions();
                        break;

                    case 4:
                        exit();
                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please select one of the given options");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        mainMenu();
                        break;

                }
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please select one of the given options");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                mainMenu();
            }

        }
        static void startGame()
        {
            while(nailLenght >= 0)
            {
                counter++;
                Console.Clear();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"       NAIL LENGHT : {nailLenght}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Player[{counter}]");
                Console.Write    ("Hit the hammer : ");
                processing();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPress any key to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

                if (nailLenght > 0)
                {
                    if (counter == 2)
                    {
                        counter = 0;
                    }
                }
            }

            //this part of the programme determines who thw winner is
            //winner message for player 1
            if (nailLenght <= 0 && counter == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n!!!!!!!!!! CONGRATULATIONS!!!!!!!!!");
                Console.WriteLine("\n           PLAYER[1] WINS          ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPRESS ANY KEY TO GO TO MAIN MENU");
                Console.ReadKey();

            }
            //winner message for player 2
            if (nailLenght <= 0 && counter == 2 )
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n!!!!!!!!!! CONGRATULATIONS!!!!!!!!!");
                Console.WriteLine("\n           PLAYER[2] WINS          ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPRESS ANY KEY TO GO TO MAIN MENU");
                Console.ReadKey();


            }
            mainMenu();
        }
        static void processing()
        {
            //this is where all the game processing and calculations are done
            try
            {
                int player;
                player = Convert.ToInt32(Console.ReadLine());
                //counter that is equal to 1 controls the actions for player 1
                if (counter == 1)
                {
                    if (player >= 1 && player <= 3)
                        nailLenght = nailLenght - player;

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nyou are not that strong therefore \nyou forfeight this round\n");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }
                //counter that is equal to 1 controls the actions for player 2
                else if (counter == 2)
                {
                    if (player >= 2 && player <= 4)
                        nailLenght = nailLenght - player;

                    else if(player == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou are way too strong to hit with such \nstrenght\n");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nyou are not that strong therefore \nyou forfeight this round\n");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }

 
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nENTER A NUMBER NEXT ROUND");
                Console.ForegroundColor = ConsoleColor.White;

            }
           // counter++;
        }

        static void replay()
        {
            startGame();
        }
        static void instructions()
        {
            //these are the instructions on how the game works\how to play the game
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("             WELCOME              ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("           Greetings !!!          \n");
            Console.WriteLine("You're in a competition with another\nguy");
            Console.WriteLine("You take turns hammering the nail.");
            Console.WriteLine("Whoever hits the last blow wins.");
            Console.WriteLine("The last blow means that the nail ");
            Console.WriteLine("will be completely hammered.\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("********************************************************************\n");
            Console.WriteLine("Your input is the length of the nail (0 < l < 100).");
            Console.WriteLine(" You can hit with different strengths:");
            Console.WriteLine(" 1, 2 or 3 units of nail length at a time. ");
            Console.WriteLine("Your opponent is stronger than you, ");
            Console.WriteLine("and his hitting strength can be 2, 3 or 4 units,");
            Console.WriteLine(" but you have a friend in judging who has excluded all");
            Console.WriteLine(" hopeless initial l values for you. You make the first strike.\n");
            Console.WriteLine("********************************************************************\n");
            Console.WriteLine("PLEASE ENTER ANY KEY TO GO TO BACK...");
            Console.ReadKey();
            mainMenu();
        }
        static void exit()
        {
            //exit menu
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("        YOU ARE ABOUT TO EXIT GAME     ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Select (1) to go to main menu");
            Console.WriteLine("select (2) to close program");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            try
            {
                int userInput;
                userInput = Convert.ToInt32(Console.ReadLine());       
                if(userInput==1)
                    mainMenu();
                
                else
                    Console.ReadKey();

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Select one of the given options");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                exit();
            }

        }
    }
}
